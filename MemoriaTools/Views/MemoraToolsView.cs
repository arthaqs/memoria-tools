using MemoriaTools.Controllers;
using MemoriaToolsInterfaces;
using System.Reflection;

namespace MemoriaTools;

public partial class MemoraToolsView : Form
{
    private MemoriaToolsController m_memoriaToolsController;

    public MemoraToolsView()
    {
        InitializeComponent();
        m_memoriaToolsController = new MemoriaToolsController();
    }

    private void obsidianToGitButton_Click(object sender, EventArgs e)
    {
        contentPanel.Controls.Clear();
        ObsidianToGitView view = new ObsidianToGitView();
        contentPanel.Controls.Add(view);
        view.Dock = DockStyle.Fill;
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
        var buttons = m_memoriaToolsController.GeneratePluginButtons();

        foreach (var button in buttons)
        {
            button.Click += (sender, e) => DllButton_Click(sender, e, button.Name);
            sideFlowLayoutPanel.Controls.Add(button);
            button.Size = new Size(132, 41);
        }
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


    private void V_OnLogRequested(object? sender, ViewEventArgs e)
    {
        logBottomToolStripLabel.Text = e.Message;
    }
}