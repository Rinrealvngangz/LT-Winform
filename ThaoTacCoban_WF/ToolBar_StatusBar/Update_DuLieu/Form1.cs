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
namespace Update_DuLieu
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
            command.CommandText = "select *from DanhMuc";
            command.Connection = conn;

            SqlDataReader read = command.ExecuteReader();
            cbdm.Items.Clear();
            while (read.Read())
            {
                int ma = read.GetInt32(0);
                 string ten = read.GetString(1);

                cbdm.Items.Add(ma + "-" + ten);
            }
            read.Close();
        }
        int madm = -1;
        private void cbdm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbdm.SelectedIndex == -1) return;

            string line = cbdm.SelectedItem.ToString();

            string[] arr = line.Split('-');

             madm = int.Parse(arr[0]);
            hienthi(madm);
        }

        public void hienthi(int madm)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select *from SanPham where ma="+madm;
            command.Connection = conn;

            SqlDataReader read = command.ExecuteReader();
             livsp.Items.Clear();
            while (read.Read())
            {
                ListViewItem lvi = new ListViewItem(read.GetInt32(0)+"");

                lvi.SubItems.Add(read.GetString(1));
                lvi.SubItems.Add(read.GetInt32(2)+"");
                livsp.Items.Add(lvi);
            }
            read.Close();
        }

        private void livsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (livsp.SelectedItems.Count == 0) return;
            ListViewItem li = livsp.SelectedItems[0];//vì chỉ chọn 1 dòng nên chỉ có 1 ptu => index=0;
            txtma.Text = li.SubItems[0].Text;
            txtten.Text = li.SubItems[1].Text;
            txtgia.Text = li.SubItems[2].Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "update SanPham set ten=N'"+txtten.Text+"',DonGia="+txtgia.Text+"Where ma="+txtma.Text;
            command.Connection = conn;

            int ret = command.ExecuteNonQuery();
          if(ret >0)
            {
                hienthi(madm);
                MessageBox.Show("cập nhật thành công");
            }
            else
            {
                MessageBox.Show("cập nhật thất bại");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            string sql ="update SanPham set ten=@ten,DonGia=@gia Where Ma=@ma";
            command.CommandText = sql;
          
            command.Connection = conn;
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = txtten.Text;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = txtgia.Text;
            command.Parameters.Add("@ma", SqlDbType.Int).Value = txtma.Text;

            int ret = command.ExecuteNonQuery();
            if (ret > 0)
            {
                hienthi(madm);
                MessageBox.Show("cập nhật thành công");
            }
            else
            {
                MessageBox.Show("cập nhật thất bại");
            }
        }
    }
}
