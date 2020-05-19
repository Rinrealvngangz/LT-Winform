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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;

        string strcon = "Data Source=RIN;Database=CSDL_QLSP;Integrated Security=True";
        private void btnDem_Click(object sender, EventArgs e)
        {
            if(conn ==null)            
                conn = new SqlConnection(strcon);       
            
            if( conn.State == ConnectionState.Closed)           
                conn.Open();
            SqlCommand commnad = new SqlCommand();

            commnad.CommandType = CommandType.Text;

            commnad.CommandText = "select count(*) from SanPham";
            commnad.Connection = conn;

            object data = commnad.ExecuteScalar();

            int n = (int)data;
            lblsp.Text = "Có " + n + "Sản phẩm";
                
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnchitiet_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strcon);
            if (conn.State == ConnectionState.Closed)
                conn.Open();

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SanPham where Ma="+txtma.Text;
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();

            if(reader.Read())
            {
                btnma.Text = reader.GetInt32(0)+"";
                btnten.Text = reader.GetString(1);
                btngia.Text = reader.GetInt32(2) + "";
            }

           reader.Close();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strcon);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SanPham where Ma=@ma";
            command.Connection = conn;

            SqlParameter para = new SqlParameter("@ma",SqlDbType.Int);
            
            para.Value = txtma.Text;
            command.Parameters.Add(para);

            SqlDataReader reader = command.ExecuteReader();

            if(reader.Read())
            {
                btnma.Text = reader.GetInt32(0)+"";
                btnten.Text = reader.GetString(1);
                btngia.Text = reader.GetInt32(2) + "";
            }
            reader.Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strcon);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand command = new SqlCommand();

            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SanPham";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            listView1.Items.Clear();
            while(reader.Read())
            {
                ListViewItem li = new ListViewItem(reader.GetInt32(0)+"");
                li.SubItems.Add(reader.GetString(1));
                li.SubItems.Add(reader.GetInt32(2) + "");

                listView1.Items.Add(li);
            }

            reader.Close();
        }
    }
}
