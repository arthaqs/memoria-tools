using MemoriaTools.Controllers;
using System;
using System.Windows.Forms;

namespace MemoriaTools
{
    public partial class GitCliView : UserControl
    {
        private GitController m_gitController;

        public GitCliView()
        {
            InitializeComponent();

            m_gitController = new GitController();
        }

        private void GitCliView_Load(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(Properties.Settings.Default.LastGitSelectedFolder))
            //{
            //    localRepoFolderPathTextBox.Text = Properties.Settings.Default.LastGitSelectedFolder;
            //}
        }

        private void buttonTestRepo_Click(object sender, EventArgs e)
        {
            var output = m_gitController.TestConnection(repoNameTextBox.Text);
            logRichTextBox.AppendText(output);
        }

        private void buttonPull_Click(object sender, EventArgs e)
        {
            var output = m_gitController.Pull(localRepoFolderPathTextBox.Text, out var message);
            logRichTextBox.AppendText(output);
            logRichTextBox.AppendText("\n");
            logRichTextBox.AppendText(message);
            logRichTextBox.AppendText("\n");
        }

        private void buttonOpenLocalRepo_Click(object sender, EventArgs e)
        {
            localRepofolderBrowserDialog.ShowDialog();
            var folderPath = localRepofolderBrowserDialog.SelectedPath;

            if (!string.IsNullOrEmpty(folderPath))
            {
                localRepoFolderPathTextBox.Text = folderPath.ToString();

                //Properties.Settings.Default.LastGitSelectedFolder = folderPath;
                //Properties.Settings.Default.Save(); 
            }

            logRichTextBox.AppendText("\n");
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            var commitComment = commitCommentRichTextBox.Text;
            var output = m_gitController.CommitAndPush(localRepoFolderPathTextBox.Text, commitComment);
            logRichTextBox.AppendText(output);
            logRichTextBox.AppendText("\n");
            lastCommitCommentRichTextBox.Text = commitComment;
            commitCommentRichTextBox.Text = "";
        }

        private void reuseLastCommentButton_Click(object sender, EventArgs e)
        {
            commitCommentRichTextBox.Text = lastCommitCommentRichTextBox.Text;
        }
    }
}
