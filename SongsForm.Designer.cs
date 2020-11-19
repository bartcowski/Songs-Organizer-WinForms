namespace WindowsFormsMusic {
    partial class SongsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongsForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.itemsCounterToolStrip = new System.Windows.Forms.ToolStrip();
            this.itemsCounterToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.songsListView = new System.Windows.Forms.ListView();
            this.titleHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.releaseDateHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genreHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editingStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addStripButton = new System.Windows.Forms.ToolStripButton();
            this.editStripButton = new System.Windows.Forms.ToolStripButton();
            this.deleteStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.filterComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.itemsCounterToolStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.itemsCounterToolStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.songsListView);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(318, 234);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(318, 259);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // itemsCounterToolStrip
            // 
            this.itemsCounterToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.itemsCounterToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.itemsCounterToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemsCounterToolStripLabel});
            this.itemsCounterToolStrip.Location = new System.Drawing.Point(3, 0);
            this.itemsCounterToolStrip.Name = "itemsCounterToolStrip";
            this.itemsCounterToolStrip.Size = new System.Drawing.Size(12, 25);
            this.itemsCounterToolStrip.TabIndex = 0;
            this.itemsCounterToolStrip.Visible = false;
            // 
            // itemsCounterToolStripLabel
            // 
            this.itemsCounterToolStripLabel.Name = "itemsCounterToolStripLabel";
            this.itemsCounterToolStripLabel.Size = new System.Drawing.Size(0, 22);
            // 
            // songsListView
            // 
            this.songsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleHeader,
            this.authorHeader,
            this.releaseDateHeader,
            this.genreHeader});
            this.songsListView.ContextMenuStrip = this.contextMenuStrip;
            this.songsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.songsListView.HideSelection = false;
            this.songsListView.Location = new System.Drawing.Point(0, 0);
            this.songsListView.Name = "songsListView";
            this.songsListView.Size = new System.Drawing.Size(318, 234);
            this.songsListView.TabIndex = 0;
            this.songsListView.UseCompatibleStateImageBehavior = false;
            this.songsListView.View = System.Windows.Forms.View.Details;
            // 
            // titleHeader
            // 
            this.titleHeader.Text = "Title";
            this.titleHeader.Width = 80;
            // 
            // authorHeader
            // 
            this.authorHeader.Text = "Author";
            this.authorHeader.Width = 80;
            // 
            // releaseDateHeader
            // 
            this.releaseDateHeader.Text = "Release Date";
            this.releaseDateHeader.Width = 80;
            // 
            // genreHeader
            // 
            this.genreHeader.Text = "Genre";
            this.genreHeader.Width = 65;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(108, 70);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addStripButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editStripButton_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteStripButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editingStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(64, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // editingStripMenuItem
            // 
            this.editingStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStripMenuItem,
            this.editStripMenuItem,
            this.deleteStripMenuItem});
            this.editingStripMenuItem.Name = "editingStripMenuItem";
            this.editingStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.editingStripMenuItem.Text = "Editing";
            // 
            // addStripMenuItem
            // 
            this.addStripMenuItem.Name = "addStripMenuItem";
            this.addStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.addStripMenuItem.Text = "Add";
            this.addStripMenuItem.Click += new System.EventHandler(this.addStripButton_Click);
            // 
            // editStripMenuItem
            // 
            this.editStripMenuItem.Name = "editStripMenuItem";
            this.editStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editStripMenuItem.Text = "Edit";
            this.editStripMenuItem.Click += new System.EventHandler(this.editStripButton_Click);
            // 
            // deleteStripMenuItem
            // 
            this.deleteStripMenuItem.Name = "deleteStripMenuItem";
            this.deleteStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteStripMenuItem.Text = "Delete";
            this.deleteStripMenuItem.Click += new System.EventHandler(this.deleteStripButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStripButton,
            this.editStripButton,
            this.deleteStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(4, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(168, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Visible = false;
            // 
            // addStripButton
            // 
            this.addStripButton.Image = ((System.Drawing.Image)(resources.GetObject("addStripButton.Image")));
            this.addStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addStripButton.Name = "addStripButton";
            this.addStripButton.Size = new System.Drawing.Size(49, 22);
            this.addStripButton.Text = "Add";
            this.addStripButton.Click += new System.EventHandler(this.addStripButton_Click);
            // 
            // editStripButton
            // 
            this.editStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editStripButton.Image")));
            this.editStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editStripButton.Name = "editStripButton";
            this.editStripButton.Size = new System.Drawing.Size(47, 22);
            this.editStripButton.Text = "Edit";
            this.editStripButton.Click += new System.EventHandler(this.editStripButton_Click);
            // 
            // deleteStripButton
            // 
            this.deleteStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteStripButton.Image")));
            this.deleteStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteStripButton.Name = "deleteStripButton";
            this.deleteStripButton.Size = new System.Drawing.Size(60, 22);
            this.deleteStripButton.Text = "Delete";
            this.deleteStripButton.Click += new System.EventHandler(this.deleteStripButton_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterComboBox});
            this.toolStrip2.Location = new System.Drawing.Point(3, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(154, 25);
            this.toolStrip2.TabIndex = 2;
            // 
            // filterComboBox
            // 
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(140, 25);
            this.filterComboBox.ToolTipText = "Filter by Release Date";
            this.filterComboBox.SelectedIndexChanged += new System.EventHandler(this.filterComboBox_SelectedIndexChanged);
            // 
            // SongsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 259);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SongsForm";
            this.Text = "SongsForm";
            this.Activated += new System.EventHandler(this.SongsForm_Activated);
            this.Deactivate += new System.EventHandler(this.SongsForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SongsForm_FormClosing);
            this.Load += new System.EventHandler(this.SongsForm_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.itemsCounterToolStrip.ResumeLayout(false);
            this.itemsCounterToolStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ListView songsListView;
        private System.Windows.Forms.ColumnHeader titleHeader;
        private System.Windows.Forms.ColumnHeader authorHeader;
        private System.Windows.Forms.ColumnHeader releaseDateHeader;
        private System.Windows.Forms.ColumnHeader genreHeader;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editingStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStripMenuItem;
        private System.Windows.Forms.ToolStripButton addStripButton;
        private System.Windows.Forms.ToolStripButton editStripButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        public System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip itemsCounterToolStrip;
        private System.Windows.Forms.ToolStripLabel itemsCounterToolStripLabel;
        private System.Windows.Forms.ToolStripMenuItem editStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStripMenuItem;
        private System.Windows.Forms.ToolStripButton deleteStripButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripComboBox filterComboBox;
    }
}