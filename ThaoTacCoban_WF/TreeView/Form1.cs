using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuthemNut_Click(object sender, EventArgs e)
        {
            frm1 frm = new frm1();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                if(tvDulieu.SelectedNode==null)//tao nut goc
                {
                    TreeNode root = new TreeNode(frm.txtGiatri.Text);

                    tvDulieu.Nodes.Add(root);                   
                }
                else//tao nut con cua selectedNode
                {
                    TreeNode node = new TreeNode(frm.txtGiatri.Text);

                    tvDulieu.SelectedNode.Nodes.Add(node);
                    if(node.Level ==2)
                    {
                        node.ImageIndex = 2;
                        node.SelectedImageIndex = 3;
                    }
                }
            }
        }

        private void tvDulieu_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvDulieu.SelectedNode = e.Node;
        }

        private void mnuSuaNut_Click(object sender, EventArgs e)
        {
            if(tvDulieu.SelectedNode ==null)
            {
                return;
            }
            frm1 frm = new frm1();

            if(frm.ShowDialog() == DialogResult.OK)
            {
                tvDulieu.SelectedNode.Text = frm.txtGiatri.Text;
            }
        }

        private void mnuXoaNut_Click(object sender, EventArgs e)
        {
            if(tvDulieu.SelectedNode !=null)
            {
                tvDulieu.Nodes.Remove(tvDulieu.SelectedNode);
            }
        }

        private void mnuMorong_Click(object sender, EventArgs e)
        {
            if (tvDulieu.SelectedNode != null)
            {
                tvDulieu.SelectedNode.ExpandAll();
            }
        }

        private void mnuthuGon_Click(object sender, EventArgs e)
        {
            if (tvDulieu.SelectedNode != null)
            {
                tvDulieu.SelectedNode.Collapse();
            }
        }

        private void tvDulieu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node!=null)
            {
                lblChon.Text = e.Node.Text;
            }
        }
    }
}
