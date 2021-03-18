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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        int dif = 5, timp = 100, pct = 50, pct_baza = 50;
        bool pass = false;
        Timpul_a_expirat g = new Timpul_a_expirat();
        Felicitari4 f = new Felicitari4();

        private void btn_iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dif1_Click(object sender, EventArgs e)
        {
            dif1.Visible = false;
            dif--;
            lbl_dif.Text = Convert.ToString(dif);
            pct += 10;
            lbl_pct.Text = Convert.ToString(pct);
            if (dif == 0)
            {

                pass = true;
                timer1.Stop();
                f.ShowDialog();

            }
        }

        private void dif2_Click(object sender, EventArgs e)
        {
            dif2.Visible = false;
            dif--;
            lbl_dif.Text = Convert.ToString(dif);
            pct += 10;
            lbl_pct.Text = Convert.ToString(pct);
            if (dif == 0)
            {

                pass = true;
                timer1.Stop();
                f.ShowDialog();
                

            }
        }

        private void dif3_Click(object sender, EventArgs e)
        {
            dif3.Visible = false;
            dif--;
            lbl_dif.Text = Convert.ToString(dif);
            pct += 10;
            lbl_pct.Text = Convert.ToString(pct);
            if (dif == 0)
            {

                pass = true;
                timer1.Stop();
                f.ShowDialog();


            }
        }

        private void dif4_Click(object sender, EventArgs e)
        {
            dif4.Visible = false;
            dif--;
            lbl_dif.Text = Convert.ToString(dif);
            pct += 10;
            lbl_pct.Text = Convert.ToString(pct);
            if (dif == 0)
            {

                pass = true;
                timer1.Stop();
                f.ShowDialog();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Visible = false;
            AlegeJocul f = new AlegeJocul();
            f.ShowDialog();
        }

        private void dif5_Click(object sender, EventArgs e)
        {
            dif5.Visible = false;
            dif--;
            lbl_dif.Text = Convert.ToString(dif);
            pct += 10;
            lbl_pct.Text = Convert.ToString(pct);
            if (dif == 0)
            {

                pass = true;
                timer1.Stop();
                f.ShowDialog();


            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            dif = 5;
            timp = 100;
            pass = false;
            pct = pct_baza;
            dif1.Visible = true;
            dif2.Visible = true;
            dif3.Visible = true;
            dif4.Visible = true;
            dif5.Visible = true;
            progressBar1.Value = timp;
            lbl_dif.Text = Convert.ToString(dif);
            lbl_pct.Text = Convert.ToString(pct);
            timer1.Start();
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


                    g.ShowDialog();
                }
        }
    }
}
