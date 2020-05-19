using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuFileNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban muon tao file");
        }

        private void mnufileOpen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban muon mo file");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            mnufileOpen.PerformClick();

        }

        private void btnew_Click(object sender, EventArgs e)
        {
            mnuFileNew.PerformClick();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s = DateTime.Now.ToString("dd/mm/yy hh:mm:ss");
            lblDate.Text = s;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int percent;
            for (int i = 0; i < 100; i++)
            {
                percent = (i * 100) / 100;
                backgroundWorker1.ReportProgress(percent, i);
                System.Threading.Thread.Sleep(200);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ProgressBarPercent.Value = e.ProgressPercentage;
            lblpercentValue.Text = e.UserState + "";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
