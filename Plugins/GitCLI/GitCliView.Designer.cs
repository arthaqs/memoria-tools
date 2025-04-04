using System.Drawing;
using System.Windows.Forms;

namespace MemoriaTools
{
    partial class GitCliView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titlePanel = new Panel();
            titleLabel = new Label();
            contentPanel = new Panel();
            reuseLastCommentButton = new Button();
            label5 = new Label();
            lastCommitCommentRichTextBox = new RichTextBox();
            label4 = new Label();
            buttonOpenLocalRepo = new Button();
            localRepoFolderPathTextBox = new TextBox();
            label3 = new Label();
            logRichTextBox = new RichTextBox();
            buttonTestRepo = new Button();
            bottomStatusStrip = new StatusStrip();
            buttonPull = new Button();
            buttonPush = new Button();
            commitCommentRichTextBox = new RichTextBox();
            repoNameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            localRepofolderBrowserDialog = new FolderBrowserDialog();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            label6 = new Label();
            groupBox5 = new GroupBox();
            titlePanel.SuspendLayout();
            contentPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // titlePanel
            // 
            titlePanel.Controls.Add(titleLabel);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(0, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(880, 41);
            titlePanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 14F);
            titleLabel.Location = new Point(12, 13);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(67, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Git CLI";
            // 
            // contentPanel
            // 
            contentPanel.Controls.Add(groupBox5);
            contentPanel.Controls.Add(label6);
            contentPanel.Controls.Add(groupBox4);
            contentPanel.Controls.Add(groupBox3);
            contentPanel.Controls.Add(groupBox2);
            contentPanel.Controls.Add(groupBox1);
            contentPanel.Controls.Add(bottomStatusStrip);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 41);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(880, 637);
            contentPanel.TabIndex = 1;
            // 
            // reuseLastCommentButton
            // 
            reuseLastCommentButton.Font = new Font("Segoe UI", 8F);
            reuseLastCommentButton.Location = new Point(6, 129);
            reuseLastCommentButton.Name = "reuseLastCommentButton";
            reuseLastCommentButton.Size = new Size(164, 23);
            reuseLastCommentButton.TabIndex = 15;
            reuseLastCommentButton.Text = "Reuse last commit comment";
            reuseLastCommentButton.TextAlign = ContentAlignment.MiddleLeft;
            reuseLastCommentButton.UseVisualStyleBackColor = true;
            reuseLastCommentButton.Click += reuseLastCommentButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 319);
            label5.Name = "label5";
            label5.Size = new Size(128, 15);
            label5.TabIndex = 14;
            label5.Text = "Last commit comment";
            // 
            // lastCommitCommentRichTextBox
            // 
            lastCommitCommentRichTextBox.Location = new Point(6, 337);
            lastCommitCommentRichTextBox.Name = "lastCommitCommentRichTextBox";
            lastCommitCommentRichTextBox.ReadOnly = true;
            lastCommitCommentRichTextBox.Size = new Size(458, 71);
            lastCommitCommentRichTextBox.TabIndex = 13;
            lastCommitCommentRichTextBox.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 30);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 12;
            label4.Text = "Local repository folder";
            // 
            // buttonOpenLocalRepo
            // 
            buttonOpenLocalRepo.Font = new Font("Segoe UI", 8F);
            buttonOpenLocalRepo.Location = new Point(268, 48);
            buttonOpenLocalRepo.Name = "buttonOpenLocalRepo";
            buttonOpenLocalRepo.Size = new Size(61, 23);
            buttonOpenLocalRepo.TabIndex = 4;
            buttonOpenLocalRepo.Text = "Open";
            buttonOpenLocalRepo.UseVisualStyleBackColor = true;
            buttonOpenLocalRepo.Click += buttonOpenLocalRepo_Click;
            // 
            // localRepoFolderPathTextBox
            // 
            localRepoFolderPathTextBox.Location = new Point(6, 48);
            localRepoFolderPathTextBox.Name = "localRepoFolderPathTextBox";
            localRepoFolderPathTextBox.Size = new Size(256, 23);
            localRepoFolderPathTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 9;
            label3.Text = "Git responses";
            // 
            // logRichTextBox
            // 
            logRichTextBox.Location = new Point(6, 37);
            logRichTextBox.Name = "logRichTextBox";
            logRichTextBox.ReadOnly = true;
            logRichTextBox.Size = new Size(458, 274);
            logRichTextBox.TabIndex = 8;
            logRichTextBox.Text = "";
            logRichTextBox.WordWrap = false;
            // 
            // buttonTestRepo
            // 
            buttonTestRepo.Font = new Font("Segoe UI", 8F);
            buttonTestRepo.Location = new Point(194, 43);
            buttonTestRepo.Name = "buttonTestRepo";
            buttonTestRepo.Size = new Size(140, 23);
            buttonTestRepo.TabIndex = 7;
            buttonTestRepo.Text = "Test Connection";
            buttonTestRepo.UseVisualStyleBackColor = true;
            buttonTestRepo.Click += buttonTestRepo_Click;
            // 
            // bottomStatusStrip
            // 
            bottomStatusStrip.Location = new Point(0, 615);
            bottomStatusStrip.Name = "bottomStatusStrip";
            bottomStatusStrip.Size = new Size(880, 22);
            bottomStatusStrip.TabIndex = 6;
            bottomStatusStrip.Text = "bottomStatusStrip";
            // 
            // buttonPull
            // 
            buttonPull.Font = new Font("Segoe UI", 8F);
            buttonPull.Location = new Point(12, 22);
            buttonPull.Name = "buttonPull";
            buttonPull.Size = new Size(75, 23);
            buttonPull.TabIndex = 5;
            buttonPull.Text = "Pull";
            buttonPull.UseVisualStyleBackColor = true;
            buttonPull.Click += buttonPull_Click;
            // 
            // buttonPush
            // 
            buttonPush.Font = new Font("Segoe UI", 8F);
            buttonPush.Location = new Point(176, 129);
            buttonPush.Name = "buttonPush";
            buttonPush.Size = new Size(153, 23);
            buttonPush.TabIndex = 2;
            buttonPush.Text = "Commit and Push";
            buttonPush.UseVisualStyleBackColor = true;
            buttonPush.Click += buttonPush_Click;
            // 
            // commitCommentRichTextBox
            // 
            commitCommentRichTextBox.Location = new Point(6, 46);
            commitCommentRichTextBox.Name = "commitCommentRichTextBox";
            commitCommentRichTextBox.Size = new Size(323, 77);
            commitCommentRichTextBox.TabIndex = 1;
            commitCommentRichTextBox.Text = "";
            // 
            // repoNameTextBox
            // 
            repoNameTextBox.Location = new Point(6, 43);
            repoNameTextBox.Name = "repoNameTextBox";
            repoNameTextBox.Size = new Size(180, 23);
            repoNameTextBox.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 28);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 1;
            label2.Text = "Commit comment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 0;
            label1.Text = "Remote repository name";
            // 
            // localRepofolderBrowserDialog
            // 
            localRepofolderBrowserDialog.SelectedPath = "e:\\projects\\software";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(localRepoFolderPathTextBox);
            groupBox1.Controls.Add(buttonOpenLocalRepo);
            groupBox1.Location = new Point(18, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(340, 94);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Config";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(buttonPush);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(commitCommentRichTextBox);
            groupBox2.Controls.Add(reuseLastCommentButton);
            groupBox2.Location = new Point(18, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(340, 169);
            groupBox2.TabIndex = 18;
            groupBox2.TabStop = false;
            groupBox2.Text = "Commit and Push";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(repoNameTextBox);
            groupBox3.Controls.Add(buttonTestRepo);
            groupBox3.Location = new Point(18, 352);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(340, 79);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Misc";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(buttonPull);
            groupBox4.Location = new Point(18, 115);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(340, 56);
            groupBox4.TabIndex = 20;
            groupBox4.TabStop = false;
            groupBox4.Text = "Fetch and Pull";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 7F);
            label6.Location = new Point(18, 459);
            label6.Name = "label6";
            label6.Size = new Size(177, 144);
            label6.TabIndex = 21;
            label6.Text = "How it works\r\n\r\nPull: \r\ngit pull main origin\r\n\r\nCommit and push:\r\ngit add .\r\ngit commit -m {Commit comment}\r\ngit push origin main\r\n\r\nTest\r\ngit ls-remote {Remote repository name}\r\n";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(label3);
            groupBox5.Controls.Add(logRichTextBox);
            groupBox5.Controls.Add(label5);
            groupBox5.Controls.Add(lastCommitCommentRichTextBox);
            groupBox5.Location = new Point(395, 15);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(470, 416);
            groupBox5.TabIndex = 22;
            groupBox5.TabStop = false;
            groupBox5.Text = "Logs";
            // 
            // GitCliView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(contentPanel);
            Controls.Add(titlePanel);
            Name = "GitCliView";
            Size = new Size(880, 678);
            Load += GitCliView_Load;
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel titlePanel;
        private Panel contentPanel;
        private Label titleLabel;
        private StatusStrip bottomStatusStrip;
        private Button buttonPull;
        private Button buttonPush;
        private RichTextBox commitCommentRichTextBox;
        private TextBox repoNameTextBox;
        private Label label2;
        private Label label1;
        private Button buttonTestRepo;
        private RichTextBox logRichTextBox;
        private Label label3;
        private Label label4;
        private Button buttonOpenLocalRepo;
        private TextBox localRepoFolderPathTextBox;
        private FolderBrowserDialog localRepofolderBrowserDialog;
        private Label label5;
        private RichTextBox lastCommitCommentRichTextBox;
        private Button reuseLastCommentButton;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label label6;
        private GroupBox groupBox5;
    }
}
