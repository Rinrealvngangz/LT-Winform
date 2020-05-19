using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnchonhinh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Tap tin .png|*.png|Tat ca |*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picOpenFile.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "*.txt|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Ban muon luu vao: " + saveFileDialog1.FileName);

            }
            else
                MessageBox.Show("Ban ko muon luu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           colorDialog1.Color = btndoimau.BackColor;
            colorDialog1.AllowFullOpen = true;
            colorDialog1.FullOpen = true;
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                btndoimau.BackColor = colorDialog1.Color;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //fontDialog1.Font = doifont.Font;
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                doifont.Font = fontDialog1.Font;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
