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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<DanhMuc> KhoHang = new List<DanhMuc>();
        private void Form2_Load(object sender, EventArgs e)
        {
            DanhMuc bia = new DanhMuc();
            bia.masp = "dm1";
            bia.tensp = "Nhom bia";
            KhoHang.Add(bia);

            SanPham biaken = new SanPham();

            biaken.masp = "Sp1";
            biaken.tensp = "heiniken";
            biaken.giasp = 150;
            bia.themsp(biaken);
            SanPham bia33 = new SanPham();

            bia33.masp = "Sp2";
            bia33.tensp = "Bia 33";
            bia33.giasp = 100;
            bia.themsp(bia33);

            DanhMuc ruou = new DanhMuc();
            ruou.masp = "dm2";
            ruou.tensp = "Nhom ruou";
            KhoHang.Add(ruou);

            SanPham Vodka = new SanPham();

            Vodka.masp = "Sp3";
            Vodka.tensp = "Vodca Lao";
            Vodka.giasp = 50;
            ruou.themsp(Vodka);

            foreach(DanhMuc dm in KhoHang)
            {
                //tao nhom list view
                ListViewGroup lvg = new ListViewGroup(dm.tensp);
                listView1.Groups.Add(lvg);
               
                  foreach (SanPham sp in dm.Sanphams)
                  {
                      //tao 1 dong du lieu ListView Items
                      ListViewItem lv = new ListViewItem(sp.masp);
                      lv.SubItems.Add(sp.tensp);
                      lv.SubItems.Add(sp.giasp+"");
                      lv.Group = lvg;
                      listView1.Items.Add(lv);
                      if(dm ==ruou)
                      {
                          lv.ForeColor = Color.Red;
                      }
                  }

            }
        }
    }
}
