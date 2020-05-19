using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //xu ly su kien theo dong
        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvSanPham.SelectedItems.Count>0)
            {
                ListViewItem lv = lvSanPham.SelectedItems[0];
                string ma = lv.SubItems[0].Text;
                string tensp = lv.SubItems[1].Text;
                int gia = int.Parse(lv.SubItems[2].Text);
                txtMa.Text = ma;
                txtTen.Text = tensp;
                txtgia.Text = gia+"";

            }
        }

        private void lvSanPham_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if(e.Column !=-1)
            {
                ColumnHeader col = lvSanPham.Columns[e.Column];
                MessageBox.Show("ban click cot:"+col.Text);
            }
        }

        private void btnAddSp_Click(object sender, EventArgs e)
        {
            // tao 1 ListItem (tao 1 dong)

            ListViewItem lvi = new ListViewItem(txtMa.Text);   
             // them cac cot con lai
            lvi.SubItems.Add(txtTen.Text);
            lvi.SubItems.Add(txtgia.Text);
            // dua len giao dien
            lvSanPham.Items.Add(lvi);

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if(lvSanPham.SelectedItems.Count>0)
            {
                ListViewItem lv = lvSanPham.SelectedItems[0];
                //lvSanPham.Items.Remove(lv);
                lvSanPham.Items.RemoveAt(lv.Index);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lv = lvSanPham.SelectedItems[0];

                lv.SubItems[0].Text = txtMa.Text + "";
                lv.SubItems[1].Text = txtTen.Text + "";
                lv.SubItems[2].Text = txtgia.Text + "";

            }
        }
    }
}
