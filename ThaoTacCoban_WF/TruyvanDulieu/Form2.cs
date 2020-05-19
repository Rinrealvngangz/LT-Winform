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
namespace TruyvanDulieu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strconn = "Data Source=RIN;Database=CSDL_QLSP;Integrated Security=True";
        private void Form2_Load(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand comm = new SqlCommand();

            comm.CommandType = CommandType.Text;
            comm.CommandText = "select * from DanhMuc";
            comm.Connection = conn;

            SqlDataReader read = comm.ExecuteReader();
            while(read.Read())
            {
                string line = read.GetInt32(0) + "-" + read.GetString(1);
                lsbDanhmuc.Items.Add(line);
            }
            read.Close();

        }

        private void lsbDanhmuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbDanhmuc.SelectedIndex == -1) return;

            string line = lsbDanhmuc.SelectedItem.ToString();

            string[] arr = line.Split('-');

            int maDanhmuc = int.Parse(arr[0]);

            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SanPham Where MaDanhMuc=@madm";
            command.Connection = conn;
                SqlParameter para  = new SqlParameter("@madm", SqlDbType.Int);
            para.Value = maDanhmuc;
            command.Parameters.Add(para);
            listView1.Items.Clear();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                int ma = reader.GetInt32(0);
                string ten = reader.GetString(1);
                int Gia = reader.GetInt32(2);

                ListViewItem li = new ListViewItem(ma + "");
                li.SubItems.Add(ten);
                li.SubItems.Add(Gia + "");
                listView1.Items.Add(li);
            }
            reader.Close();

        }
    }
}
