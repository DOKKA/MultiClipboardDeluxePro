﻿namespace MultiClipboardDeluxePro
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.SplitPanel = new System.Windows.Forms.SplitContainer();
            this.ClipList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Timestamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PanelSearch = new System.Windows.Forms.Panel();
            this.BtnNextSearch = new System.Windows.Forms.Button();
            this.BtnPrevSearch = new System.Windows.Forms.Button();
            this.BtnCloseSearch = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.ClipTitle = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.indentSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outdentSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.uppercaseSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowercaseSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.goToLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indentGuidesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiddenCharactersItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.zoomInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoom100ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toggleCollapseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClipType = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPanel)).BeginInit();
            this.SplitPanel.Panel1.SuspendLayout();
            this.SplitPanel.Panel2.SuspendLayout();
            this.SplitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClipList)).BeginInit();
            this.PanelSearch.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SplitPanel
            // 
            this.SplitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitPanel.Location = new System.Drawing.Point(0, 0);
            this.SplitPanel.Name = "SplitPanel";
            // 
            // SplitPanel.Panel1
            // 
            this.SplitPanel.Panel1.Controls.Add(this.ClipList);
            this.SplitPanel.Panel1.Controls.Add(this.textBox1);
            // 
            // SplitPanel.Panel2
            // 
            this.SplitPanel.Panel2.Controls.Add(this.PanelSearch);
            this.SplitPanel.Panel2.Controls.Add(this.ClipTitle);
            this.SplitPanel.Size = new System.Drawing.Size(784, 761);
            this.SplitPanel.SplitterDistance = 261;
            this.SplitPanel.SplitterWidth = 10;
            this.SplitPanel.TabIndex = 1;
            // 
            // ClipList
            // 
            this.ClipList.AllowUserToAddRows = false;
            this.ClipList.AllowUserToResizeRows = false;
            this.ClipList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClipList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClipList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.Timestamp,
            this.Type});
            this.ClipList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClipList.Location = new System.Drawing.Point(0, 20);
            this.ClipList.MultiSelect = false;
            this.ClipList.Name = "ClipList";
            this.ClipList.ReadOnly = true;
            this.ClipList.RowHeadersVisible = false;
            this.ClipList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClipList.Size = new System.Drawing.Size(261, 741);
            this.ClipList.TabIndex = 1;
            this.ClipList.SelectionChanged += new System.EventHandler(this.ClipList_SelectionChanged);
            this.ClipList.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.ClipList_UserDeletingRow);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Timestamp
            // 
            this.Timestamp.HeaderText = "Timestamp";
            this.Timestamp.Name = "Timestamp";
            this.Timestamp.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 20);
            this.textBox1.TabIndex = 0;
            // 
            // PanelSearch
            // 
            this.PanelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSearch.BackColor = System.Drawing.Color.White;
            this.PanelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelSearch.Controls.Add(this.BtnNextSearch);
            this.PanelSearch.Controls.Add(this.BtnPrevSearch);
            this.PanelSearch.Controls.Add(this.BtnCloseSearch);
            this.PanelSearch.Controls.Add(this.TxtSearch);
            this.PanelSearch.Location = new System.Drawing.Point(200, 68);
            this.PanelSearch.Name = "PanelSearch";
            this.PanelSearch.Size = new System.Drawing.Size(292, 40);
            this.PanelSearch.TabIndex = 11;
            this.PanelSearch.Visible = false;
            // 
            // BtnNextSearch
            // 
            this.BtnNextSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNextSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextSearch.ForeColor = System.Drawing.Color.White;
            this.BtnNextSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnNextSearch.Image")));
            this.BtnNextSearch.Location = new System.Drawing.Point(233, 4);
            this.BtnNextSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnNextSearch.Name = "BtnNextSearch";
            this.BtnNextSearch.Size = new System.Drawing.Size(25, 30);
            this.BtnNextSearch.TabIndex = 9;
            this.BtnNextSearch.Tag = "Find next (Enter)";
            this.BtnNextSearch.UseVisualStyleBackColor = true;
            this.BtnNextSearch.Click += new System.EventHandler(this.BtnNextSearch_Click);
            // 
            // BtnPrevSearch
            // 
            this.BtnPrevSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPrevSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrevSearch.ForeColor = System.Drawing.Color.White;
            this.BtnPrevSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrevSearch.Image")));
            this.BtnPrevSearch.Location = new System.Drawing.Point(205, 4);
            this.BtnPrevSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnPrevSearch.Name = "BtnPrevSearch";
            this.BtnPrevSearch.Size = new System.Drawing.Size(25, 30);
            this.BtnPrevSearch.TabIndex = 8;
            this.BtnPrevSearch.Tag = "Find previous (Shift+Enter)";
            this.BtnPrevSearch.UseVisualStyleBackColor = true;
            this.BtnPrevSearch.Click += new System.EventHandler(this.BtnPrevSearch_Click);
            // 
            // BtnCloseSearch
            // 
            this.BtnCloseSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCloseSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCloseSearch.ForeColor = System.Drawing.Color.White;
            this.BtnCloseSearch.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseSearch.Image")));
            this.BtnCloseSearch.Location = new System.Drawing.Point(261, 4);
            this.BtnCloseSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCloseSearch.Name = "BtnCloseSearch";
            this.BtnCloseSearch.Size = new System.Drawing.Size(25, 30);
            this.BtnCloseSearch.TabIndex = 7;
            this.BtnCloseSearch.Tag = "Close (Esc)";
            this.BtnCloseSearch.UseVisualStyleBackColor = true;
            this.BtnCloseSearch.Click += new System.EventHandler(this.BtnClearSearch_Click);
            // 
            // TxtSearch
            // 
            this.TxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSearch.Location = new System.Drawing.Point(10, 6);
            this.TxtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(189, 25);
            this.TxtSearch.TabIndex = 6;
            this.TxtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyDown);
            // 
            // ClipTitle
            // 
            this.ClipTitle.Location = new System.Drawing.Point(3, 3);
            this.ClipTitle.Name = "ClipTitle";
            this.ClipTitle.Size = new System.Drawing.Size(507, 20);
            this.ClipTitle.TabIndex = 0;
            this.ClipTitle.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ClipTitle_KeyUp);
            this.ClipTitle.Leave += new System.EventHandler(this.ClipTitle_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toggleCollapseToolStripMenuItem,
            this.ClipType});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 27);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(41, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Visible = false;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator1,
            this.selectLineToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.clearSelectionToolStripMenuItem,
            this.toolStripSeparator2,
            this.indentSelectionToolStripMenuItem,
            this.outdentSelectionToolStripMenuItem,
            this.toolStripSeparator3,
            this.uppercaseSelectionToolStripMenuItem,
            this.lowercaseSelectionToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(44, 23);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // selectLineToolStripMenuItem
            // 
            this.selectLineToolStripMenuItem.Name = "selectLineToolStripMenuItem";
            this.selectLineToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.selectLineToolStripMenuItem.Text = "Select Line";
            this.selectLineToolStripMenuItem.Click += new System.EventHandler(this.selectLineToolStripMenuItem_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+A";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // clearSelectionToolStripMenuItem
            // 
            this.clearSelectionToolStripMenuItem.Name = "clearSelectionToolStripMenuItem";
            this.clearSelectionToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.clearSelectionToolStripMenuItem.Text = "Clear Selection";
            this.clearSelectionToolStripMenuItem.Click += new System.EventHandler(this.clearSelectionToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // indentSelectionToolStripMenuItem
            // 
            this.indentSelectionToolStripMenuItem.Name = "indentSelectionToolStripMenuItem";
            this.indentSelectionToolStripMenuItem.ShortcutKeyDisplayString = "Tab";
            this.indentSelectionToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.indentSelectionToolStripMenuItem.Text = "Indent";
            this.indentSelectionToolStripMenuItem.Click += new System.EventHandler(this.indentSelectionToolStripMenuItem_Click);
            // 
            // outdentSelectionToolStripMenuItem
            // 
            this.outdentSelectionToolStripMenuItem.Name = "outdentSelectionToolStripMenuItem";
            this.outdentSelectionToolStripMenuItem.ShortcutKeyDisplayString = "Shift+Tab";
            this.outdentSelectionToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.outdentSelectionToolStripMenuItem.Text = "Outdent";
            this.outdentSelectionToolStripMenuItem.Click += new System.EventHandler(this.outdentSelectionToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(193, 6);
            // 
            // uppercaseSelectionToolStripMenuItem
            // 
            this.uppercaseSelectionToolStripMenuItem.Name = "uppercaseSelectionToolStripMenuItem";
            this.uppercaseSelectionToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+U";
            this.uppercaseSelectionToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.uppercaseSelectionToolStripMenuItem.Text = "Uppercase";
            this.uppercaseSelectionToolStripMenuItem.Click += new System.EventHandler(this.uppercaseSelectionToolStripMenuItem_Click);
            // 
            // lowercaseSelectionToolStripMenuItem
            // 
            this.lowercaseSelectionToolStripMenuItem.Name = "lowercaseSelectionToolStripMenuItem";
            this.lowercaseSelectionToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+L";
            this.lowercaseSelectionToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.lowercaseSelectionToolStripMenuItem.Text = "Lowercase";
            this.lowercaseSelectionToolStripMenuItem.Click += new System.EventHandler(this.lowercaseSelectionToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.findDialogToolStripMenuItem,
            this.findAndReplaceToolStripMenuItem,
            this.toolStripSeparator7,
            this.goToLineToolStripMenuItem});
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(61, 23);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.findToolStripMenuItem.Text = "Quick Find...";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // findDialogToolStripMenuItem
            // 
            this.findDialogToolStripMenuItem.Name = "findDialogToolStripMenuItem";
            this.findDialogToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Alt+F";
            this.findDialogToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.findDialogToolStripMenuItem.Text = "Find...";
            this.findDialogToolStripMenuItem.Click += new System.EventHandler(this.findDialogToolStripMenuItem_Click);
            // 
            // findAndReplaceToolStripMenuItem
            // 
            this.findAndReplaceToolStripMenuItem.Name = "findAndReplaceToolStripMenuItem";
            this.findAndReplaceToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+H";
            this.findAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.findAndReplaceToolStripMenuItem.Text = "Find and Replace...";
            this.findAndReplaceToolStripMenuItem.Click += new System.EventHandler(this.findAndReplaceToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(238, 6);
            // 
            // goToLineToolStripMenuItem
            // 
            this.goToLineToolStripMenuItem.Name = "goToLineToolStripMenuItem";
            this.goToLineToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+G";
            this.goToLineToolStripMenuItem.Size = new System.Drawing.Size(241, 24);
            this.goToLineToolStripMenuItem.Text = "Go To Line...";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wordWrapItem,
            this.indentGuidesItem,
            this.hiddenCharactersItem,
            this.toolStripSeparator4,
            this.zoomInToolStripMenuItem,
            this.zoomOutToolStripMenuItem,
            this.zoom100ToolStripMenuItem,
            this.toolStripSeparator5,
            this.collapseAllToolStripMenuItem,
            this.expandAllToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // wordWrapItem
            // 
            this.wordWrapItem.Name = "wordWrapItem";
            this.wordWrapItem.Size = new System.Drawing.Size(221, 24);
            this.wordWrapItem.Text = "Word Wrap";
            this.wordWrapItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem1_Click);
            // 
            // indentGuidesItem
            // 
            this.indentGuidesItem.Checked = true;
            this.indentGuidesItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.indentGuidesItem.Name = "indentGuidesItem";
            this.indentGuidesItem.Size = new System.Drawing.Size(221, 24);
            this.indentGuidesItem.Text = "Show Indent Guides";
            this.indentGuidesItem.Click += new System.EventHandler(this.indentGuidesToolStripMenuItem_Click);
            // 
            // hiddenCharactersItem
            // 
            this.hiddenCharactersItem.Name = "hiddenCharactersItem";
            this.hiddenCharactersItem.Size = new System.Drawing.Size(221, 24);
            this.hiddenCharactersItem.Text = "Show Whitespace";
            this.hiddenCharactersItem.Click += new System.EventHandler(this.hiddenCharactersToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(218, 6);
            // 
            // zoomInToolStripMenuItem
            // 
            this.zoomInToolStripMenuItem.Name = "zoomInToolStripMenuItem";
            this.zoomInToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Plus";
            this.zoomInToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.zoomInToolStripMenuItem.Text = "Zoom In";
            this.zoomInToolStripMenuItem.Click += new System.EventHandler(this.zoomInToolStripMenuItem_Click);
            // 
            // zoomOutToolStripMenuItem
            // 
            this.zoomOutToolStripMenuItem.Name = "zoomOutToolStripMenuItem";
            this.zoomOutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Minus";
            this.zoomOutToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.zoomOutToolStripMenuItem.Text = "Zoom Out";
            this.zoomOutToolStripMenuItem.Click += new System.EventHandler(this.zoomOutToolStripMenuItem_Click);
            // 
            // zoom100ToolStripMenuItem
            // 
            this.zoom100ToolStripMenuItem.Name = "zoom100ToolStripMenuItem";
            this.zoom100ToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+0";
            this.zoom100ToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.zoom100ToolStripMenuItem.Text = "Zoom 100%";
            this.zoom100ToolStripMenuItem.Click += new System.EventHandler(this.zoom100ToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(218, 6);
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.collapseAllToolStripMenuItem.Text = "Collapse All";
            this.collapseAllToolStripMenuItem.Click += new System.EventHandler(this.collapseAllToolStripMenuItem_Click);
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(221, 24);
            this.expandAllToolStripMenuItem.Text = "Expand All";
            this.expandAllToolStripMenuItem.Click += new System.EventHandler(this.expandAllToolStripMenuItem_Click);
            // 
            // toggleCollapseToolStripMenuItem
            // 
            this.toggleCollapseToolStripMenuItem.Name = "toggleCollapseToolStripMenuItem";
            this.toggleCollapseToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.toggleCollapseToolStripMenuItem.Text = "[<-]";
            this.toggleCollapseToolStripMenuItem.Click += new System.EventHandler(this.toggleCollapseToolStripMenuItem_Click);
            // 
            // ClipType
            // 
            this.ClipType.Items.AddRange(new object[] {
            "C#",
            "Javascript",
            "JSON",
            "HTML",
            "XML",
            "Plaintext"});
            this.ClipType.Name = "ClipType";
            this.ClipType.Size = new System.Drawing.Size(121, 23);
            this.ClipType.SelectedIndexChanged += new System.EventHandler(this.ClipType_SelectedIndexChanged);
            this.ClipType.Leave += new System.EventHandler(this.ClipType_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 761);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.SplitPanel);
            this.Name = "MainForm";
            this.Text = "Multi Clipboard Deluxe Pro";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SplitPanel.Panel1.ResumeLayout(false);
            this.SplitPanel.Panel1.PerformLayout();
            this.SplitPanel.Panel2.ResumeLayout(false);
            this.SplitPanel.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitPanel)).EndInit();
            this.SplitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClipList)).EndInit();
            this.PanelSearch.ResumeLayout(false);
            this.PanelSearch.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.SplitContainer SplitPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox ClipTitle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem selectLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem indentSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem outdentSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem uppercaseSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowercaseSelectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findAndReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem goToLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapItem;
        private System.Windows.Forms.ToolStripMenuItem indentGuidesItem;
        private System.Windows.Forms.ToolStripMenuItem hiddenCharactersItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem zoomInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoom100ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.Panel PanelSearch;
        private System.Windows.Forms.Button BtnNextSearch;
        private System.Windows.Forms.Button BtnPrevSearch;
        private System.Windows.Forms.Button BtnCloseSearch;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toggleCollapseToolStripMenuItem;
        private System.Windows.Forms.DataGridView ClipList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Timestamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.ToolStripComboBox ClipType;
    }
}

