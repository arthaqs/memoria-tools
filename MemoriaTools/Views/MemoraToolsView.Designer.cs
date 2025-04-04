namespace MemoriaTools;

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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoraToolsView));
        fullPanel = new Panel();
        contentPanel = new Panel();
        sidePanel = new Panel();
        sideFlowLayoutPanel = new FlowLayoutPanel();
        obsidianToGitButton = new Button();
        bottomToolStrip = new ToolStrip();
        mainMenuStrip = new MenuStrip();
        fileToolStripMenuItem = new ToolStripMenuItem();
        newToolStripMenuItem = new ToolStripMenuItem();
        openToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator = new ToolStripSeparator();
        saveToolStripMenuItem = new ToolStripMenuItem();
        saveAsToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator1 = new ToolStripSeparator();
        printToolStripMenuItem = new ToolStripMenuItem();
        printPreviewToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator2 = new ToolStripSeparator();
        exitToolStripMenuItem = new ToolStripMenuItem();
        editToolStripMenuItem = new ToolStripMenuItem();
        undoToolStripMenuItem = new ToolStripMenuItem();
        redoToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator3 = new ToolStripSeparator();
        cutToolStripMenuItem = new ToolStripMenuItem();
        copyToolStripMenuItem = new ToolStripMenuItem();
        pasteToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator4 = new ToolStripSeparator();
        selectAllToolStripMenuItem = new ToolStripMenuItem();
        toolsToolStripMenuItem = new ToolStripMenuItem();
        customizeToolStripMenuItem = new ToolStripMenuItem();
        optionsToolStripMenuItem = new ToolStripMenuItem();
        helpToolStripMenuItem = new ToolStripMenuItem();
        contentsToolStripMenuItem = new ToolStripMenuItem();
        indexToolStripMenuItem = new ToolStripMenuItem();
        searchToolStripMenuItem = new ToolStripMenuItem();
        toolStripSeparator5 = new ToolStripSeparator();
        aboutToolStripMenuItem = new ToolStripMenuItem();
        logBottomToolStripLabel = new ToolStripLabel();
        fullPanel.SuspendLayout();
        sidePanel.SuspendLayout();
        sideFlowLayoutPanel.SuspendLayout();
        bottomToolStrip.SuspendLayout();
        mainMenuStrip.SuspendLayout();
        SuspendLayout();
        // 
        // fullPanel
        // 
        fullPanel.Controls.Add(contentPanel);
        fullPanel.Controls.Add(sidePanel);
        fullPanel.Controls.Add(bottomToolStrip);
        fullPanel.Dock = DockStyle.Fill;
        fullPanel.Location = new Point(0, 24);
        fullPanel.Name = "fullPanel";
        fullPanel.Size = new Size(1018, 703);
        fullPanel.TabIndex = 1;
        // 
        // contentPanel
        // 
        contentPanel.Dock = DockStyle.Fill;
        contentPanel.Location = new Point(138, 0);
        contentPanel.Name = "contentPanel";
        contentPanel.Size = new Size(880, 678);
        contentPanel.TabIndex = 2;
        // 
        // sidePanel
        // 
        sidePanel.Controls.Add(sideFlowLayoutPanel);
        sidePanel.Dock = DockStyle.Left;
        sidePanel.Location = new Point(0, 0);
        sidePanel.Name = "sidePanel";
        sidePanel.Size = new Size(138, 678);
        sidePanel.TabIndex = 1;
        // 
        // sideFlowLayoutPanel
        // 
        sideFlowLayoutPanel.Controls.Add(obsidianToGitButton);
        sideFlowLayoutPanel.Dock = DockStyle.Fill;
        sideFlowLayoutPanel.Location = new Point(0, 0);
        sideFlowLayoutPanel.Name = "sideFlowLayoutPanel";
        sideFlowLayoutPanel.Size = new Size(138, 678);
        sideFlowLayoutPanel.TabIndex = 1;
        // 
        // obsidianToGitButton
        // 
        obsidianToGitButton.AutoSize = true;
        obsidianToGitButton.Location = new Point(3, 3);
        obsidianToGitButton.Name = "obsidianToGitButton";
        obsidianToGitButton.Size = new Size(132, 41);
        obsidianToGitButton.TabIndex = 0;
        obsidianToGitButton.Text = "Obsidian to Git";
        obsidianToGitButton.UseVisualStyleBackColor = true;
        obsidianToGitButton.Click += obsidianToGitButton_Click;
        // 
        // bottomToolStrip
        // 
        bottomToolStrip.Dock = DockStyle.Bottom;
        bottomToolStrip.Items.AddRange(new ToolStripItem[] { logBottomToolStripLabel });
        bottomToolStrip.Location = new Point(0, 678);
        bottomToolStrip.Name = "bottomToolStrip";
        bottomToolStrip.Size = new Size(1018, 25);
        bottomToolStrip.TabIndex = 0;
        bottomToolStrip.Text = "bottomToolStrip";
        // 
        // mainMenuStrip
        // 
        mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
        mainMenuStrip.Location = new Point(0, 0);
        mainMenuStrip.Name = "mainMenuStrip";
        mainMenuStrip.Size = new Size(1018, 24);
        mainMenuStrip.TabIndex = 2;
        mainMenuStrip.Text = "mainMenuStrip";
        // 
        // fileToolStripMenuItem
        // 
        fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openToolStripMenuItem, toolStripSeparator, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, printPreviewToolStripMenuItem, toolStripSeparator2, exitToolStripMenuItem });
        fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        fileToolStripMenuItem.Size = new Size(37, 20);
        fileToolStripMenuItem.Text = "&File";
        // 
        // newToolStripMenuItem
        // 
        newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
        newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        newToolStripMenuItem.Name = "newToolStripMenuItem";
        newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
        newToolStripMenuItem.Size = new Size(146, 22);
        newToolStripMenuItem.Text = "&New";
        // 
        // openToolStripMenuItem
        // 
        openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
        openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        openToolStripMenuItem.Name = "openToolStripMenuItem";
        openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
        openToolStripMenuItem.Size = new Size(146, 22);
        openToolStripMenuItem.Text = "&Open";
        // 
        // toolStripSeparator
        // 
        toolStripSeparator.Name = "toolStripSeparator";
        toolStripSeparator.Size = new Size(143, 6);
        // 
        // saveToolStripMenuItem
        // 
        saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
        saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        saveToolStripMenuItem.Name = "saveToolStripMenuItem";
        saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
        saveToolStripMenuItem.Size = new Size(146, 22);
        saveToolStripMenuItem.Text = "&Save";
        // 
        // saveAsToolStripMenuItem
        // 
        saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        saveAsToolStripMenuItem.Size = new Size(146, 22);
        saveAsToolStripMenuItem.Text = "Save &As";
        // 
        // toolStripSeparator1
        // 
        toolStripSeparator1.Name = "toolStripSeparator1";
        toolStripSeparator1.Size = new Size(143, 6);
        // 
        // printToolStripMenuItem
        // 
        printToolStripMenuItem.Image = (Image)resources.GetObject("printToolStripMenuItem.Image");
        printToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        printToolStripMenuItem.Name = "printToolStripMenuItem";
        printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
        printToolStripMenuItem.Size = new Size(146, 22);
        printToolStripMenuItem.Text = "&Print";
        // 
        // printPreviewToolStripMenuItem
        // 
        printPreviewToolStripMenuItem.Image = (Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
        printPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
        printPreviewToolStripMenuItem.Size = new Size(146, 22);
        printPreviewToolStripMenuItem.Text = "Print Pre&view";
        // 
        // toolStripSeparator2
        // 
        toolStripSeparator2.Name = "toolStripSeparator2";
        toolStripSeparator2.Size = new Size(143, 6);
        // 
        // exitToolStripMenuItem
        // 
        exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        exitToolStripMenuItem.Size = new Size(146, 22);
        exitToolStripMenuItem.Text = "E&xit";
        // 
        // editToolStripMenuItem
        // 
        editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, selectAllToolStripMenuItem });
        editToolStripMenuItem.Name = "editToolStripMenuItem";
        editToolStripMenuItem.Size = new Size(39, 20);
        editToolStripMenuItem.Text = "&Edit";
        // 
        // undoToolStripMenuItem
        // 
        undoToolStripMenuItem.Name = "undoToolStripMenuItem";
        undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
        undoToolStripMenuItem.Size = new Size(144, 22);
        undoToolStripMenuItem.Text = "&Undo";
        // 
        // redoToolStripMenuItem
        // 
        redoToolStripMenuItem.Name = "redoToolStripMenuItem";
        redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
        redoToolStripMenuItem.Size = new Size(144, 22);
        redoToolStripMenuItem.Text = "&Redo";
        // 
        // toolStripSeparator3
        // 
        toolStripSeparator3.Name = "toolStripSeparator3";
        toolStripSeparator3.Size = new Size(141, 6);
        // 
        // cutToolStripMenuItem
        // 
        cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
        cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        cutToolStripMenuItem.Name = "cutToolStripMenuItem";
        cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
        cutToolStripMenuItem.Size = new Size(144, 22);
        cutToolStripMenuItem.Text = "Cu&t";
        // 
        // copyToolStripMenuItem
        // 
        copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
        copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        copyToolStripMenuItem.Name = "copyToolStripMenuItem";
        copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
        copyToolStripMenuItem.Size = new Size(144, 22);
        copyToolStripMenuItem.Text = "&Copy";
        // 
        // pasteToolStripMenuItem
        // 
        pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
        pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
        pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
        pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
        pasteToolStripMenuItem.Size = new Size(144, 22);
        pasteToolStripMenuItem.Text = "&Paste";
        // 
        // toolStripSeparator4
        // 
        toolStripSeparator4.Name = "toolStripSeparator4";
        toolStripSeparator4.Size = new Size(141, 6);
        // 
        // selectAllToolStripMenuItem
        // 
        selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
        selectAllToolStripMenuItem.Size = new Size(144, 22);
        selectAllToolStripMenuItem.Text = "Select &All";
        // 
        // toolsToolStripMenuItem
        // 
        toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, optionsToolStripMenuItem });
        toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
        toolsToolStripMenuItem.Size = new Size(46, 20);
        toolsToolStripMenuItem.Text = "&Tools";
        // 
        // customizeToolStripMenuItem
        // 
        customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
        customizeToolStripMenuItem.Size = new Size(130, 22);
        customizeToolStripMenuItem.Text = "&Customize";
        // 
        // optionsToolStripMenuItem
        // 
        optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
        optionsToolStripMenuItem.Size = new Size(130, 22);
        optionsToolStripMenuItem.Text = "&Options";
        // 
        // helpToolStripMenuItem
        // 
        helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contentsToolStripMenuItem, indexToolStripMenuItem, searchToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem });
        helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        helpToolStripMenuItem.Size = new Size(44, 20);
        helpToolStripMenuItem.Text = "&Help";
        // 
        // contentsToolStripMenuItem
        // 
        contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
        contentsToolStripMenuItem.Size = new Size(122, 22);
        contentsToolStripMenuItem.Text = "&Contents";
        // 
        // indexToolStripMenuItem
        // 
        indexToolStripMenuItem.Name = "indexToolStripMenuItem";
        indexToolStripMenuItem.Size = new Size(122, 22);
        indexToolStripMenuItem.Text = "&Index";
        // 
        // searchToolStripMenuItem
        // 
        searchToolStripMenuItem.Name = "searchToolStripMenuItem";
        searchToolStripMenuItem.Size = new Size(122, 22);
        searchToolStripMenuItem.Text = "&Search";
        // 
        // toolStripSeparator5
        // 
        toolStripSeparator5.Name = "toolStripSeparator5";
        toolStripSeparator5.Size = new Size(119, 6);
        // 
        // aboutToolStripMenuItem
        // 
        aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        aboutToolStripMenuItem.Size = new Size(122, 22);
        aboutToolStripMenuItem.Text = "&About...";
        // 
        // logBottomToolStripLabel
        // 
        logBottomToolStripLabel.Name = "logBottomToolStripLabel";
        logBottomToolStripLabel.Size = new Size(0, 22);
        // 
        // MemoraToolsView
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1018, 727);
        Controls.Add(fullPanel);
        Controls.Add(mainMenuStrip);
        MainMenuStrip = mainMenuStrip;
        Name = "MemoraToolsView";
        Text = "Memoria Tools";
        Load += MemoraToolsView_Load;
        fullPanel.ResumeLayout(false);
        fullPanel.PerformLayout();
        sidePanel.ResumeLayout(false);
        sideFlowLayoutPanel.ResumeLayout(false);
        sideFlowLayoutPanel.PerformLayout();
        bottomToolStrip.ResumeLayout(false);
        bottomToolStrip.PerformLayout();
        mainMenuStrip.ResumeLayout(false);
        mainMenuStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Panel contentPanel;

    private System.Windows.Forms.ToolStrip bottomToolStrip;

    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

    private System.Windows.Forms.Panel fullPanel;
    private System.Windows.Forms.MenuStrip mainMenuStrip;

    #endregion

    private Panel sidePanel;
    private FlowLayoutPanel sideFlowLayoutPanel;
    private Button obsidianToGitButton;
    private ToolStripLabel logBottomToolStripLabel;
}