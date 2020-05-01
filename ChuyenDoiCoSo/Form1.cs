using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuyenDoiCoSo
{
    

    public partial class Form1 : Form
    {
     
        long[] stack = new long[100];
        long[] newstack = new long[100];
        int p = -1;
        int newp = -1;
       // int dem;
        long number;
        int coso;
      
        public Form1()
        {
            
            InitializeComponent();
        }
       
     
    
      
        //pop in stack
        public void PopMotPhanTu()
        {        
            long kq;
            do
            {

                kq = stack[p--];
                Push(kq);
            } while (p >= 0);
     
        }

        // thêm stack temp
        public void PushTemp(long pt)
        {
            p++;
            stack[p] = pt;       
        }
        // thêm stack main
        public void Push(long pt)
        {
          //  dem = arrlist.Count;
           newp++;   
         //   arrlist.Add( pt);
            newstack[newp] = pt;
        }
 

        //kiemtra input is number
        private void txtnumber_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;

            if (long.TryParse(txtnumber.Text, out number))
            {
                checkerr.ForeColor = Color.Green;
                checkerr.Text = "Success";
                labelKQ.ForeColor = Color.Black;
                txtnumber.ForeColor = Color.White;
            }
            else
            {
                checkerr.ForeColor = Color.Red;
                checkerr.Text = "Error";
               

            }
          // check kiểu number Long
          if(txtnumber.Text.Length>19)
            {

                selectCoSo.Visible = false;//  ẩn combobox ||form
                checkInputLong.ForeColor = Color.Red;
                checkInputLong.Text = "Không Nhập quá 19 số";
            }
            else
            {
                selectCoSo.Visible = true;  //hiển thị combobox ||form
                checkInputLong.Text = "";
            }
          
        }
        // phương thức thực thi chuyển đổi Cơ số
        public void Coso(long so)
        {
            long sodu;
            //check kiểu chuyển đổi
            if(selectCoSo.SelectedIndex == 0)
            {
                coso = 2;
            }else if (selectCoSo.SelectedIndex ==1)
            {
                coso = 16;
            }
            do
            {
                sodu = so % coso;//1 ,0,1
                so = so / coso;//2,1,0
                PushTemp(sodu);
            } while (so > 0);

            PopMotPhanTu();
        }

        private void selectCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
              int i;
            string s = "";

            ComboBox cb = sender as ComboBox;
            //check input is empty
            if(txtnumber.Text =="")
            {
                checkerr.ForeColor = Color.Red;
                checkerr.Text = "Lỗi,bạn phải nhập số";
               
            }
            if (cb.SelectedIndex == 0)
            {
               
                Coso(number);
              
            }
            else if (cb.SelectedIndex == 1)
            {
               
                Coso(number);
                
            }
   
            //  ArrayList arrlist = new ArrayList();
          
            for (i = 0; i <= newp; i++)
            {
                if (newstack[i] == 10)
                {
                    s += "A";
                }
                else if (newstack[i] == 11)
                {
                    s += "B";
                }
                else if (newstack[i] == 12)
                {
                    s += "C";
                }
                else if (newstack[i] == 13)
                {
                    s += "D";
                }
                else if (newstack[i] == 14)
                {
                    s += "E";
                }
                else if (newstack[i] == 15)
                {
                    s += "F";
                }
                else
                    s += newstack[i].ToString();
                //  s +=arrlist[i].ToString();

            }

            ketqua.Text = s;
            selectCoSo.Text = "";
            newp = -1;
            labelKQ.ForeColor = Color.Orange;
            //MessageBox.Show(dem.ToString());
            // arrlist.Clear();
        }
// xử lý delete
        private void delete_Click(object sender, EventArgs e)
        {
            ketqua.Text = " ";
            selectCoSo.Text = "";
            txtnumber.Text = "";
            checkerr.ForeColor = Color.Green;
            checkerr.Text = "Success";
            labelKQ.ForeColor = Color.Black;
        }

        
    }
  
   

}




