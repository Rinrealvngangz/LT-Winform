using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdicontainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bai1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm1 bai1 = new Frm1();
            bai1.MdiParent = this;
            bai1.Show();
        }

        private void frm2_Click(object sender, EventArgs e)
        {
            Frm2 bai2 = new Frm2();
            bai2.MdiParent = this;
            bai2.Show();
        }

        private void frm3_Click(object sender, EventArgs e)
        {
            Frm3 bai3 = new Frm3();
            bai3.MdiParent = this;
            bai3.Show();
        }

        private void arrangeIconToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void titleHorizoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void titleverticalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }
    }
}
