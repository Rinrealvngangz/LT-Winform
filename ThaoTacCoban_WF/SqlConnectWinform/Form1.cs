using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SqlConnectWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection conn = null;

        string strConnect = "Data Source=RIN;Database=CSDL_QLSV;Integrated Security=True";
        private void btnKetnoi_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(strConnect);
                conn.Open();
                MessageBox.Show("Kết nối thành công");

            }catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnNgatKetNoi_Click(object sender, EventArgs e)
        {
            if(conn !=null && conn.State ==ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show(" Đóng Kết nối thành công");
            }
            else
            {
                MessageBox.Show(" Đóng Kết nối thất bại");
            }
        }
    }
}
