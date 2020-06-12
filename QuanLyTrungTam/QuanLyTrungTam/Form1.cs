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
namespace QuanLyTrungTam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strcon = "Data Source=RIN;Database=CSDL_QLTT;Integrated Security=True";
        SqlConnection conn = null;
        void OpenConnection ()
        {
            if(conn  == null)
            conn = new SqlConnection(strcon);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TaiTrungTamLenTreeView();
        }

        SqlCommand TaoCommand (string sql)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
          SqlConnection conn = new SqlConnection(strcon);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            command.Connection = conn;
            return command;
        }

        private void TaiTrungTamLenTreeView()
        {
            //OpenConnection();
            SqlCommand commandTT = TaoCommand("select * from CacTrungTam");
            SqlDataReader reader = commandTT.ExecuteReader();
            tvTT.Nodes.Clear();
            while(reader.Read())
            {
                string maTT =reader.GetString(0);
                string TenTT = reader.GetString(1);

                TreeNode nodeTT = new TreeNode(TenTT);
                nodeTT.Tag = maTT;
                tvTT.Nodes.Add(nodeTT);
                SqlCommand commandLop = TaoCommand("select * from Lop where MaTT='" + maTT + "'");
                SqlDataReader readerLop = commandLop.ExecuteReader();
                while (readerLop.Read())
                {
                    string maLop = readerLop.GetString(0);
                    string TenLop = readerLop.GetString(1);

                    TreeNode nodelop = new TreeNode(TenLop);
                   nodelop.Tag = maLop;
                    nodeTT.Nodes.Add(nodelop);

                    SqlCommand commandSV = TaoCommand("select * from SinhVien where MaLop='" + maLop + "'");
                    SqlDataReader readerSV = commandSV.ExecuteReader();
                    while (readerSV.Read())
                    {
                        string maSV = readerSV.GetString(0);
                        string TenSv = readerSV.GetString(1);
                        int Sdt = readerSV.GetInt32(2);
                        TreeNode nodeSV = new TreeNode(TenSv);
                        nodeSV.Tag = maSV;
                        nodelop.Nodes.Add(nodeSV);

                    }
                    readerSV.Close();
                }
                readerLop.Close();
            }
            reader.Close();
          
        }

        private void tvTT_AfterSelect(object sender, TreeViewEventArgs e)
        {
             if(e.Node !=null)
            {
                if (e.Node.Level == 0)
                {
                    string matt = e.Node.Tag.ToString();
                    HienthiLenListView(matt);
                }
                else
                {
                    string maLop = e.Node.Tag.ToString();
                    HienthiSVLenListView(maLop);
                }
              
            }
        }

        private void HienthiSVLenListView(string maLop)
        {
            lvdata.Items.Clear();
            lvdata.Columns.Clear();
            lvdata.Columns.Add("Ma SV", 150);
            lvdata.Columns.Add("Ten SV", 300);
            lvdata.Columns.Add("Phone", 300);

            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SinhVien where MaLop='" + maLop + "'";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                
                ListViewItem lv = new ListViewItem(reader.GetString(0));
                lv.SubItems.Add(reader.GetString(1));
                lv.SubItems.Add(reader.GetInt32(2).ToString());
                lvdata.Items.Add(lv);
            }
            reader.Close();
        }

        private void HienthiLenListView(string matt)
        {
            lvdata.Items.Clear();
            lvdata.Columns.Clear();
            lvdata.Columns.Add("Ma Lop", 150);
            lvdata.Columns.Add("Ten Lop", 200);

            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Lop where MaTT='" + matt + "'";
            command.Connection = conn;

            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                ListViewItem lv = new ListViewItem(reader.GetString(0));
                lv.SubItems.Add(reader.GetString(1));
                lvdata.Items.Add(lv);
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lvdata.Items.Clear();
            lvdata.Columns.Clear();
            lvdata.Columns.Add("Ma SV", 150);
            lvdata.Columns.Add("Ten SV", 300);
            lvdata.Columns.Add("Phone", 300);

            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SinhVien where TenSv like @ten ";
            command.Parameters.Add("@ten", SqlDbType.NVarChar).Value ="%"+ tbten.Text+"%";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(reader.GetString(0));
                lv.SubItems.Add(reader.GetString(1));
                lv.SubItems.Add(reader.GetInt32(2).ToString());
                lvdata.Items.Add(lv);
            }
            reader.Close();
        }
    }
}
