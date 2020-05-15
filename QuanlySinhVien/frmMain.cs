using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlySinhVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        Dictionary<string, Khoa> CSDL = new Dictionary<string, Khoa>();
        Sinhvien SelectedSinhvien = null;
        private void frmMain_Load(object sender, EventArgs e)
        {
            LamGiaDuLieu();
            HienThiTreeView();
            HienThiKhoaLenCombobox();
        }

        private void HienThiKhoaLenCombobox()
        {
            cbKhoa.Items.Clear();

            foreach(KeyValuePair<string,Khoa> itemsKhoa in CSDL )
            {
                Khoa kh = itemsKhoa.Value;
                cbKhoa.Items.Add(kh);
            }
        }
        private void HienThiTreeView()
        {
            tvKhoa.Nodes.Clear();

            foreach(KeyValuePair<string,Khoa> itemKhoa in CSDL )
            {
                
                Khoa kh = itemKhoa.Value;
                TreeNode nodeKhoa = new TreeNode(kh.TenKhoa); //hiển thị
                nodeKhoa.Tag = kh;//lưu lại lập trình sử lý 
             
                tvKhoa.Nodes.Add(nodeKhoa);

          

                foreach (KeyValuePair<string, LopHoc> itemLop in kh.Lops)
                {
                    LopHoc lp = itemLop.Value;

                    TreeNode nodeLop = new TreeNode(lp.TenLop);

                    nodeLop.Tag = lp;

                    nodeKhoa.Nodes.Add(nodeLop);

                }

            }
            tvKhoa.CollapseAll();
        }
        private void LamGiaDuLieu()
        {
            Khoa CNTT = new Khoa()
            { MaKhoa = "CNTT", TenKhoa = "Khoa Công Nghệ Thông Tin" };
            Khoa DT = new Khoa()
            { MaKhoa = "DT", TenKhoa = "Khoa Điện Tử" };
            Khoa Luat = new Khoa()
            { MaKhoa = "L", TenKhoa = "Khoa Luật" };
            Khoa KinhTe = new Khoa()
            { MaKhoa = "KT", TenKhoa = "Khoa Kinh Tế" };

            CSDL.Add(CNTT.MaKhoa, CNTT);
            CSDL.Add(DT.MaKhoa, DT);
            CSDL.Add(Luat.MaKhoa, Luat);
            CSDL.Add(KinhTe.MaKhoa, KinhTe);

            LopHoc Lopcntt1 = new LopHoc()
            { MaLop = "cntt1", TenLop = "Đại Học Tin Học 1" };

            CNTT.Lops.Add(Lopcntt1.MaLop, Lopcntt1);
            Lopcntt1.KhoaChuQuan = CNTT;

            LopHoc Lopcntt2 = new LopHoc()
            { MaLop = "cntt2", TenLop = "Đại Học Tin Học 2" };

            CNTT.Lops.Add(Lopcntt2.MaLop, Lopcntt2);
            Lopcntt2.KhoaChuQuan = CNTT;

            LopHoc LopLuat1 = new LopHoc()
            { MaLop = "LopLuat1", TenLop = "Đại Học Luật 1" };

            Luat.Lops.Add(LopLuat1.MaLop, LopLuat1);
            LopLuat1.KhoaChuQuan = Luat;

            LopHoc LopLuat2 = new LopHoc()
            { MaLop = "LopLuat2", TenLop = "Đại Học Luật 2" };

            Luat.Lops.Add(LopLuat2.MaLop, LopLuat2);
            LopLuat2.KhoaChuQuan = Luat;

            LopHoc LopLuat3 = new LopHoc()
            { MaLop = "LopLuat3", TenLop = "Đại Học Luật 3" };

            Luat.Lops.Add(LopLuat3.MaLop, LopLuat3);
            LopLuat3.KhoaChuQuan = Luat;

           Sinhvien tuan = new Sinhvien()
            { Ma ="sv1", Ten = "Nguyen Mậu Tuân",
                GioiTinh = false, 
                NamSinh = new DateTime(2000, 3, 6)
           };

            Lopcntt1.SinhViens.Add(tuan.Ma, tuan);
            tuan.LopChuQuan = Lopcntt1;
            

            Sinhvien Tu = new Sinhvien()
            { Ma = "sv2", Ten = "Nguyen Hoang Tú", 
                GioiTinh = true,
                NamSinh = new DateTime(2000, 4,8) };

            Lopcntt1.SinhViens.Add(Tu.Ma, Tu);

            Tu.LopChuQuan = Lopcntt1;

        }

        private void tvKhoa_AfterSelect(object sender, TreeViewEventArgs e)
        {
          
            if (e.Node!=null)// có chọn 1 node 
            {
               
                if(e.Node.Level ==1)
                {
                    LopHoc lp = e.Node.Tag as LopHoc;
                   HienThiDanhSachSVTheoLop(lp);
                }
               
            }
            else
            {
                lvSinhVien.Items.Clear();//ko hiển thị
            }
        }

        private void HienThiDanhSachSVTheoLop(LopHoc lp)
        {
            lvSinhVien.Items.Clear();
            foreach(KeyValuePair<string,Sinhvien> itemSinhVien in lp.SinhViens)
            {
               Sinhvien sv = itemSinhVien.Value;
                ListViewItem lvi = new ListViewItem(sv.Ma);
                lvi.SubItems.Add(sv.Ten);
                lvi.SubItems.Add(sv.GioiTinh ==false? "Nam" :"Nữ");
                if(sv.NamSinh!=null)
                
                    lvi.SubItems.Add(sv.NamSinh.ToString("dd/MM/yyy"));
                
                else
                    lvi.SubItems.Add(sv.NamSinh.ToString("<.....>"));

                lvSinhVien.Items.Add(lvi);

                lvi.Tag = sv;
            }
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbKhoa.SelectedIndex == -1) return;

            Khoa kh = cbKhoa.SelectedItem as Khoa;
            HienThiLopLenCombobox(kh);
        }
        private void HienThiLopLenCombobox(Khoa kh)
        {
            cbLop.Items.Clear();

            foreach (KeyValuePair<string, LopHoc> itemsLop in kh.Lops)
            {
                LopHoc lp = itemsLop.Value;
                cbLop.Items.Add(lp);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string hex = "#09f72d";
            Color _color = System.Drawing.ColorTranslator.FromHtml(hex);

            btnLuu.BackColor = _color;
            if (cbKhoa.SelectedIndex == -1)
              
            {
                MessageBox.Show("Bạn chưa chọn Khoa");
                return;
            }
            if (cbLop.SelectedIndex == -1)

            {
                MessageBox.Show("Bạn chưa chọn Lop");
                return;
            }

            Sinhvien sv = new Sinhvien();
            sv.Ma = txtMa.Text;
            sv.Ten = txtTenSV.Text;
            sv.GioiTinh = radNu.Checked;
            LopHoc lp = cbLop.SelectedItem as LopHoc;
            sv.LopChuQuan = lp;  
            foreach( KeyValuePair<string,Sinhvien> itemssv in lp.SinhViens )
            {
                if(txtMa.Text == itemssv.Value.Ma)
                {
                   
                    MessageBox.Show("Hãy nhập lại mã", "Trùng mã",MessageBoxButtons.OK);
                    return;
                }
            }
            lp.SinhViens.Add(sv.Ma,sv);
            MessageBox.Show("Lưu Thành công");

        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (lvSinhVien.SelectedItems.Count == 0)
                return;

            ListViewItem lvi = lvSinhVien.SelectedItems[0];  
            Sinhvien sv = lvi.Tag as Sinhvien;
            LopHoc lp = sv.LopChuQuan;
            
            txtMa.Text = sv.Ma;
            txtTenSV.Text = sv.Ten;
           
            if(sv.GioiTinh)
            {
                radNu.Checked = true;
            }
            else
                radNam.Checked = true;
         
            cbKhoa.SelectedItem = lp.KhoaChuQuan;
            cbLop.SelectedItem = lp;
            SelectedSinhvien = sv;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string hex = "#f71b0e";
            Color _color = System.Drawing.ColorTranslator.FromHtml(hex);
          
            btnXoa.BackColor = _color;

            if (SelectedSinhvien != null)
            {
                if (MessageBox.Show("Bạn muốn Xóa sinh viên", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    LopHoc lp = SelectedSinhvien.LopChuQuan;
                    lp.SinhViens.Remove(SelectedSinhvien.Ma);
                    txtMa.Text = null;
                    txtTenSV.Text = null;
                
                    if (SelectedSinhvien.GioiTinh) radNu.Checked = false;
                    else radNam.Checked = false;

                    cbKhoa.SelectedItem = null;
                    cbLop.SelectedItem = null;
                    if (lvSinhVien.SelectedItems != null)
                    {
                        ListViewItem lv = lvSinhVien.SelectedItems[0];
                        lv.SubItems.Clear();
                    }
                    MessageBox.Show("Xóa Thành công");
                }
            }
           else
            {
                MessageBox.Show("Bạn chưa Chọn Sinh viên");
            }
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            string hex = "##bf5af2";
        
            Color _color = System.Drawing.ColorTranslator.FromHtml(hex);
      
            btnThoat.BackColor = _color;
         
            if (MessageBox.Show("Bạn muốn Thoát Chương trình","Thông báo",MessageBoxButtons.OKCancel) ==DialogResult.OK)
            {
                Application.Exit();
            }
        
        }

        private void mnusave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "text .txt|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileFactory.SaveFile(CSDL, saveFileDialog1.FileName);
                MessageBox.Show("Lưu Thành Công");
            }
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter= "text .txt|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
               CSDL = FileFactory.OpenFile(openFileDialog1.FileName);
                HienThiTreeView();
                MessageBox.Show("Mở File Thành Công");
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn Thoát Chương trình", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            pnTTSV.Visible = true;
            if (pnTTK.Visible == true || pnDSSV.Visible == true)
            {
                pnTTK.Visible = false;
                pnDSSV.Visible = false;
            }
        }

        
        private void groupBox2_Enter(object sender, EventArgs e)
        {
            pnDSSV.Visible = true;
            if (pnTTK.Visible == true || pnTTSV.Visible == true)
            {
                pnTTK.Visible = false;
                pnTTSV.Visible = false;
            }
        }

      
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            pnTTK.Visible = true;
            if (pnTTSV.Visible == true || pnDSSV.Visible == true)
            {
                pnTTSV.Visible = false;
                pnDSSV.Visible = false;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
         
           if (MessageBox.Show("Bạn muốn Thoát Chương trình", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
           {
                Application.Exit();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
           
            this.WindowState = FormWindowState.Minimized;
            this.Visible = true;
            this.ShowInTaskbar = true;
          
        }

      
    }
}
