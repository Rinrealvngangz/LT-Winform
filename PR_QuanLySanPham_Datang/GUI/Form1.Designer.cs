namespace GUI
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
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnHienthi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbMa = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbGia = new System.Windows.Forms.Label();
            this.lbDm = new System.Windows.Forms.Label();
            this.tbMa = new System.Windows.Forms.TextBox();
            this.tbTen = new System.Windows.Forms.TextBox();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.tbDanhMuc = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvSanPham
            // 
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvSanPham.FullRowSelect = true;
            this.lvSanPham.GridLines = true;
            this.lvSanPham.HideSelection = false;
            this.lvSanPham.Location = new System.Drawing.Point(124, 59);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(398, 304);
            this.lvSanPham.TabIndex = 0;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "MãDm";
            this.columnHeader4.Width = 100;
            // 
            // btnHienthi
            // 
            this.btnHienthi.Location = new System.Drawing.Point(36, 17);
            this.btnHienthi.Name = "btnHienthi";
            this.btnHienthi.Size = new System.Drawing.Size(88, 36);
            this.btnHienthi.TabIndex = 1;
            this.btnHienthi.Text = "Hiển thị sp";
            this.btnHienthi.UseVisualStyleBackColor = true;
            this.btnHienthi.Click += new System.EventHandler(this.btnHienthi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(556, 17);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 40);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbMa
            // 
            this.lbMa.AutoSize = true;
            this.lbMa.Location = new System.Drawing.Point(578, 98);
            this.lbMa.Name = "lbMa";
            this.lbMa.Size = new System.Drawing.Size(27, 17);
            this.lbMa.TabIndex = 3;
            this.lbMa.Text = "Mã";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Location = new System.Drawing.Point(578, 159);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(33, 17);
            this.lbTen.TabIndex = 4;
            this.lbTen.Text = "Tên";
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(578, 224);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(30, 17);
            this.lbGia.TabIndex = 5;
            this.lbGia.Text = "Giá";
            // 
            // lbDm
            // 
            this.lbDm.AutoSize = true;
            this.lbDm.Location = new System.Drawing.Point(578, 296);
            this.lbDm.Name = "lbDm";
            this.lbDm.Size = new System.Drawing.Size(68, 17);
            this.lbDm.TabIndex = 6;
            this.lbDm.Text = "DanhMuc";
            // 
            // tbMa
            // 
            this.tbMa.Location = new System.Drawing.Point(662, 98);
            this.tbMa.Name = "tbMa";
            this.tbMa.Size = new System.Drawing.Size(180, 22);
            this.tbMa.TabIndex = 7;
            // 
            // tbTen
            // 
            this.tbTen.Location = new System.Drawing.Point(662, 154);
            this.tbTen.Name = "tbTen";
            this.tbTen.Size = new System.Drawing.Size(180, 22);
            this.tbTen.TabIndex = 8;
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(662, 221);
            this.tbGia.Name = "tbGia";
            this.tbGia.Size = new System.Drawing.Size(180, 22);
            this.tbGia.TabIndex = 9;
            // 
            // tbDanhMuc
            // 
            this.tbDanhMuc.Location = new System.Drawing.Point(662, 291);
            this.tbDanhMuc.Name = "tbDanhMuc";
            this.tbDanhMuc.Size = new System.Drawing.Size(180, 22);
            this.tbDanhMuc.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(570, 372);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 43);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Them Sp";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 450);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.tbDanhMuc);
            this.Controls.Add(this.tbGia);
            this.Controls.Add(this.tbTen);
            this.Controls.Add(this.tbMa);
            this.Controls.Add(this.lbDm);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbTen);
            this.Controls.Add(this.lbMa);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHienthi);
            this.Controls.Add(this.lvSanPham);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnHienthi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lbMa;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbDm;
        private System.Windows.Forms.TextBox tbMa;
        private System.Windows.Forms.TextBox tbTen;
        private System.Windows.Forms.TextBox tbGia;
        private System.Windows.Forms.TextBox tbDanhMuc;
        private System.Windows.Forms.Button btnThem;
    }
}

