using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHienthi_Click(object sender, EventArgs e)
        {
            SanPhamBLL spbll = new SanPhamBLL();

            List<SanPham> dbSP = spbll.LayToanBoSanPham();
            lvSanPham.Items.Clear();
            foreach(SanPham sp in dbSP)
            {
                ListViewItem lvi = new ListViewItem(sp.MaSp + "");
                lvi.SubItems.Add(sp.TenSp);
                lvi.SubItems.Add(sp.DonGia+"");
                lvi.SubItems.Add(sp.MaDM + "");
                lvSanPham.Items.Add(lvi);
                lvi.Tag = sp;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lvSanPham.SelectedItems.Count >0)
            {
                ListViewItem lvi = lvSanPham.SelectedItems[0];
                  SanPham sp = lvi.Tag as SanPham;
               
                SanPhamBLL spbll = new SanPhamBLL();
                     bool kq = spbll.XoaSp(sp.MaSp);
                if(kq)               
                    btnHienthi.PerformClick();
                
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPhamBLL spbll = new SanPhamBLL();
          
            SanPham sp = new SanPham();
            sp.MaSp =int.Parse(tbMa.Text);
            sp.TenSp = tbTen.Text;
            sp.DonGia = int.Parse(tbGia.Text);
            sp.MaDM = int.Parse(tbDanhMuc.Text);
            if (spbll.ThemSanPham(sp))
            {
                btnHienthi.PerformClick();
            }
           
        }
    }
}
