namespace EOI_new
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelSaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageFilterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.imageFilterToolStripMenuItem,
            this.setupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1143, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelNewToolStripMenuItem,
            this.modelOpenToolStripMenuItem,
            this.modelSaveToolStripMenuItem,
            this.modelSaveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.imageLoadToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(55, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // modelNewToolStripMenuItem
            // 
            this.modelNewToolStripMenuItem.Name = "modelNewToolStripMenuItem";
            this.modelNewToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.modelNewToolStripMenuItem.Text = "Model New";
            this.modelNewToolStripMenuItem.Click += new System.EventHandler(this.modelNewToolStripMenuItem_Click);
            // 
            // modelOpenToolStripMenuItem
            // 
            this.modelOpenToolStripMenuItem.Name = "modelOpenToolStripMenuItem";
            this.modelOpenToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.modelOpenToolStripMenuItem.Text = "Model Open";
            this.modelOpenToolStripMenuItem.Click += new System.EventHandler(this.modelOpenToolStripMenuItem_Click);
            // 
            // modelSaveToolStripMenuItem
            // 
            this.modelSaveToolStripMenuItem.Name = "modelSaveToolStripMenuItem";
            this.modelSaveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.modelSaveToolStripMenuItem.Text = "Model Save";
            this.modelSaveToolStripMenuItem.Click += new System.EventHandler(this.modelSaveToolStripMenuItem_Click);
            // 
            // modelSaveAsToolStripMenuItem
            // 
            this.modelSaveAsToolStripMenuItem.Name = "modelSaveAsToolStripMenuItem";
            this.modelSaveAsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.modelSaveAsToolStripMenuItem.Text = "Model SaveAs";
            this.modelSaveAsToolStripMenuItem.Click += new System.EventHandler(this.modelSaveAsToolStripMenuItem_Click);
            // 
            // imageLoadToolStripMenuItem
            // 
            this.imageLoadToolStripMenuItem.Name = "imageLoadToolStripMenuItem";
            this.imageLoadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.imageLoadToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.imageLoadToolStripMenuItem.Text = "imageLoad";
            this.imageLoadToolStripMenuItem.Click += new System.EventHandler(this.imageLoadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.saveToolStripMenuItem.Text = "imageSave";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // imageFilterToolStripMenuItem
            // 
            this.imageFilterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageFilterToolStripMenuItem1});
            this.imageFilterToolStripMenuItem.Name = "imageFilterToolStripMenuItem";
            this.imageFilterToolStripMenuItem.Size = new System.Drawing.Size(118, 29);
            this.imageFilterToolStripMenuItem.Text = "ImageFilter";
            // 
            // imageFilterToolStripMenuItem1
            // 
            this.imageFilterToolStripMenuItem1.Name = "imageFilterToolStripMenuItem1";
            this.imageFilterToolStripMenuItem1.Size = new System.Drawing.Size(210, 34);
            this.imageFilterToolStripMenuItem1.Text = "Image Filter";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem1});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(75, 29);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // setupToolStripMenuItem1
            // 
            this.setupToolStripMenuItem1.Name = "setupToolStripMenuItem1";
            this.setupToolStripMenuItem1.Size = new System.Drawing.Size(161, 34);
            this.setupToolStripMenuItem1.Text = "Setup";
            this.setupToolStripMenuItem1.Click += new System.EventHandler(this.setupToolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(267, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 675);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageFilterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modelNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelOpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelSaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelSaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}