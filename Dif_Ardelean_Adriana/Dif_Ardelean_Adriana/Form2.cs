using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dif_Ardelean_Adriana
{
    public partial class Form2 : Form
    {
       

        public Form2()
        {
            InitializeComponent();
            button3.Visible = false;
        }

        
        int  dif=4, timp = 10, pct = 15, pct_baza = 15;
        Felicitari2 f = new Felicitari2();
        Timpul_a_expirat g = new Timpul_a_expirat();

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void lbl_1_MouseClick(object sender, MouseEventArgs e)
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
                button3.Visible = true;
                
            }
        }

        private void lbl_2_MouseClick(object sender, MouseEventArgs e)
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
                button3.Visible = true;
                
            }
        }

        private void lbl_3_MouseClick(object sender, MouseEventArgs e)
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
                button3.Visible = true;
                
            }
        }

        private void lbl_4_MouseClick(object sender, MouseEventArgs e)
        {
           
  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dif = 4;
            timp = 10;
            progressBar1.Value = timp;
            timer1.Start();
            button3.Visible = false;
            label4.Text = Convert.ToString(dif);
            lbl_1.Visible = true;
            lbl_2.Visible = true;
            lbl_3.Visible = true;
            lbl_4.Visible = true;
            pct = pct_baza;
            label6.Text = Convert.ToString(pct);
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 f = new Form4();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Visible = false;
            AlegeJocul f = new AlegeJocul();
            f.ShowDialog();
        }

        private void lbl_1_Click(object sender, EventArgs e)
        {
            
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

                    button3.Visible = false;
                    g.ShowDialog();
                }
        }

        private void lbl_4_Click(object sender, EventArgs e)
        {
            dif--;

            lbl_4.Visible = false;
            pct = pct + 5;
            label6.Text = Convert.ToString(pct);
            label4.Text = Convert.ToString(dif);

            if (dif == 0)
            {
                timer1.Stop();
                f.ShowDialog();
                button3.Visible = true;
                
            }
        }
    }
}
