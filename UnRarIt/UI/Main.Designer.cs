﻿namespace UnRarIt
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Rar-Archives", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Zip-Archives", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Files = new System.Windows.Forms.ListView();
            this.columnFile = new System.Windows.Forms.ColumnHeader();
            this.columnSize = new System.Windows.Forms.ColumnHeader();
            this.columnStatus = new System.Windows.Forms.ColumnHeader();
            this.Icons = new System.Windows.Forms.ImageList(this.components);
            this.StateIcons = new System.Windows.Forms.ImageList(this.components);
            this.UnrarIt = new System.Windows.Forms.Button();
            this.Statusbar = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.Progress = new System.Windows.Forms.ToolStripProgressBar();
            this.Details = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusPasswords = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImportPasswords = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportPasswords = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.ClearAllPasswords = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPassword = new System.Windows.Forms.Button();
            this.BrowseDestDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.ExportDialog = new System.Windows.Forms.SaveFileDialog();
            this.GroupDest = new System.Windows.Forms.GroupBox();
            this.Dest = new System.Windows.Forms.TextBox();
            this.BrowseDest = new System.Windows.Forms.Button();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.License = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.Homepage = new System.Windows.Forms.ToolStripMenuItem();
            this.FilesCtx = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CtxClearSelected = new System.Windows.Forms.ToolStripMenuItem();
            this.CtxClearList = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.requeueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Statusbar.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.GroupDest.SuspendLayout();
            this.FilesCtx.SuspendLayout();
            this.SuspendLayout();
            // 
            // Files
            // 
            this.Files.AllowDrop = true;
            this.Files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFile,
            this.columnSize,
            this.columnStatus});
            this.Files.ContextMenuStrip = this.FilesCtx;
            listViewGroup1.Header = "Rar-Archives";
            listViewGroup1.Name = "GroupRar";
            listViewGroup2.Header = "Zip-Archives";
            listViewGroup2.Name = "GroupZip";
            this.Files.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.Files.LargeImageList = this.Icons;
            this.Files.Location = new System.Drawing.Point(12, 27);
            this.Files.Name = "Files";
            this.Files.Size = new System.Drawing.Size(758, 408);
            this.Files.SmallImageList = this.Icons;
            this.Files.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.Files.StateImageList = this.StateIcons;
            this.Files.TabIndex = 0;
            this.Files.UseCompatibleStateImageBehavior = false;
            this.Files.View = System.Windows.Forms.View.Details;
            this.Files.SelectedIndexChanged += new System.EventHandler(this.Files_SelectedIndexChanged);
            this.Files.DragDrop += new System.Windows.Forms.DragEventHandler(this.Files_DragDrop);
            this.Files.DragEnter += new System.Windows.Forms.DragEventHandler(this.Files_DragEnter);
            // 
            // columnFile
            // 
            this.columnFile.Text = "File";
            this.columnFile.Width = 200;
            // 
            // columnSize
            // 
            this.columnSize.Text = "Size";
            this.columnSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnSize.Width = 100;
            // 
            // columnStatus
            // 
            this.columnStatus.Text = "Status";
            this.columnStatus.Width = 100;
            // 
            // Icons
            // 
            this.Icons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.Icons.ImageSize = new System.Drawing.Size(16, 16);
            this.Icons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // StateIcons
            // 
            this.StateIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.StateIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.StateIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // UnrarIt
            // 
            this.UnrarIt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UnrarIt.Location = new System.Drawing.Point(12, 471);
            this.UnrarIt.Name = "UnrarIt";
            this.UnrarIt.Size = new System.Drawing.Size(75, 23);
            this.UnrarIt.TabIndex = 1;
            this.UnrarIt.Text = "Unrar!";
            this.UnrarIt.UseVisualStyleBackColor = true;
            this.UnrarIt.Click += new System.EventHandler(this.UnRarIt_Click);
            // 
            // Statusbar
            // 
            this.Statusbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.Statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status,
            this.Progress,
            this.Details,
            this.StatusPasswords});
            this.Statusbar.Location = new System.Drawing.Point(0, 497);
            this.Statusbar.Name = "Statusbar";
            this.Statusbar.Size = new System.Drawing.Size(782, 22);
            this.Statusbar.TabIndex = 2;
            this.Statusbar.Text = "statusStrip";
            // 
            // Status
            // 
            this.Status.AutoSize = false;
            this.Status.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(300, 17);
            this.Status.Text = "Status";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Progress
            // 
            this.Progress.Name = "Progress";
            this.Progress.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.Progress.Size = new System.Drawing.Size(204, 16);
            // 
            // Details
            // 
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(230, 17);
            this.Details.Spring = true;
            this.Details.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusPasswords
            // 
            this.StatusPasswords.Name = "StatusPasswords";
            this.StatusPasswords.Size = new System.Drawing.Size(0, 17);
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.passwordsToolStripMenuItem,
            this.HelpMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(782, 24);
            this.MainMenu.TabIndex = 4;
            this.MainMenu.Text = "MainMenu";
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenSettings,
            this.toolStripMenuItem2,
            this.Exit});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(37, 20);
            this.FileMenu.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 6);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(176, 22);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // passwordsToolStripMenuItem
            // 
            this.passwordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportPasswords,
            this.ExportPasswords,
            this.toolStripMenuItem1,
            this.ClearAllPasswords});
            this.passwordsToolStripMenuItem.Name = "passwordsToolStripMenuItem";
            this.passwordsToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.passwordsToolStripMenuItem.Text = "Passwords";
            // 
            // ImportPasswords
            // 
            this.ImportPasswords.Name = "ImportPasswords";
            this.ImportPasswords.Size = new System.Drawing.Size(177, 22);
            this.ImportPasswords.Text = "Import";
            this.ImportPasswords.Click += new System.EventHandler(this.AddPassword_Click);
            // 
            // ExportPasswords
            // 
            this.ExportPasswords.Name = "ExportPasswords";
            this.ExportPasswords.Size = new System.Drawing.Size(177, 22);
            this.ExportPasswords.Text = "Export";
            this.ExportPasswords.Click += new System.EventHandler(this.ExportPasswords_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 6);
            // 
            // ClearAllPasswords
            // 
            this.ClearAllPasswords.Name = "ClearAllPasswords";
            this.ClearAllPasswords.Size = new System.Drawing.Size(177, 22);
            this.ClearAllPasswords.Text = "Clear all password";
            this.ClearAllPasswords.Click += new System.EventHandler(this.ClearAllPasswords_Click);
            // 
            // HelpMenu
            // 
            this.HelpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Homepage,
            this.toolStripSeparator1,
            this.License,
            this.About});
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(25, 20);
            this.HelpMenu.Text = "?";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(137, 22);
            this.About.Text = "About";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // AddPassword
            // 
            this.AddPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddPassword.Location = new System.Drawing.Point(93, 471);
            this.AddPassword.Name = "AddPassword";
            this.AddPassword.Size = new System.Drawing.Size(86, 23);
            this.AddPassword.TabIndex = 2;
            this.AddPassword.Text = "Add Password";
            this.AddPassword.UseVisualStyleBackColor = true;
            this.AddPassword.Click += new System.EventHandler(this.AddPassword_Click);
            // 
            // ExportDialog
            // 
            this.ExportDialog.DefaultExt = "txt";
            this.ExportDialog.Filter = "Text Files|*.txt|All Files|*.*";
            // 
            // GroupDest
            // 
            this.GroupDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupDest.Controls.Add(this.Dest);
            this.GroupDest.Controls.Add(this.BrowseDest);
            this.GroupDest.Location = new System.Drawing.Point(379, 441);
            this.GroupDest.Name = "GroupDest";
            this.GroupDest.Size = new System.Drawing.Size(391, 53);
            this.GroupDest.TabIndex = 8;
            this.GroupDest.TabStop = false;
            this.GroupDest.Text = "Destination";
            // 
            // Dest
            // 
            this.Dest.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::UnRarIt.Properties.Settings.Default, "Dest", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Dest.Location = new System.Drawing.Point(11, 21);
            this.Dest.Name = "Dest";
            this.Dest.ReadOnly = true;
            this.Dest.Size = new System.Drawing.Size(344, 20);
            this.Dest.TabIndex = 5;
            this.Dest.TabStop = false;
            this.Dest.Text = global::UnRarIt.Properties.Settings.Default.Dest;
            this.Dest.TextChanged += new System.EventHandler(this.Dest_TextChanged);
            // 
            // BrowseDest
            // 
            this.BrowseDest.Location = new System.Drawing.Point(361, 20);
            this.BrowseDest.Name = "BrowseDest";
            this.BrowseDest.Size = new System.Drawing.Size(24, 20);
            this.BrowseDest.TabIndex = 3;
            this.BrowseDest.Text = "...";
            this.BrowseDest.UseVisualStyleBackColor = true;
            this.BrowseDest.Click += new System.EventHandler(this.BrowseDest_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(134, 6);
            // 
            // License
            // 
            this.License.Name = "License";
            this.License.Size = new System.Drawing.Size(137, 22);
            this.License.Text = "License";
            this.License.Click += new System.EventHandler(this.License_Click);
            // 
            // OpenSettings
            // 
            this.OpenSettings.Image = global::UnRarIt.Properties.Resources.preferences;
            this.OpenSettings.Name = "OpenSettings";
            this.OpenSettings.Size = new System.Drawing.Size(176, 22);
            this.OpenSettings.Text = "Open Preferences";
            this.OpenSettings.Click += new System.EventHandler(this.OpenSettings_Click);
            // 
            // Homepage
            // 
            this.Homepage.Image = global::UnRarIt.Properties.Resources.homepage;
            this.Homepage.Name = "Homepage";
            this.Homepage.Size = new System.Drawing.Size(137, 22);
            this.Homepage.Text = "Homepage";
            this.Homepage.Click += new System.EventHandler(this.Homepage_Click);
            // 
            // FilesCtx
            // 
            this.FilesCtx.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CtxClearSelected,
            this.CtxClearList,
            this.toolStripMenuItem3,
            this.requeueToolStripMenuItem});
            this.FilesCtx.Name = "FilesCtx";
            this.FilesCtx.Size = new System.Drawing.Size(155, 76);
            // 
            // CtxClearSelected
            // 
            this.CtxClearSelected.Name = "CtxClearSelected";
            this.CtxClearSelected.Size = new System.Drawing.Size(154, 22);
            this.CtxClearSelected.Text = "Clear selected";
            this.CtxClearSelected.Click += new System.EventHandler(this.CtxClearSelected_Click);
            // 
            // CtxClearList
            // 
            this.CtxClearList.Name = "CtxClearList";
            this.CtxClearList.Size = new System.Drawing.Size(154, 22);
            this.CtxClearList.Text = "Clear List";
            this.CtxClearList.Click += new System.EventHandler(this.CtxClearList_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(151, 6);
            // 
            // requeueToolStripMenuItem
            // 
            this.requeueToolStripMenuItem.Name = "requeueToolStripMenuItem";
            this.requeueToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.requeueToolStripMenuItem.Text = "Requeue";
            this.requeueToolStripMenuItem.Click += new System.EventHandler(this.requeueToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 519);
            this.Controls.Add(this.GroupDest);
            this.Controls.Add(this.AddPassword);
            this.Controls.Add(this.Statusbar);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.UnrarIt);
            this.Controls.Add(this.Files);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UnRarIt.Net";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Statusbar.ResumeLayout(false);
            this.Statusbar.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.GroupDest.ResumeLayout(false);
            this.GroupDest.PerformLayout();
            this.FilesCtx.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Files;
        private System.Windows.Forms.Button UnrarIt;
        private System.Windows.Forms.ColumnHeader columnFile;
        private System.Windows.Forms.ColumnHeader columnSize;
        private System.Windows.Forms.ImageList Icons;
        private System.Windows.Forms.ColumnHeader columnStatus;
        private System.Windows.Forms.StatusStrip Statusbar;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private System.Windows.Forms.ToolStripProgressBar Progress;
        private System.Windows.Forms.ToolStripStatusLabel Details;
        private System.Windows.Forms.ToolStripStatusLabel StatusPasswords;
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.Button AddPassword;
        private System.Windows.Forms.FolderBrowserDialog BrowseDestDialog;
        private System.Windows.Forms.ToolStripMenuItem Homepage;
        private System.Windows.Forms.ImageList StateIcons;
        private System.Windows.Forms.ToolStripMenuItem OpenSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem passwordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImportPasswords;
        private System.Windows.Forms.ToolStripMenuItem ExportPasswords;
        private System.Windows.Forms.SaveFileDialog ExportDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ClearAllPasswords;
        private System.Windows.Forms.GroupBox GroupDest;
        private System.Windows.Forms.TextBox Dest;
        private System.Windows.Forms.Button BrowseDest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem License;
        private System.Windows.Forms.ContextMenuStrip FilesCtx;
        private System.Windows.Forms.ToolStripMenuItem CtxClearSelected;
        private System.Windows.Forms.ToolStripMenuItem CtxClearList;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem requeueToolStripMenuItem;
    }
}
