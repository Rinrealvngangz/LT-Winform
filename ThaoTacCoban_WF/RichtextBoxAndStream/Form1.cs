using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace RichtextBoxAndStream
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "plant text .txt|*.txt";

            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtNoidung.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                MessageBox.Show("lưu thành công");
            }
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "plant text .txt|*.txt";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream str = openFileDialog1.OpenFile();
                StreamReader sr = new StreamReader(str);

                rtNoidung.Text = sr.ReadToEnd();
                sr.Close();
                
            }
        }
    }
}
