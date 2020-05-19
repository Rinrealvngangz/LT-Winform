using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XuLyTextFile
{
    //Xử lý File Serialization
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<SinhVien> dssv = new List<SinhVien>();
        private void btnThem_Click(object sender, EventArgs e)
        {

            SinhVien sv = new SinhVien();
            sv.Ma = int.Parse(txtMa.Text);
            sv.Ten = txtTen.Text;
            sv.namsinh = dtpNamSinh.Value;
            dssv.Add(sv);
            HienThiDSSV();
        }
        private void HienThiDSSV()
        {
            lisBoxDssv.Items.Clear();
            foreach (SinhVien sv in dssv)
            {
                lisBoxDssv.Items.Add(sv);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath + "\\csdl.txt";
                if (FileFactory.LuuFile(dssv, path))
                {
                    MessageBox.Show("Lưu thành công");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\csdl.txt";
            if (System.IO.File.Exists(path))
            {
                dssv = FileFactory.DocFile(path);
                HienThiDSSV();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDoc.PerformClick();
        }
       


        // Xử lý textFile
        /*
        List<SinhVien> dssv = new List<SinhVien>();
        private void btnThem_Click(object sender, EventArgs e)
        {
            SinhVien sv = new SinhVien();
            sv.Ma = int.Parse(txtMa.Text);
            sv.Ten = txtTen.Text;
            sv.namsinh = dtpNamSinh.Value;
            dssv.Add(sv);
            HienThiDSSV();
        }

        private void HienThiDSSV()
        {
            lisBoxDssv.Items.Clear();
            foreach( SinhVien sv in dssv )
            {
                lisBoxDssv.Items.Add(sv);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath + "\\csdl.txt";
                if (FileFactory.LuuFile(dssv, path))
                {
                    MessageBox.Show("Lưu thành công");
                }
            }catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
          
           
            
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\csdl.txt";
            if (System.IO.File.Exists(path))
           { dssv = FileFactory.DocFile(path);
                HienThiDSSV();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDoc.PerformClick();
        }*/
    }
}
