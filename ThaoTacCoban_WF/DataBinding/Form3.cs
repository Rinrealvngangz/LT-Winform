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
namespace DataBinding
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        DataSet ds;
        BindingSource bs;
        SqlDataAdapter adapter = null;
        string strcon = "Data Source=RIN;Database=CSDL_QLSP;Integrated Security=True";
        private void Form3_Load(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strcon);

             adapter = new SqlDataAdapter("Select * from SanPham", conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds,"SanPham");
            bs = new BindingSource(ds,"SanPham");
            txtma.DataBindings.Add("Text", bs, "Ma");
            txtten.DataBindings.Add("Text", bs, "Ten");
            txtGia.DataBindings.Add("Text", bs, "DonGia");
            txtDm.DataBindings.Add("Text", bs, "DonGia");
            lbtrang.Text = "1/" + bs.Count;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bs.Position = 0;
            lbtrang.Text = bs.Position + 1 + "/" + bs.Count;
        }

        private void btnprev_Click(object sender, EventArgs e)
        { 
            if(bs.Position>0)
            bs.Position = bs.Position-1;
            lbtrang.Text = bs.Position +1 +"/" + bs.Count;
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (bs.Position < bs.Count-1)
                bs.Position = bs.Position + 1;
            lbtrang.Text = bs.Position + 1 + "/" + bs.Count;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
           
            bs.Position = bs.Count - 1;
            lbtrang.Text = bs.Position + 1 + "/" + bs.Count;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bs.AddNew();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bs.EndEdit();
            int kq = adapter.Update(ds.Tables["SanPham"]);
            if(kq>0)
            {
                MessageBox.Show("Thành công");
            }
            else

                MessageBox.Show("Thất bại");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bs.RemoveCurrent();
            int kq = adapter.Update(ds.Tables["SanPham"]);
            if (kq > 0)
            {
                MessageBox.Show("Thành công");
            }
            else

                MessageBox.Show("Thất bại");
        }
    }
}
