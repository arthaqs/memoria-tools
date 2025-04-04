namespace MemoriaTools;

public partial class MemoraToolsView : Form
{
    public MemoraToolsView()
    {
        InitializeComponent();
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
        GitCliView view = new GitCliView();
        contentPanel.Controls.Add(view);
        view.Dock = DockStyle.Fill;
    }
}