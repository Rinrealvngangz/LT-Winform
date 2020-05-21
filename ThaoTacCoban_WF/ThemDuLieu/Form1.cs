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
namespace ThemDuLieu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strconn = "Data Source=RIN;Database=CSDL_QLSP;Integrated Security=True";
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiSp();
        }
        public void HienThiSp()
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select *from SanPham";
            command.Connection = conn;

            SqlDataReader read = command.ExecuteReader();
            lvSp.Items.Clear();
            while(read.Read())
            {
                ListViewItem lvi = new ListViewItem(read.GetInt32(0) + "");
                lvi.SubItems.Add(read.GetString(1));
                lvi.SubItems.Add(read.GetInt32(2)+"");
                lvSp.Items.Add(lvi);
            }
            read.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql = "Insert into SanPham(Ma,Ten,DonGia,MaDanhMuc)"+
                "values(" + txtma.Text + ",N'" + txtten.Text + "'," + txtgia.Text +","+txtdm.Text+")";
            command.CommandText = sql;
            command.Connection = conn;
          int ret =  command.ExecuteNonQuery();
            if(ret>0)
            {
                HienThiSp();
            }
            else
            {
                MessageBox.Show("Nhập sản phâmr");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (conn == null)
                    conn = new SqlConnection(strconn);
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                string sql = "Insert into SanPham(Ma,Ten,DonGia,MaDanhMuc)" +
                    "values(@ma,@ten,@gia,@danhmuc)";
                command.CommandText = sql;
                command.Connection = conn;
                command.Parameters.Add("@ma", SqlDbType.Int).Value = txtma.Text;
                command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtten.Text;
                command.Parameters.Add("@gia", SqlDbType.Int).Value = txtgia.Text;
                command.Parameters.Add("@danhmuc", SqlDbType.Int).Value = txtdm.Text;
                int ret = command.ExecuteNonQuery();
                if (ret > 0)
                {
                    HienThiSp();
                }
                else
                {
                    MessageBox.Show("Nhập sản phâm");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
        }
    }
}
