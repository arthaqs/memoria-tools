using System.Drawing;
using System.Windows.Forms;

namespace Backuper
{
    partial class BackuperView
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackuperView));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.labelLastBackup = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxLogs = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBackupTitle = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.folderBrowserDialogFrom = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogTo = new System.Windows.Forms.FolderBrowserDialog();
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imageListMain = new System.Windows.Forms.ImageList(this.components);
            this.buttonBackup = new System.Windows.Forms.Button();
            this.buttonTo = new System.Windows.Forms.Button();
            this.buttonFrom = new System.Windows.Forms.Button();
            this.titlePanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(754, 36);
            this.titlePanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.titleLabel.Location = new System.Drawing.Point(10, 11);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(90, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Backuper";
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.label6);
            this.contentPanel.Controls.Add(this.label5);
            this.contentPanel.Controls.Add(this.progressBarMain);
            this.contentPanel.Controls.Add(this.labelLastBackup);
            this.contentPanel.Controls.Add(this.label4);
            this.contentPanel.Controls.Add(this.richTextBoxLogs);
            this.contentPanel.Controls.Add(this.buttonBackup);
            this.contentPanel.Controls.Add(this.buttonTo);
            this.contentPanel.Controls.Add(this.buttonFrom);
            this.contentPanel.Controls.Add(this.label3);
            this.contentPanel.Controls.Add(this.label2);
            this.contentPanel.Controls.Add(this.label1);
            this.contentPanel.Controls.Add(this.textBoxBackupTitle);
            this.contentPanel.Controls.Add(this.textBoxTo);
            this.contentPanel.Controls.Add(this.textBoxFrom);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contentPanel.Location = new System.Drawing.Point(0, 36);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(754, 552);
            this.contentPanel.TabIndex = 1;
            // 
            // labelLastBackup
            // 
            this.labelLastBackup.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastBackup.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelLastBackup.Location = new System.Drawing.Point(628, 3);
            this.labelLastBackup.Name = "labelLastBackup";
            this.labelLastBackup.Size = new System.Drawing.Size(103, 15);
            this.labelLastBackup.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(558, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Last backup:";
            // 
            // richTextBoxLogs
            // 
            this.richTextBoxLogs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLogs.Location = new System.Drawing.Point(31, 291);
            this.richTextBoxLogs.Name = "richTextBoxLogs";
            this.richTextBoxLogs.ReadOnly = true;
            this.richTextBoxLogs.Size = new System.Drawing.Size(617, 188);
            this.richTextBoxLogs.TabIndex = 9;
            this.richTextBoxLogs.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "To";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "From";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxBackupTitle
            // 
            this.textBoxBackupTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBackupTitle.Location = new System.Drawing.Point(31, 37);
            this.textBoxBackupTitle.Name = "textBoxBackupTitle";
            this.textBoxBackupTitle.Size = new System.Drawing.Size(122, 23);
            this.textBoxBackupTitle.TabIndex = 2;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(32, 130);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(585, 23);
            this.textBoxTo.TabIndex = 1;
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(32, 81);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(585, 23);
            this.textBoxFrom.TabIndex = 0;
            // 
            // progressBarMain
            // 
            this.progressBarMain.Location = new System.Drawing.Point(32, 505);
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(617, 27);
            this.progressBarMain.Step = 1;
            this.progressBarMain.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Status";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Log";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imageListMain
            // 
            this.imageListMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMain.ImageStream")));
            this.imageListMain.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMain.Images.SetKeyName(0, "floppy-disk.png");
            // 
            // buttonBackup
            // 
            this.buttonBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonBackup.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBackup.ImageKey = "floppy-disk.png";
            this.buttonBackup.ImageList = this.imageListMain;
            this.buttonBackup.Location = new System.Drawing.Point(669, 505);
            this.buttonBackup.Name = "buttonBackup";
            this.buttonBackup.Size = new System.Drawing.Size(62, 27);
            this.buttonBackup.TabIndex = 8;
            this.buttonBackup.Text = "Save";
            this.buttonBackup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonBackup.UseVisualStyleBackColor = true;
            this.buttonBackup.Click += new System.EventHandler(this.buttonBackup_Click);
            // 
            // buttonTo
            // 
            this.buttonTo.BackColor = System.Drawing.Color.Transparent;
            this.buttonTo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonTo.BackgroundImage")));
            this.buttonTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonTo.FlatAppearance.BorderSize = 0;
            this.buttonTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTo.Location = new System.Drawing.Point(623, 133);
            this.buttonTo.Name = "buttonTo";
            this.buttonTo.Size = new System.Drawing.Size(25, 20);
            this.buttonTo.TabIndex = 7;
            this.buttonTo.UseVisualStyleBackColor = false;
            this.buttonTo.Click += new System.EventHandler(this.buttonTo_Click);
            // 
            // buttonFrom
            // 
            this.buttonFrom.BackColor = System.Drawing.Color.Transparent;
            this.buttonFrom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFrom.BackgroundImage")));
            this.buttonFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFrom.FlatAppearance.BorderSize = 0;
            this.buttonFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFrom.Location = new System.Drawing.Point(623, 84);
            this.buttonFrom.Name = "buttonFrom";
            this.buttonFrom.Size = new System.Drawing.Size(25, 20);
            this.buttonFrom.TabIndex = 6;
            this.buttonFrom.UseVisualStyleBackColor = false;
            this.buttonFrom.Click += new System.EventHandler(this.buttonFrom_Click);
            // 
            // BackuperView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.titlePanel);
            this.Name = "BackuperView";
            this.Size = new System.Drawing.Size(754, 588);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel titlePanel;
        private Panel contentPanel;
        private Label titleLabel;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxBackupTitle;
        private TextBox textBoxTo;
        private TextBox textBoxFrom;
        private Button buttonTo;
        private Button buttonFrom;
        private FolderBrowserDialog folderBrowserDialogFrom;
        private FolderBrowserDialog folderBrowserDialogTo;
        private Button buttonBackup;
        private RichTextBox richTextBoxLogs;
        private Label labelLastBackup;
        private Label label4;
        private ProgressBar progressBarMain;
        private Label label5;
        private Label label6;
        private ImageList imageListMain;
    }
}
