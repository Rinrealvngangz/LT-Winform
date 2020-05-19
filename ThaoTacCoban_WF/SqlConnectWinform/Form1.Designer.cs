namespace SqlConnectWinform
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
            this.btnKetnoi = new System.Windows.Forms.Button();
            this.btnNgatKetNoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKetnoi
            // 
            this.btnKetnoi.Location = new System.Drawing.Point(243, 36);
            this.btnKetnoi.Name = "btnKetnoi";
            this.btnKetnoi.Size = new System.Drawing.Size(75, 23);
            this.btnKetnoi.TabIndex = 0;
            this.btnKetnoi.Text = "Kết nối DB";
            this.btnKetnoi.UseVisualStyleBackColor = true;
            this.btnKetnoi.Click += new System.EventHandler(this.btnKetnoi_Click);
            // 
            // btnNgatKetNoi
            // 
            this.btnNgatKetNoi.Location = new System.Drawing.Point(272, 107);
            this.btnNgatKetNoi.Name = "btnNgatKetNoi";
            this.btnNgatKetNoi.Size = new System.Drawing.Size(75, 23);
            this.btnNgatKetNoi.TabIndex = 1;
            this.btnNgatKetNoi.Text = "Đóng kết nối";
            this.btnNgatKetNoi.UseVisualStyleBackColor = true;
            this.btnNgatKetNoi.Click += new System.EventHandler(this.btnNgatKetNoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 272);
            this.Controls.Add(this.btnNgatKetNoi);
            this.Controls.Add(this.btnKetnoi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKetnoi;
        private System.Windows.Forms.Button btnNgatKetNoi;
    }
}

