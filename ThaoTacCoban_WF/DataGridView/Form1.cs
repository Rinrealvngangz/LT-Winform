using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Nhanvien> dsNv = new List<Nhanvien>();

            dsNv.Add(new Nhanvien()
            { ma= 1, ten="Nguyen mau tuan",phone ="0949238337" });
            dsNv.Add(new Nhanvien()
            { ma = 2, ten = "Nguyen mau khao", phone = "09492383565" });
            dsNv.Add(new Nhanvien()
            { ma = 3, ten = "Nguyen mau kha", phone = "09492383544" });
            dsNv.Add(new Nhanvien()
            { ma = 4, ten = "Nguyen mau tu", phone = "094923834545" });

            gnNhanvien.DataSource = dsNv;
        }

        private void gnNhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
                DataGridViewRow row = gnNhanvien.Rows[e.RowIndex];

            string s = row.Cells[1].Value+"";

            MessageBox.Show(s);
        }
    }
}
