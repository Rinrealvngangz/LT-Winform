namespace DataBinding
{
    partial class Form3
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
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnprev = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.lbtrang = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtDm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(60, 41);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(77, 45);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "|<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(669, 41);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(65, 45);
            this.btnLast.TabIndex = 1;
            this.btnLast.Text = ">|";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(202, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 38);
            this.button3.TabIndex = 2;
            this.button3.Text = "Thêm";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(350, 377);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Lưu";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(532, 377);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "Xóa";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnprev
            // 
            this.btnprev.Location = new System.Drawing.Point(202, 41);
            this.btnprev.Name = "btnprev";
            this.btnprev.Size = new System.Drawing.Size(90, 42);
            this.btnprev.TabIndex = 5;
            this.btnprev.Text = "<<";
            this.btnprev.UseVisualStyleBackColor = true;
            this.btnprev.Click += new System.EventHandler(this.btnprev_Click);
            // 
            // btnnext
            // 
            this.btnnext.Location = new System.Drawing.Point(551, 41);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(85, 45);
            this.btnnext.TabIndex = 6;
            this.btnnext.Text = ">>";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // lbtrang
            // 
            this.lbtrang.Location = new System.Drawing.Point(378, 55);
            this.lbtrang.Name = "lbtrang";
            this.lbtrang.Size = new System.Drawing.Size(71, 24);
            this.lbtrang.TabIndex = 7;
            this.lbtrang.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Danh Mục";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(206, 130);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(243, 22);
            this.txtma.TabIndex = 12;
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(206, 179);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(243, 22);
            this.txtten.TabIndex = 13;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(206, 228);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(243, 22);
            this.txtGia.TabIndex = 14;
            // 
            // txtDm
            // 
            this.txtDm.Location = new System.Drawing.Point(206, 273);
            this.txtDm.Name = "txtDm";
            this.txtDm.Size = new System.Drawing.Size(243, 22);
            this.txtDm.TabIndex = 15;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDm);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbtrang);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprev);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnFirst);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnprev;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Label lbtrang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtDm;
    }
}