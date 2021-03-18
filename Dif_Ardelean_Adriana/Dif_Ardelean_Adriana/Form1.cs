using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; 


namespace Dif_Ardelean_Adriana
{
    public partial class Form1 : Form
    {
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr Handle, int Msg, int Param1, int Param2);

        public Form1()
        {
            InitializeComponent();
            button1.Visible = false;
        }
        
        int dif = 3, timp = 10, pct = 0, pct_baza = 0;
        Felicitari1 f = new Felicitari1();
        Timpul_a_expirat g = new Timpul_a_expirat();
            

        private void btn_iesire_Click(object sender, EventArgs e)
        {
            
            Application.Exit(); 
        }

        private void lbl_1_Click(object sender, EventArgs e)
        {
            dif--;

            lbl_1.Visible = false;
            pct = pct + 5;
            label6.Text = Convert.ToString(pct);
            label4.Text = Convert.ToString(dif);
            if (dif == 0)
            {
                timer1.Stop();
                f.ShowDialog();
                button1.Visible = true;
               
            }
        }

        private void lbl_2_Click(object sender, EventArgs e)
        {
            dif--;
            pct = pct + 5;
            label6.Text = Convert.ToString(pct);
            lbl_2.Visible = false;
            label4.Text = Convert.ToString(dif);
            if (dif == 0)
            {
                timer1.Stop();
                f.ShowDialog();
                button1.Visible = true;
                
            }
        }

        private void lbl_3_Click(object sender, EventArgs e)
        {
            dif--;
            pct = pct + 5;
            label6.Text = Convert.ToString(pct);
            lbl_3.Visible = false;
            label4.Text = Convert.ToString(dif);
            if (dif == 0)
            {
                timer1.Stop();

                f.ShowDialog();
                button1.Visible = true;
            }
           }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            dif = 3;
            timp = 10;
            progressBar1.Value = timp;
            timer1.Start();
            button1.Visible=false;
            label4.Text = Convert.ToString(dif);
            lbl_1.Visible = true;
            lbl_2.Visible = true;
            lbl_3.Visible = true;
            pct = pct_baza;
            label6.Text = Convert.ToString(pct);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Visible = false;
            AlegeJocul f = new AlegeJocul();
            f.ShowDialog();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 f = new Form2();
            f.ShowDialog();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timp > 0)
            {
                progressBar1.Value = timp;
                timp--;

            }
            else
                if (timp == 0)
                {
                    timer1.Stop();

                    button1.Visible = false;
                    g.ShowDialog();
                }
        }
    }
}
