using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DataBinding
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;

        string strcon = "Data Source=RIN;Database=CSDL_QLSP;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strcon);
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from SanPham",conn);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            lsSp.DataSource = ds.Tables[0];
            lsSp.ValueMember = "Ma";
            lsSp.DisplayMember = "Ten";

        }
    }
}
