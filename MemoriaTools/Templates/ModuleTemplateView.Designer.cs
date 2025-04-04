namespace MemoriaTools
{
    partial class ModuleTemplateView
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
            titlePanel.SuspendLayout();
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
            titleLabel.Size = new Size(111, 25);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Rename Me";
            // 
            // contentPanel
            // 
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(0, 41);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(880, 637);
            contentPanel.TabIndex = 1;
            // 
            // ModuleTemplateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(contentPanel);
            Controls.Add(titlePanel);
            Name = "ModuleTemplateView";
            Size = new Size(880, 678);
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel titlePanel;
        private Panel contentPanel;
        private Label titleLabel;
    }
}
