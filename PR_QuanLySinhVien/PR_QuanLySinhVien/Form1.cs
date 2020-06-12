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
namespace PR_QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strcon = "Data Source=RIN;Database=CSDL_PRQLSV;Integrated Security=True";
        SqlConnection conn = null;
        void OpenConnection()
        {
            if (conn == null)
                conn = new SqlConnection(strcon);
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TaiLopLenMenuTrip();
        }

        private void TaiLopLenMenuTrip()
        {
            OpenConnection();
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Lop";
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            mnuDSLop.DropDownItems.Clear();
            ToolStripMenuItem itemMenu = new ToolStripMenuItem("Tat ca cac Lop");
            itemMenu.Tag = "All";
            itemMenu.Click += MnuItem_Click;
            mnuDSLop.DropDownItems.Add(itemMenu);
            while (reader.Read())
            {
                string malop = reader.GetString(0);
                string tenlop = reader.GetString(1);
                itemMenu = new ToolStripMenuItem(tenlop);
                itemMenu.Tag = malop;
                mnuDSLop.DropDownItems.Add(itemMenu);
                itemMenu.Click += MnuItem_Click;
            }
            reader.Close();
        }
        ToolStripMenuItem mnuItemPre = null;
        private void MnuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem itemMenu = sender as ToolStripMenuItem;
            if (mnuItemPre != null)
                mnuItemPre.Checked = false;          
            itemMenu.Checked = !itemMenu.Checked;
            mnuItemPre = itemMenu;
            string ma = itemMenu.Tag.ToString();
            if (ma == "All")
            {
                hienthiSV();
            }
            else
                hienthiSVtheoLop(ma);
        }

        private void hienthiSVtheoLop(string maLop)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from SinhVien where MaLop='" + maLop + "'";
            command.Connection = conn;
            SqlDataReader readersv = command.ExecuteReader();
            listView1.Items.Clear();
            listView1.Groups.Clear();
            int stt = 1;
            while (readersv.Read())
            {
                string ma = readersv.GetString(0);
                string ten = readersv.GetString(1);
                ListViewItem lv = new ListViewItem(stt + "");
                lv.SubItems.Add(ma);
                lv.SubItems.Add(ten);
                listView1.Items.Add(lv);
               
                stt++;

            }
            readersv.Close();
        }

        private void hienthiSV()
        {
            OpenConnection();
            SqlCommand commandLop = new SqlCommand();
            commandLop.CommandType = CommandType.Text;
            commandLop.CommandText = "select * from Lop";
            commandLop.Connection = conn;
            SqlDataReader reader = commandLop.ExecuteReader();
            listView1.Items.Clear();
            listView1.Groups.Clear();
            while(reader.Read())
            {
                ListViewGroup lvg = new ListViewGroup(reader.GetString(1));
                lvg.Tag = reader.GetString(0);
                listView1.Groups.Add(lvg);
            }
            reader.Close();
            foreach(ListViewGroup lvg in listView1.Groups)
            {
                string maLop = lvg.Tag.ToString();
           
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from SinhVien where MaLop='"+maLop+"'";
                command.Connection = conn;
                SqlDataReader readersv = command.ExecuteReader();
  
                int stt = 1;
                while (readersv.Read())
                {
                    string ma = readersv.GetString(0);
                    string ten = readersv.GetString(1);
                    ListViewItem lv = new ListViewItem(stt + "");
                    lv.SubItems.Add(ma);
                    lv.SubItems.Add(ten);
                    listView1.Items.Add(lv);
                    lv.Group = lvg;           
                    stt++;

                }
                readersv.Close();
            }
          

        }
    }
}
