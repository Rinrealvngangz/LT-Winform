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
namespace DataAdapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string strcon = "Data Source=RIN;Database=CSDL_QLSP;Integrated Security=True";
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        private void btnsp_Click(object sender, EventArgs e)
        {
            if (conn == null)
                conn = new SqlConnection(strcon);
                 adapter = new SqlDataAdapter("Select * from SanPham", conn);
            SqlCommandBuilder buider = new SqlCommandBuilder(adapter);

           ds = new DataSet();

            adapter.Fill(ds,"SanPham");
            gvDSSp.DataSource = ds.Tables["SanPham"];
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["SanPham"].NewRow();

            row["Ma"] = txtMa.Text;
            row["Ten"] = txtTen.Text;
            row["DonGia"] = txtGia.Text;
            row["MaDanhMuc"] = txtDm.Text;

            ds.Tables["SanPham"].Rows.Add(row);

            int kq = adapter.Update(ds.Tables["SanPham"]);
            if (kq > 0)
            {
                btnsp.PerformClick();
            }
            else
                MessageBox.Show("Thất bại");
        }

        int vt = -1;
        private void gvDSSp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1) return;

            DataRow row = ds.Tables["SanPham"].Rows[vt];

            txtMa.Text = row["Ma"] + "";
            txtTen.Text = row["Ten"] + "";
            txtGia.Text = row["DonGia"] + "";
            txtDm.Text = row["MaDanhMuc"] + "";

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;

            DataRow row = ds.Tables["SanPham"].Rows[vt];
            row.BeginEdit();
            row["Ma"] = txtMa.Text;
            row["Ten"] = txtTen.Text;
            row["DonGia"] = txtGia.Text;
            row["MaDanhMuc"] = txtDm.Text;
            row.EndEdit();
            int kq = adapter.Update(ds.Tables["SanPham"]);
            if (kq > 0)
            {
                btnsp.PerformClick();
                MessageBox.Show("Thành công");
            }
            else
                MessageBox.Show("Thất bại");
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (vt == -1) return;

            DataRow row = ds.Tables["SanPham"].Rows[vt];

            row.Delete();
            int kq = adapter.Update(ds.Tables["SanPham"]);
            if (kq > 0)
            {
                btnsp.PerformClick();
                MessageBox.Show("Thành công");
            }
            else
                MessageBox.Show("Thất bại");
        }
    }
}
