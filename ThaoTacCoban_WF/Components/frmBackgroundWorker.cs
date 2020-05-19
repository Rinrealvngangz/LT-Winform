using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components
{
    public partial class frmBackgroundWorker : Form
    {
        public frmBackgroundWorker()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        int[] M;// main
        Button[] Mc;//giao diện
        int HEIGHT = 100;
        int SIZE = 50;
        int gap = 50;
        private void btnVe_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);
            M = new int[n];
            Mc = new Button[n];
            pnButton.Controls.Clear();
            for(int i=0; i<n;i++)
            {
                Button btn = new Button();
                int value = rd.Next(100);
                btn.Text = value+"";
                btn.Width = btn.Height = SIZE;
                btn.Location = new Point(pnButton.Controls.Count * (btn.Width + gap),
                    pnButton.Height / 2 - btn.Height);
                pnButton.Controls.Add(btn);
                M[i] = value;
                Mc[i] = btn;
            }
           
        }
        private void btnSapxep_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BubbleSort(M);
        }
       
        public void BubbleSort(int[] M)
        {
            int i, j;
            Status st = new Status();
            for(i=0;i<M.Length-1;i++)
            {
                for (j = M.Length - 1; j > i; j--)
                {
                    if (M[j] < M[j - 1])
                    {
                        
                      int  temp = M[j];
                        M[j] = M[j - 1];
                        M[j - 1] = temp;
                       System.Threading.Thread.Sleep(10);
                        MoveButton(j, j - 1);
                    }
                }
            }
        }

        private void MoveButton(int pos1, int pos2)
        {
            Status st = new Status();
            st.Pos1 = pos1;
            st.Pos2 = pos2;
            st.type = MoveType.LINE_TO_TOP_AND_LINE_TO_BOTTOM;
            for (int x = 0; x < HEIGHT; x++)
            {
                backgroundWorker1.ReportProgress(0,st);
                System.Threading.Thread.Sleep(10);
            }
            st.type =MoveType.LEFT_TO_RIGHT_AND_RIGHT_TO_LEFT;
            int WIDTH = Math.Abs(pos1-pos2)*(SIZE+gap);
               for (int x = 0; x < WIDTH; x++)
            {
                backgroundWorker1.ReportProgress(0,st);
                System.Threading.Thread.Sleep(10);
            }
             st.type = MoveType.TOP_TO_LINE_AND_BOTTOM_TO_LINE;
              for (int x = 0; x < HEIGHT; x++)
            {
                backgroundWorker1.ReportProgress(0,st);
                System.Threading.Thread.Sleep(10);
            }
              st.type =MoveType.CHANGED;
              backgroundWorker1.ReportProgress(0,st);
               
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Status st = e.UserState as Status;

            if (st == null) return;
            if(st.type == MoveType.CHANGED)
            {
                Button btnTemp = Mc[st.Pos2];
                Mc[st.Pos2] = Mc[st.Pos1];
                Mc[st.Pos1] = btnTemp;
                return;
            }
            Button btn1 = Mc[st.Pos1];
            Button btn2 = Mc[st.Pos2];
            if (st.type == MoveType.LINE_TO_TOP_AND_LINE_TO_BOTTOM)
            {
                btn1.Top = btn1.Top + 1;
                btn2.Top = btn2.Top - 1;

            }
            else if(st.type == MoveType.LEFT_TO_RIGHT_AND_RIGHT_TO_LEFT)
            {
               btn1.Left =btn1.Left - 1;     
               btn2.Left =btn2.Left + 1;   
            }
            else if(st.type == MoveType.TOP_TO_LINE_AND_BOTTOM_TO_LINE)
              {
                   btn1.Top = btn1.Top- 1;
                btn2.Top = btn2.Top + 1;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach(Button btn in pnButton.Controls)
             {
                btn.BackColor = Color.Red;
                btn.ForeColor =Color.White;
            }
        }

     
    }
}
