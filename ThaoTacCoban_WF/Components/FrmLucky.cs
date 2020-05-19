using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components
{
    public partial class FrmLucky : Form
    {
        public FrmLucky()
        {
            InitializeComponent();
        }
        int tienmay = 100;
        int tienNguoiChoi = 100;
        Random rd = new Random();
        int count = 0;
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            int so1 = rd.Next(9);
            int so2 = rd.Next(10);
            int so3 = rd.Next(11);

            lbl1.Text = so1 + "";
            lbl2.Text = so2+ "";
            lbl3.Text = so3 + "";
            if (count > 100)
            {
                if(so1 ==7)
                {
                    tienNguoiChoi = tienNguoiChoi + 100 + (tienmay / 2);
                    tienmay = tienmay / 2;
                }
                if(so2 ==7)
                {
                    tienNguoiChoi = tienNguoiChoi + 30 + (tienmay / 2);
                    tienmay = tienmay / 2;
                }
                if(so3 == 7)
                {
                    tienNguoiChoi = tienNguoiChoi + 100;
                }
                lblTienNguoiChoi.Text = tienNguoiChoi + "";
                lblTienMay.Text = tienmay + "";
                timer1.Stop();

            }
            count++;

        }

        private void btnQuaySo_Click(object sender, EventArgs e)
        {
            count = 0;
            if(tienNguoiChoi < 30)
            {
                MessageBox.Show("Bạn không còn đủ tiền để chơi ");
                return;
            }

            tienNguoiChoi = tienNguoiChoi - 30 ;
            tienmay = tienmay + 30;
            timer1.Start();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn thực sự muốn thoát");
           
                Close();
       
          
        }

        private void btnGameMoi_Click(object sender, EventArgs e)
        {
            tienmay = 100;
            tienNguoiChoi = 100;
            lblTienNguoiChoi.Text = tienNguoiChoi + "";
            lblTienMay.Text = tienmay + "";
            lbl1.Text = 7 + "";
            lbl2.Text = 7 + "";
            lbl3.Text = 7 + "";
        }
    }
}
