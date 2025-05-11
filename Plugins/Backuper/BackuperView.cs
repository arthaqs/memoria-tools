using MemoriaToolsInterfaces;
using System;
using System.IO;
using System.IO.Compression;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Backuper
{
    public partial class BackuperView : UserControl, IPluginView
    {
        public string Title => "Backuper";
        public string ButtonName => "Backuper";
        public event EventHandler<ViewEventArgs> OnLogRequested;
        private const string m_settingsFile = "backuper_settings.json";
        
        public BackuperView()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            LoadSettings();
        }

        private void buttonFrom_Click(object sender, EventArgs e)
        {
            var selectedFolder = folderBrowserDialogFrom.ShowDialog();
            if (selectedFolder == DialogResult.OK)
            {
                textBoxFrom.Text = folderBrowserDialogFrom.SelectedPath;
            }
        }

        private void buttonTo_Click(object sender, EventArgs e)
        {
            var selectedFolder = folderBrowserDialogTo.ShowDialog();
            if (selectedFolder == DialogResult.OK)
            {
                textBoxTo.Text = folderBrowserDialogTo.SelectedPath;
            }
        }

        private void buttonBackup_Click(object sender, EventArgs e)
        {
            AddToLog($"Backup started with title {textBoxBackupTitle.Text}");
            
            
            
            if (string.IsNullOrEmpty(textBoxFrom.Text) || string.IsNullOrEmpty(textBoxTo.Text))
            {
                MessageBox.Show("Please select both source and destination folders.");
                return;
            }
            
            AddToLog($"Backing up from {textBoxFrom.Text}.");
            AddToLog($"Backing up to {textBoxTo.Text}.");

            //var copyResult = CopyFiles(textBoxFrom.Text, textBoxTo.Text);
            var backupResult = CreateZipBackup(textBoxFrom.Text, textBoxTo.Text, textBoxBackupTitle.Text);
            if (backupResult == true)
            {
                AddToLog($"Backup completed");
                OnLogRequested?.Invoke(this, new ViewEventArgs()
                {
                    Message = $"Backup completed"
                });
            }
            else
            {
                AddToLog($"Backup failed");
                OnLogRequested?.Invoke(this, new ViewEventArgs()
                {
                    Message = $"\"Backup failed."
                });
            }

            SaveSettings();
        }

        private void AddToLog(string text)
        {
            richTextBoxLogs.AppendText($"{DateTime.Now}: {text}{Environment.NewLine}");
        }

        //private bool CopyFiles(string from, string to)
        //{
        //    try
        //    {
        //        string[] m_files = Directory.GetFiles(from);

        //        foreach (string m_filePath in m_files)
        //        {
        //            string m_fileName = Path.GetFileName(m_filePath);
        //            string m_destFilePath = Path.Combine(to, m_fileName);

        //            File.Copy(m_filePath, m_destFilePath, overwrite: true);
        //        }

        //        labelLastBackup.Text = DateTime.Now.ToString();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}

        private bool CreateZipBackup(string from, string to, string title)
        {
            string m_tempZipPath = "";
            try
            {
                string datetimeString = DateTime.Now.ToString("yyyy-MM-dd_HH-mm");
                string backupFileName = $"{title}_{datetimeString}.zip";
                m_tempZipPath = Path.Combine(from, backupFileName); // Temporary zip in source folder
                string finalZipPath = Path.Combine(to, backupFileName);

                string[] m_files = Directory.GetFiles(from);
                int m_totalFiles = m_files.Length;

                if (m_totalFiles == 0)
                {
                    AddToLog("No files to backup.");
                    return false;
                }

                //-------------------------------
                // Phase 1: Zipping
                //-------------------------------
                AddToLog("Zipping files...");
                progressBarMain.Value = 0;
                progressBarMain.Maximum = m_totalFiles;

                using (var zip = ZipFile.Open(m_tempZipPath, ZipArchiveMode.Create))
                {
                    foreach (string m_filePath in m_files)
                    {
                        string m_fileName = Path.GetFileName(m_filePath);
                        zip.CreateEntryFromFile(m_filePath, m_fileName, CompressionLevel.Fastest);

                        progressBarMain.PerformStep();
                        Application.DoEvents();
                    }
                }

                //-------------------------------
                // Phase 2: Copying ZIP to destination
                //-------------------------------
                AddToLog("Copying backup to destination...");
                progressBarMain.Value = 0;
                FileInfo m_zipInfo = new FileInfo(m_tempZipPath);
                long m_totalBytes = m_zipInfo.Length;
                long m_bytesCopied = 0;

                progressBarMain.Maximum = 100; // percent

                const int bufferSize = 81920; // 80 KB
                byte[] buffer = new byte[bufferSize];

                using (FileStream sourceStream = File.OpenRead(m_tempZipPath))
                using (FileStream destinationStream = File.Create(finalZipPath))
                {
                    int bytesRead;
                    while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        destinationStream.Write(buffer, 0, bytesRead);
                        m_bytesCopied += bytesRead;

                        int progress = (int)((double)m_bytesCopied / m_totalBytes * 100);
                        progressBarMain.Value = Math.Min(progress, 100);
                        Application.DoEvents();
                    }
                }

                //-------------------------------
                // Phase 3: Deleting temp ZIP
                //-------------------------------
                AddToLog("Cleaning up temporary file...");
                if (File.Exists(m_tempZipPath))
                    File.Delete(m_tempZipPath);

                labelLastBackup.Text = DateTime.Now.ToString();
                return true;
            }
            catch (Exception ex)
            {
                AddToLog($"Error during backup: {ex.Message}");

                // Ensure temp file is deleted if something goes wrong
                if (!string.IsNullOrEmpty(m_tempZipPath) && File.Exists(m_tempZipPath))
                {
                    try { File.Delete(m_tempZipPath); }
                    catch { /* ignore */ }
                }

                return false;
            }
        }


        private void SaveSettings()
        {
            var m_settings = new BackuperSettings
            {
                FromPath = textBoxFrom.Text,
                ToPath = textBoxTo.Text,
                BackupTitle = textBoxBackupTitle.Text,
                LastBackup = labelLastBackup.Text
            };

            try
            {
                File.WriteAllText(m_settingsFile, JsonSerializer.Serialize(m_settings, new JsonSerializerOptions { WriteIndented = true }));
            }
            catch (Exception ex)
            {
                AddToLog($"Error saving settings: {ex.Message}");
            }
        }

        private void LoadSettings()
        {
            try
            {
                if (File.Exists(m_settingsFile))
                {
                    var json = File.ReadAllText(m_settingsFile);
                    var m_settings = JsonSerializer.Deserialize<BackuperSettings>(json);

                    if (m_settings != null)
                    {
                        textBoxFrom.Text = m_settings.FromPath;
                        textBoxTo.Text = m_settings.ToPath;
                        textBoxBackupTitle.Text = m_settings.BackupTitle;
                        labelLastBackup.Text = m_settings.LastBackup;
                    }
                }
            }
            catch (Exception ex)
            {
                AddToLog($"Error loading settings: {ex.Message}");
            }
        }
    }
}
