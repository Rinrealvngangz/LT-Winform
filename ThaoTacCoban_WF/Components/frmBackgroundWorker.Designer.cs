namespace Components
{
    partial class frmBackgroundWorker
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
            this.btnVe = new System.Windows.Forms.Button();
            this.btnSapxep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.pnButton = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnVe
            // 
            this.btnVe.Location = new System.Drawing.Point(214, 25);
            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(75, 23);
            this.btnVe.TabIndex = 0;
            this.btnVe.Text = "Vẽ mảng";
            this.btnVe.UseVisualStyleBackColor = true;
            this.btnVe.Click += new System.EventHandler(this.btnVe_Click);
            // 
            // btnSapxep
            // 
            this.btnSapxep.Location = new System.Drawing.Point(314, 25);
            this.btnSapxep.Name = "btnSapxep";
            this.btnSapxep.Size = new System.Drawing.Size(75, 23);
            this.btnSapxep.TabIndex = 1;
            this.btnSapxep.Text = "Sắp xếp";
            this.btnSapxep.UseVisualStyleBackColor = true;
            this.btnSapxep.Click += new System.EventHandler(this.btnSapxep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập n:";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(91, 26);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(100, 22);
            this.txtN.TabIndex = 3;
            // 
            // pnButton
            // 
            this.pnButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnButton.Location = new System.Drawing.Point(30, 71);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(677, 386);
            this.pnButton.TabIndex = 4;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // frmBackgroundWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 469);
            this.Controls.Add(this.pnButton);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSapxep);
            this.Controls.Add(this.btnVe);
            this.Name = "frmBackgroundWorker";
            this.Text = "frmBackgroundWorker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVe;
        private System.Windows.Forms.Button btnSapxep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Panel pnButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}