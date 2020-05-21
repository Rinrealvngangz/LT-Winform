namespace DeleteDuLieu
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
            this.danhsachsp = new System.Windows.Forms.ListBox();
            this.btnxoa1 = new System.Windows.Forms.Button();
            this.btnxoac2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // danhsachsp
            // 
            this.danhsachsp.FormattingEnabled = true;
            this.danhsachsp.ItemHeight = 16;
            this.danhsachsp.Location = new System.Drawing.Point(233, 53);
            this.danhsachsp.Name = "danhsachsp";
            this.danhsachsp.Size = new System.Drawing.Size(382, 212);
            this.danhsachsp.TabIndex = 0;
            this.danhsachsp.SelectedIndexChanged += new System.EventHandler(this.danhsachsp_SelectedIndexChanged);
            // 
            // btnxoa1
            // 
            this.btnxoa1.Location = new System.Drawing.Point(249, 327);
            this.btnxoa1.Name = "btnxoa1";
            this.btnxoa1.Size = new System.Drawing.Size(75, 41);
            this.btnxoa1.TabIndex = 1;
            this.btnxoa1.Text = "XoaC1";
            this.btnxoa1.UseVisualStyleBackColor = true;
            this.btnxoa1.Click += new System.EventHandler(this.btnxoa1_Click);
            // 
            // btnxoac2
            // 
            this.btnxoac2.Location = new System.Drawing.Point(449, 327);
            this.btnxoac2.Name = "btnxoac2";
            this.btnxoac2.Size = new System.Drawing.Size(75, 41);
            this.btnxoac2.TabIndex = 2;
            this.btnxoac2.Text = "Xóa C2";
            this.btnxoac2.UseVisualStyleBackColor = true;
            this.btnxoac2.Click += new System.EventHandler(this.btnxoac2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.btnxoac2);
            this.Controls.Add(this.btnxoa1);
            this.Controls.Add(this.danhsachsp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox danhsachsp;
        private System.Windows.Forms.Button btnxoa1;
        private System.Windows.Forms.Button btnxoac2;
    }
}

