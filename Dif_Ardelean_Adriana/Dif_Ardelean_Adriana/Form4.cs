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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            btn_nextlvl.Visible = false;
        }

        int dif = 3, timp = 100, pct = 35, pct_baza = 35;
        bool pass = false;
        Timpul_a_expirat g = new Timpul_a_expirat();
        Felicitari3 f = new Felicitari3();

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void gulerroz_Click(object sender, EventArgs e)
        {
            gulerroz.Visible = false;
            dif--;
            lbl_dif.Text = Convert.ToString(dif);
            pct += 5;
            lbl_pct.Text = Convert.ToString(pct);
            if (dif == 0)
            {
                
                pass = true;
                timer1.Stop();
                f.ShowDialog();
                btn_nextlvl.Visible = true;

            }
        }

        private void dungamodificat_Click(object sender, EventArgs e)
        {
            dungamodificat.Visible = false;
            dif--;
            lbl_dif.Text = Convert.ToString(dif);
            pct += 5;
            lbl_pct.Text = Convert.ToString(pct);
            if (dif == 0)
            {
                
                pass = true;
                timer1.Stop();
                f.ShowDialog();
                btn_nextlvl.Visible = true;
            }
        }

        private void labamodificat_Click(object sender, EventArgs e)
        {
            labamodificat.Visible = false;
            dif--;
            lbl_dif.Text = Convert.ToString(dif);
            pct = pct + 5;
            lbl_pct.Text = Convert.ToString(pct);
            if (dif == 0)
            {
                
                pass = true;
                timer1.Stop();
                f.ShowDialog();
                btn_nextlvl.Visible = true;
            }
        }

        private void btn_iesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Visible = false;
            AlegeJocul f = new AlegeJocul();
            f.ShowDialog();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            dif = 3;
            timp = 100;
            pass = false;
            pct = pct_baza;
            gulerroz.Visible = true;
            labamodificat.Visible = true;
            dungamodificat.Visible = true;
            progressBar1.Value = timp;
            lbl_dif.Text = Convert.ToString(dif);
            lbl_pct.Text = Convert.ToString(pct);
            timer1.Start();
        }

        private void btn_nextlvl_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 f = new Form5();
            f.ShowDialog();
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

                    btn_nextlvl.Visible = false;
                    g.ShowDialog();
                }
        }
    }
}
