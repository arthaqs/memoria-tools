using MemoriaTools.Controllers;
using MemoriaToolsInterfaces;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace MemoriaTools
{
    public partial class MemoraToolsView : Form
    {
        private MemoriaToolsController m_memoriaToolsController;

        public MemoraToolsView()
        {
            InitializeComponent();
            m_memoriaToolsController = new MemoriaToolsController();
        }

        private void gitToCliButton_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            //GitCliView view = new GitCliView();
            //contentPanel.Controls.Add(view);
            //view.Dock = DockStyle.Fill;
        }

        private void MemoraToolsView_Load(object sender, EventArgs e)
        {
            LoadPluginButtons();
        }


        private void DllButton_Click(object sender, EventArgs e, string dllPath)
        {
            var view = m_memoriaToolsController.GetPluginView(dllPath);

            if (view == null)
            {
                MessageBox.Show($"Failed to load plugin view from {dllPath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(view);
            view.Dock = DockStyle.Fill;

            // Correct way to check and cast to interface
            if (view is IPluginView pluginView)
            {
                pluginView.OnLogRequested += V_OnLogRequested;
            }
        }

        private void LoadPluginButtons()
        {
            sideFlowLayoutPanel.Controls.Clear();

            var buttons = m_memoriaToolsController.GeneratePluginButtons();

            foreach (var button in buttons)
            {
                // Renaming 'e' to 'args' to avoid conflict
                button.Click += (obj, args) => DllButton_Click(obj, args, (string)button.Tag);
                sideFlowLayoutPanel.Controls.Add(button);
                button.Size = new Size(sidePanel.Size.Width - 5, 40);
            }
        }


        private void V_OnLogRequested(object sender, ViewEventArgs e)
        {
            logBottomToolStripLabel.Text = e.Message;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void menuManagePlugins_Click(object sender, EventArgs e)
        {

        }

        private void loadPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_memoriaToolsController.LoadPluginFromDialog();
            LoadPluginButtons();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}