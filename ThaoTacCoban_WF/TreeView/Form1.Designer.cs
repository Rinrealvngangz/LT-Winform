namespace TreeView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Khoa CNTT");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Khoa Toan");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Dai hoc Cong dong", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Lop co khi", 2, 3);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Khoa co khi", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Dai hoc abc", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tvDulieu = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuthemNut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSuaNut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuXoaNut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMorong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuthuGon = new System.Windows.Forms.ToolStripMenuItem();
            this.lblChon = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvDulieu
            // 
            this.tvDulieu.ContextMenuStrip = this.contextMenuStrip1;
            this.tvDulieu.ImageIndex = 0;
            this.tvDulieu.ImageList = this.imageList1;
            this.tvDulieu.Location = new System.Drawing.Point(66, 52);
            this.tvDulieu.Name = "tvDulieu";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Khoa CNTT";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Khoa Toan";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Dai hoc Cong dong";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "Node6";
            treeNode4.SelectedImageIndex = 3;
            treeNode4.Text = "Lop co khi";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Khoa co khi";
            treeNode6.Name = "Node4";
            treeNode6.Text = "Dai hoc abc";
            this.tvDulieu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.tvDulieu.SelectedImageIndex = 1;
            this.tvDulieu.Size = new System.Drawing.Size(437, 272);
            this.tvDulieu.TabIndex = 0;
            this.tvDulieu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvDulieu_AfterSelect);
            this.tvDulieu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvDulieu_NodeMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuthemNut,
            this.mnuSuaNut,
            this.mnuXoaNut,
            this.mnuMorong,
            this.mnuthuGon});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 124);
            // 
            // mnuthemNut
            // 
            this.mnuthemNut.Name = "mnuthemNut";
            this.mnuthemNut.Size = new System.Drawing.Size(140, 24);
            this.mnuthemNut.Text = "Them nut";
            this.mnuthemNut.Click += new System.EventHandler(this.mnuthemNut_Click);
            // 
            // mnuSuaNut
            // 
            this.mnuSuaNut.Name = "mnuSuaNut";
            this.mnuSuaNut.Size = new System.Drawing.Size(140, 24);
            this.mnuSuaNut.Text = "Sua nut";
            this.mnuSuaNut.Click += new System.EventHandler(this.mnuSuaNut_Click);
            // 
            // mnuXoaNut
            // 
            this.mnuXoaNut.Name = "mnuXoaNut";
            this.mnuXoaNut.Size = new System.Drawing.Size(140, 24);
            this.mnuXoaNut.Text = "Xoa nut";
            this.mnuXoaNut.Click += new System.EventHandler(this.mnuXoaNut_Click);
            // 
            // mnuMorong
            // 
            this.mnuMorong.Name = "mnuMorong";
            this.mnuMorong.Size = new System.Drawing.Size(140, 24);
            this.mnuMorong.Text = "Mo rong";
            this.mnuMorong.Click += new System.EventHandler(this.mnuMorong_Click);
            // 
            // mnuthuGon
            // 
            this.mnuthuGon.Name = "mnuthuGon";
            this.mnuthuGon.Size = new System.Drawing.Size(140, 24);
            this.mnuthuGon.Text = "Thu gon";
            this.mnuthuGon.Click += new System.EventHandler(this.mnuthuGon_Click);
            // 
            // lblChon
            // 
            this.lblChon.AutoSize = true;
            this.lblChon.Location = new System.Drawing.Point(552, 72);
            this.lblChon.Name = "lblChon";
            this.lblChon.Size = new System.Drawing.Size(39, 17);
            this.lblChon.TabIndex = 2;
            this.lblChon.Text = "chon";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "folder_open.png");
            this.imageList1.Images.SetKeyName(2, "file.png");
            this.imageList1.Images.SetKeyName(3, "open_folder.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblChon);
            this.Controls.Add(this.tvDulieu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvDulieu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuthemNut;
        private System.Windows.Forms.ToolStripMenuItem mnuSuaNut;
        private System.Windows.Forms.ToolStripMenuItem mnuXoaNut;
        private System.Windows.Forms.ToolStripMenuItem mnuMorong;
        private System.Windows.Forms.ToolStripMenuItem mnuthuGon;
        private System.Windows.Forms.Label lblChon;
        private System.Windows.Forms.ImageList imageList1;
    }
}

