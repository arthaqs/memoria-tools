using MemoriaToolsInterfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoriaTools.Controllers
{
    public class MemoriaToolsController
    {
        public void LoadPluginFromDialog()
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "DLL Files (*.dll)|*.dll";
                dialog.Title = "Select Plugin Main DLL";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedDllPath = dialog.FileName;
                    string selectedDllName = Path.GetFileNameWithoutExtension(selectedDllPath);
                    string selectedDllFolder = Path.GetDirectoryName(selectedDllPath);
                    string targetPluginFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "plugins", selectedDllName);

                    try
                    {
                        Directory.CreateDirectory(targetPluginFolder);

                        // Copy all DLLs from selected folder to the new plugin folder
                        foreach (string dll in Directory.GetFiles(selectedDllFolder, "*.dll"))
                        {
                            string destPath = Path.Combine(targetPluginFolder, Path.GetFileName(dll));
                            File.Copy(dll, destPath, overwrite: true);
                        }

                        MessageBox.Show($"Plugin '{selectedDllName}' successfully imported.", "Plugin Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to copy plugin files: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public UserControl GetPluginView(string pluginPath)
        {
            try
            {
                var pluginDirectory = Path.GetDirectoryName(pluginPath);

                ResolveEventHandler resolveHandler = (sender, args) =>
                {
                    string dependencyName = new AssemblyName(args.Name).Name + ".dll";
                    string dependencyPath = Path.Combine(pluginDirectory, dependencyName);

                    if (File.Exists(dependencyPath))
                    {
                        return Assembly.LoadFrom(dependencyPath);
                    }

                    return null;
                };

                AppDomain.CurrentDomain.AssemblyResolve += resolveHandler;

                var assembly = Assembly.LoadFrom(pluginPath);
                var viewType = FindViewTypeInAssembly(assembly);

                if (viewType != null && typeof(IPluginView).IsAssignableFrom(viewType))
                {
                    var instance = (UserControl)Activator.CreateInstance(viewType);

                    if (instance is IPluginView pluginView)
                    {
                        pluginView.Initialize();
                        Debug.WriteLine($"Loaded plugin: {pluginView.Title}");
                    }

                    return instance;
                }
                else
                {
                    Debug.WriteLine("No compatible UserControl implementing IPluginView found.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading plugin view: {ex}");
                return null;
            }
        }

        public List<Button> GeneratePluginButtons()
        {
            var folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "plugins");
            var buttons = new List<Button>();

            foreach (var dir in Directory.GetDirectories(folderPath))
            {
                var dllFile = Directory.GetFiles(dir, "*.dll").FirstOrDefault();

                if (dllFile == null)
                    continue;

                try
                {
                    var button = new Button()
                    {
                        Name = Path.GetFileNameWithoutExtension(dllFile),
                        Text = Path.GetFileNameWithoutExtension(dllFile),
                        Tag = dllFile
                    };

                    buttons.Add(button);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine($"Failed to load plugin in {dir}: {ex.Message}");
                }
            }

            return buttons;
        }

        private Type FindViewTypeInAssembly(Assembly assembly)
        {
            foreach (var type in assembly.GetTypes())
            {
                if (type.IsSubclassOf(typeof(UserControl)) && typeof(IPluginView).IsAssignableFrom(type) && !type.IsAbstract)
                {
                    return type;
                }
            }
            return null;
        }
    }
}
