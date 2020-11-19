namespace WindowsFormsMusic
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.windowsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowStripButton = new System.Windows.Forms.ToolStripButton();
            this.itemsCounterToolStrip = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowsStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(633, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(633, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // windowsStripMenuItem
            // 
            this.windowsStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowStripMenuItem});
            this.windowsStripMenuItem.Name = "windowsStripMenuItem";
            this.windowsStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.windowsStripMenuItem.Text = "Windows";
            // 
            // newWindowStripMenuItem
            // 
            this.newWindowStripMenuItem.Name = "newWindowStripMenuItem";
            this.newWindowStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newWindowStripMenuItem.Text = "New Window";
            this.newWindowStripMenuItem.Click += new System.EventHandler(this.newWindowStripButton_Click);
            // 
            // newWindowStripButton
            // 
            this.newWindowStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newWindowStripButton.Image")));
            this.newWindowStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newWindowStripButton.Name = "newWindowStripButton";
            this.newWindowStripButton.Size = new System.Drawing.Size(98, 22);
            this.newWindowStripButton.Text = "New Window";
            this.newWindowStripButton.Click += new System.EventHandler(this.newWindowStripButton_Click);
            // 
            // itemsCounterToolStrip
            // 
            this.itemsCounterToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.itemsCounterToolStrip.Location = new System.Drawing.Point(0, 474);
            this.itemsCounterToolStrip.Name = "itemsCounterToolStrip";
            this.itemsCounterToolStrip.Size = new System.Drawing.Size(633, 25);
            this.itemsCounterToolStrip.TabIndex = 2;
            this.itemsCounterToolStrip.Text = "toolStrip2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 499);
            this.Controls.Add(this.itemsCounterToolStrip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Music Organizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem windowsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowStripMenuItem;
        private System.Windows.Forms.ToolStripButton newWindowStripButton;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStrip itemsCounterToolStrip;
    }
}

