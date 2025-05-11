using System.Drawing;
using System.Windows.Forms;

namespace MemoriaTools
{


    partial class MemoraToolsView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fullPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.sideFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.bottomToolStrip = new System.Windows.Forms.ToolStrip();
            this.logBottomToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.bottomToolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullPanel
            // 
            this.fullPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fullPanel.Controls.Add(this.contentPanel);
            this.fullPanel.Controls.Add(this.sidePanel);
            this.fullPanel.Controls.Add(this.bottomToolStrip);
            this.fullPanel.Location = new System.Drawing.Point(0, 28);
            this.fullPanel.Name = "fullPanel";
            this.fullPanel.Size = new System.Drawing.Size(873, 602);
            this.fullPanel.TabIndex = 1;
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(118, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(755, 577);
            this.contentPanel.TabIndex = 2;
            // 
            // sidePanel
            // 
            this.sidePanel.Controls.Add(this.sideFlowLayoutPanel);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(118, 577);
            this.sidePanel.TabIndex = 1;
            // 
            // sideFlowLayoutPanel
            // 
            this.sideFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideFlowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.sideFlowLayoutPanel.Name = "sideFlowLayoutPanel";
            this.sideFlowLayoutPanel.Size = new System.Drawing.Size(118, 577);
            this.sideFlowLayoutPanel.TabIndex = 1;
            // 
            // bottomToolStrip
            // 
            this.bottomToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logBottomToolStripLabel});
            this.bottomToolStrip.Location = new System.Drawing.Point(0, 577);
            this.bottomToolStrip.Name = "bottomToolStrip";
            this.bottomToolStrip.Size = new System.Drawing.Size(873, 25);
            this.bottomToolStrip.TabIndex = 0;
            this.bottomToolStrip.Text = "bottomToolStrip";
            // 
            // logBottomToolStripLabel
            // 
            this.logBottomToolStripLabel.Name = "logBottomToolStripLabel";
            this.logBottomToolStripLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.loadPluginToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // loadPluginToolStripMenuItem
            // 
            this.loadPluginToolStripMenuItem.Name = "loadPluginToolStripMenuItem";
            this.loadPluginToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.loadPluginToolStripMenuItem.Text = "Load Plugin";
            this.loadPluginToolStripMenuItem.Click += new System.EventHandler(this.loadPluginToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MemoraToolsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 630);
            this.Controls.Add(this.fullPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MemoraToolsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memoria Tools";
            this.Load += new System.EventHandler(this.MemoraToolsView_Load);
            this.fullPanel.ResumeLayout(false);
            this.fullPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.bottomToolStrip.ResumeLayout(false);
            this.bottomToolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel contentPanel;

        private System.Windows.Forms.ToolStrip bottomToolStrip;

        private System.Windows.Forms.Panel fullPanel;

        #endregion

        private Panel sidePanel;
        private FlowLayoutPanel sideFlowLayoutPanel;
        private ToolStripLabel logBottomToolStripLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadPluginToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}