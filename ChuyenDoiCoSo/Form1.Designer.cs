namespace ChuyenDoiCoSo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.ketqua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selectCoSo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.checkerr = new System.Windows.Forms.Label();
            this.labelKQ = new System.Windows.Forms.Label();
            this.checkInputLong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Số";
            // 
            // txtnumber
            // 
            this.txtnumber.BackColor = System.Drawing.Color.Black;
            this.txtnumber.Location = new System.Drawing.Point(179, 30);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(117, 22);
            this.txtnumber.TabIndex = 1;
            this.txtnumber.TextChanged += new System.EventHandler(this.txtnumber_TextChanged);
            // 
            // ketqua
            // 
            this.ketqua.BackColor = System.Drawing.Color.Black;
            this.ketqua.ForeColor = System.Drawing.Color.White;
            this.ketqua.Location = new System.Drawing.Point(179, 133);
            this.ketqua.Multiline = true;
            this.ketqua.Name = "ketqua";
            this.ketqua.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ketqua.Size = new System.Drawing.Size(117, 22);
            this.ketqua.TabIndex = 4;
           
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 3;
            // 
            // selectCoSo
            // 
            this.selectCoSo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.selectCoSo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.selectCoSo.BackColor = System.Drawing.Color.Black;
            this.selectCoSo.ForeColor = System.Drawing.Color.FloralWhite;
            this.selectCoSo.FormattingEnabled = true;
            this.selectCoSo.Items.AddRange(new object[] {
            "Cơ số 2",
            "Cơ số 16"});
            this.selectCoSo.Location = new System.Drawing.Point(179, 80);
            this.selectCoSo.Name = "selectCoSo";
            this.selectCoSo.Size = new System.Drawing.Size(117, 24);
            this.selectCoSo.TabIndex = 9;
            this.selectCoSo.SelectedIndexChanged += new System.EventHandler(this.selectCoSo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Chọn cơ số ";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(58, 193);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 11;
            this.delete.Text = "del";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // checkerr
            // 
            this.checkerr.AutoSize = true;
            this.checkerr.Location = new System.Drawing.Point(55, 113);
            this.checkerr.Name = "checkerr";
            this.checkerr.Size = new System.Drawing.Size(0, 17);
            this.checkerr.TabIndex = 12;
            // 
            // labelKQ
            // 
            this.labelKQ.AutoSize = true;
            this.labelKQ.Location = new System.Drawing.Point(55, 138);
            this.labelKQ.Name = "labelKQ";
            this.labelKQ.Size = new System.Drawing.Size(60, 17);
            this.labelKQ.TabIndex = 14;
            this.labelKQ.Text = "Kết Quả";
            // 
            // checkInputLong
            // 
            this.checkInputLong.AutoSize = true;
            this.checkInputLong.Location = new System.Drawing.Point(179, 80);
            this.checkInputLong.Name = "checkInputLong";
            this.checkInputLong.Size = new System.Drawing.Size(0, 17);
            this.checkInputLong.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(372, 287);
            this.Controls.Add(this.checkInputLong);
            this.Controls.Add(this.labelKQ);
            this.Controls.Add(this.checkerr);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.selectCoSo);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi cơ số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox ketqua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox selectCoSo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label checkerr;
        private System.Windows.Forms.Label labelKQ;
        private System.Windows.Forms.Label checkInputLong;
    }
}

