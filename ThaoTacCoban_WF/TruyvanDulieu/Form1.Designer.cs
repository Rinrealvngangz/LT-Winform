namespace TruyvanDulieu
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
            this.btnDem = new System.Windows.Forms.Button();
            this.btnchitiet = new System.Windows.Forms.Button();
            this.lblsp = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnma = new System.Windows.Forms.TextBox();
            this.btnten = new System.Windows.Forms.TextBox();
            this.btngia = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnDem
            // 
            this.btnDem.Location = new System.Drawing.Point(12, 12);
            this.btnDem.Name = "btnDem";
            this.btnDem.Size = new System.Drawing.Size(168, 40);
            this.btnDem.TabIndex = 0;
            this.btnDem.Text = "Đếm số sp";
            this.btnDem.UseVisualStyleBackColor = true;
            this.btnDem.Click += new System.EventHandler(this.btnDem_Click);
            // 
            // btnchitiet
            // 
            this.btnchitiet.Location = new System.Drawing.Point(12, 151);
            this.btnchitiet.Name = "btnchitiet";
            this.btnchitiet.Size = new System.Drawing.Size(121, 41);
            this.btnchitiet.TabIndex = 1;
            this.btnchitiet.Text = "xem chi tiết";
            this.btnchitiet.UseVisualStyleBackColor = true;
            this.btnchitiet.Click += new System.EventHandler(this.btnchitiet_Click);
            // 
            // lblsp
            // 
            this.lblsp.AutoSize = true;
            this.lblsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsp.Location = new System.Drawing.Point(209, 13);
            this.lblsp.Name = "lblsp";
            this.lblsp.Size = new System.Drawing.Size(110, 39);
            this.lblsp.TabIndex = 2;
            this.lblsp.Text = "Số Sp";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(216, 80);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(103, 22);
            this.txtma.TabIndex = 3;
            this.txtma.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "nhập mã sp:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "giá";
            // 
            // btnma
            // 
            this.btnma.Location = new System.Drawing.Point(111, 210);
            this.btnma.Name = "btnma";
            this.btnma.Size = new System.Drawing.Size(100, 22);
            this.btnma.TabIndex = 8;
            this.btnma.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnten
            // 
            this.btnten.Location = new System.Drawing.Point(111, 251);
            this.btnten.Name = "btnten";
            this.btnten.Size = new System.Drawing.Size(100, 22);
            this.btnten.TabIndex = 9;
            // 
            // btngia
            // 
            this.btngia.Location = new System.Drawing.Point(111, 279);
            this.btngia.Name = "btngia";
            this.btngia.Size = new System.Drawing.Size(100, 22);
            this.btngia.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 44);
            this.button1.TabIndex = 11;
            this.button1.Text = "xem chi tiết c2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(441, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(301, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Hiển thị dssp";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(441, 98);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(301, 265);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 451);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btngia);
            this.Controls.Add(this.btnten);
            this.Controls.Add(this.btnma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.lblsp);
            this.Controls.Add(this.btnchitiet);
            this.Controls.Add(this.btnDem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDem;
        private System.Windows.Forms.Button btnchitiet;
        private System.Windows.Forms.Label lblsp;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox btnma;
        private System.Windows.Forms.TextBox btnten;
        private System.Windows.Forms.TextBox btngia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

