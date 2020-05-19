namespace mdicontainer
{
    partial class Form1
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
            this.baiTapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frm1 = new System.Windows.Forms.ToolStripMenuItem();
            this.frm2 = new System.Windows.Forms.ToolStripMenuItem();
            this.frm3 = new System.Windows.Forms.ToolStripMenuItem();
            this.sapXepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleHorizoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleverticalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baiTapToolStripMenuItem,
            this.sapXepToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // baiTapToolStripMenuItem
            // 
            this.baiTapToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frm1,
            this.frm2,
            this.frm3});
            this.baiTapToolStripMenuItem.Name = "baiTapToolStripMenuItem";
            this.baiTapToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.baiTapToolStripMenuItem.Text = "bai tap";
            // 
            // frm1
            // 
            this.frm1.Name = "frm1";
            this.frm1.Size = new System.Drawing.Size(224, 26);
            this.frm1.Text = "bai 1";
            this.frm1.Click += new System.EventHandler(this.bai1ToolStripMenuItem_Click);
            // 
            // frm2
            // 
            this.frm2.Name = "frm2";
            this.frm2.Size = new System.Drawing.Size(224, 26);
            this.frm2.Text = "bai 2";
            this.frm2.Click += new System.EventHandler(this.frm2_Click);
            // 
            // frm3
            // 
            this.frm3.Name = "frm3";
            this.frm3.Size = new System.Drawing.Size(224, 26);
            this.frm3.Text = "bai 3";
            this.frm3.Click += new System.EventHandler(this.frm3_Click);
            // 
            // sapXepToolStripMenuItem
            // 
            this.sapXepToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrangeIconToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.titleHorizoneToolStripMenuItem,
            this.titleverticalsToolStripMenuItem});
            this.sapXepToolStripMenuItem.Name = "sapXepToolStripMenuItem";
            this.sapXepToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.sapXepToolStripMenuItem.Text = "Sap xep";
            // 
            // arrangeIconToolStripMenuItem
            // 
            this.arrangeIconToolStripMenuItem.Name = "arrangeIconToolStripMenuItem";
            this.arrangeIconToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.arrangeIconToolStripMenuItem.Text = "Arrange Icon";
            this.arrangeIconToolStripMenuItem.Click += new System.EventHandler(this.arrangeIconToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // titleHorizoneToolStripMenuItem
            // 
            this.titleHorizoneToolStripMenuItem.Name = "titleHorizoneToolStripMenuItem";
            this.titleHorizoneToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.titleHorizoneToolStripMenuItem.Text = "TitleHorizotals";
            this.titleHorizoneToolStripMenuItem.Click += new System.EventHandler(this.titleHorizoneToolStripMenuItem_Click);
            // 
            // titleverticalsToolStripMenuItem
            // 
            this.titleverticalsToolStripMenuItem.Name = "titleverticalsToolStripMenuItem";
            this.titleverticalsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.titleverticalsToolStripMenuItem.Text = "Titleverticals";
            this.titleverticalsToolStripMenuItem.Click += new System.EventHandler(this.titleverticalsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem baiTapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frm1;
        private System.Windows.Forms.ToolStripMenuItem frm2;
        private System.Windows.Forms.ToolStripMenuItem frm3;
        private System.Windows.Forms.ToolStripMenuItem sapXepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleHorizoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleverticalsToolStripMenuItem;
    }
}

