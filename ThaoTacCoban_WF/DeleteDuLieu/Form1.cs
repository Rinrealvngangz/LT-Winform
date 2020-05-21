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
namespace DeleteDuLieu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strconn = "Data Source=RIN;Database=CSDL_QLSP;Integrated Security=True";
        private void btnxoa1_Click(object sender, EventArgs e)
        {
            if (danhsachsp.SelectedIndex == -1) return;

            string line = danhsachsp.SelectedItem.ToString();

            string[] arr = line.Split('-');

            int masp = int.Parse(arr[0]);
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from SanPham Where ma="+masp;
            command.Connection = conn;

           int ret = command.ExecuteNonQuery();
          if(ret>0)
            {
                Hienthidssp();
                MessageBox.Show("Thành công");
            }
          else
            {
                MessageBox.Show("Thất bại");
            }
        }

        private void danhsachsp_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hienthidssp();
        }

        private void Hienthidssp()
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
                danhsachsp.Items.Clear();
                while (read.Read())
                {
                    int ma = read.GetInt32(0);
                    string ten = read.GetString(1);

                    danhsachsp.Items.Add(ma + "-" + ten);
                }
                read.Close();
            }

        private void btnxoac2_Click(object sender, EventArgs e)
        {
            if (danhsachsp.SelectedIndex == -1) return;

            string line = danhsachsp.SelectedItem.ToString();

            string[] arr = line.Split('-');

            int masp = int.Parse(arr[0]);
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "delete from SanPham Where ma=@ma";
            command.Parameters.Add("@ma", SqlDbType.Int).Value = masp;
            command.Connection = conn;

            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                Hienthidssp();
                MessageBox.Show("Thành công");
            }
            else
            {
                MessageBox.Show("Thất bại");
            }
        }
    }
    }

