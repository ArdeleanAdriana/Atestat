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
    public partial class Matches : Form
    {
        public Matches()
        {
            
            InitializeComponent();
            label1.BackColor = Color.PaleTurquoise;
            btn_gata2.Visible = false;
            btn_gata1.Visible = false;
        }
        int k = 16, nr = 1, aleg = 0;

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (aleg == 0 || aleg == 2)
            {
                if (aleg == 0 || aleg == 2)
                {
                    aleg = 2;
                    if (k == 1 && nr % 2 == 0)
                    {
                        Jucatorul1 f = new Jucatorul1();
                        f.ShowDialog();
                        //this.Hide();
                    }
                    else
                        if (k == 1 && nr % 2 != 0)
                    {
                        Jucatorul2 f = new Jucatorul2();
                        f.ShowDialog();
                        //this.Hide();
                    }
                    k--;

                    pictureBox3.Visible = false;
                    if (nr % 2 != 0)
                        btn_gata1.Visible = true;
                    else
                        btn_gata2.Visible = true;
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
                if (aleg == 0 || aleg == 2)
                {
                    aleg = 2;
                    if (k == 1 && nr % 2 == 0)
                {
                    Jucatorul1 f = new Jucatorul1();
                    f.ShowDialog();
                    //this.Hide();
                }
                else
                        if (k == 1 && nr % 2 != 0)
                {
                    Jucatorul2 f = new Jucatorul2();
                    f.ShowDialog();
                    //this.Hide();
                }
                k--;

                    pictureBox4.Visible = false;
                    if (nr % 2 != 0)
                        btn_gata1.Visible = true;
                    else
                        btn_gata2.Visible = true;
                }
            }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (aleg == 0 || aleg == 3)
            {
                aleg = 3;
                if (k == 1 && nr % 2 == 0)
                {
                    Jucatorul1 f = new Jucatorul1();
                    f.ShowDialog();
                    //this.Hide();
                }
                else
                    if (k == 1 && nr % 2 != 0)
                {
                    Jucatorul2 f = new Jucatorul2();
                    f.ShowDialog();
                    //this.Hide();
                }
                k--;

                pictureBox5.Visible = false;
                if (nr % 2 != 0)
                    btn_gata1.Visible = true;
                else
                    btn_gata2.Visible = true;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (aleg == 0 || aleg == 3)
            {
                aleg = 3;
                if (k == 1 && nr % 2 == 0)
                {
                    Jucatorul1 f = new Jucatorul1();
                    f.ShowDialog();
                    //this.Hide();
                }
                else
                    if (k == 1 && nr % 2 != 0)
                {
                    Jucatorul2 f = new Jucatorul2();
                    f.ShowDialog();
                    //this.Hide();
                }
                k--;

                pictureBox6.Visible = false;
                if (nr % 2 != 0)
                    btn_gata1.Visible = true;
                else
                    btn_gata2.Visible = true;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (aleg == 0 || aleg == 3)
            {
                aleg = 3;
                if (k == 1 && nr % 2 == 0)
                {
                    Jucatorul1 f = new Jucatorul1();
                    f.ShowDialog();
                    //this.Hide();
                }
                else
                    if (k == 1 && nr % 2 != 0)
                {
                    Jucatorul2 f = new Jucatorul2();
                    f.ShowDialog();
                    //this.Hide();
                }
                k--;

                pictureBox7.Visible = false;
                if (nr % 2 != 0)
                    btn_gata1.Visible = true;
                else
                    btn_gata2.Visible = true;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (aleg == 0 || aleg == 3)
            {
                aleg = 3;
                if (k == 1 && nr % 2 == 0)
                {
                    Jucatorul1 f = new Jucatorul1();
                    f.ShowDialog();
                    //this.Hide();
                }
                else
                    if (k == 1 && nr % 2 != 0)
                {
                    Jucatorul2 f = new Jucatorul2();
                    f.ShowDialog();
                    //this.Hide();
                }
                k--;

                pictureBox8.Visible = false;
                if (nr % 2 != 0)
                    btn_gata1.Visible = true;
                else
                    btn_gata2.Visible = true;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (aleg == 0 || aleg == 3)
            {
                aleg = 3;
                if (k == 1 && nr % 2 == 0)
                {
                    Jucatorul1 f = new Jucatorul1();
                    f.ShowDialog();
                    //this.Hide();
                }
                else
                    if (k == 1 && nr % 2 != 0)
                {
                    Jucatorul2 f = new Jucatorul2();
                    f.ShowDialog();
                    //this.Hide();
                }
                k--;

                pictureBox9.Visible = false;
                if (nr % 2 != 0)
                    btn_gata1.Visible = true;
                else
                    btn_gata2.Visible = true;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (aleg == 0 || aleg == 4)
            {
                aleg = 4;
                if (k == 1 && nr % 2 == 0)
                {
                    Jucatorul1 f = new Jucatorul1();
                    f.ShowDialog();
                    //this.Hide();
                }
                else
                    if (k == 1 && nr % 2 != 0)
                {
                    Jucatorul2 f = new Jucatorul2();
                    f.ShowDialog();
                    //this.Hide();
                }
                k--;

                pictureBox10.Visible = false;
                if (nr % 2 != 0)
                    btn_gata1.Visible = true;
                else
                    btn_gata2.Visible = true;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (aleg == 0 || aleg == 4)
            {
                aleg = 4;
                if (k == 1 && nr % 2 == 0)
                {
                    Jucatorul1 f = new Jucatorul1();
                    f.ShowDialog();
                    //this.Hide();
                }
                else
                    if (k == 1 && nr % 2 != 0)
                {
                    Jucatorul2 f = new Jucatorul2();
                    f.ShowDialog();
                    //this.Hide();
                }
                k--;

                pictureBox11.Visible = false;
                if (nr % 2 != 0)
                    btn_gata1.Visible = true;
                else
                    btn_gata2.Visible = true;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (aleg == 0 || aleg == 4)
            {
                aleg = 4;
                if (k == 1 && nr % 2 == 0)
                {
                    Jucatorul1 f = new Jucatorul1();
                    f.ShowDialog();
                    //this.Hide();
                }
                else
                    if (k == 1 && nr % 2 != 0)
                {
                    Jucatorul2 f = new Jucatorul2();
                    f.ShowDialog();
                    //this.Hide();
                }
                k--;

                pictureBox12.Visible = false;
                if (nr % 2 != 0)
                    btn_gata1.Visible = true;
                else
                    btn_gata2.Visible = true;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (aleg == 0 || aleg == 4)
            {
                aleg = 4;
                if (k == 1 && nr % 2 == 0)
                {
                    Jucatorul1 f = new Jucatorul1();
                    f.ShowDialog();
                    //this.Hide();
                }
                else
                    if (k == 1 && nr % 2 != 0)
                {
                    Jucatorul2 f = new Jucatorul2();
                    f.ShowDialog();
                    //this.Hide();
                }
                k--;

                pictureBox13.Visible = false;
                if (nr % 2 != 0)
                    btn_gata1.Visible = true;
                else
                    btn_gata2.Visible = true;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (aleg == 0 || aleg == 4)
            {
                aleg = 4;
                if (k == 1 && nr % 2 == 0)
                {
                    Jucatorul1 f = new Jucatorul1();
                    f.ShowDialog();
                   // this.Hide();
                }
                else
                    if (k == 1 && nr % 2 != 0)
                {
                    Jucatorul2 f = new Jucatorul2();
                    f.ShowDialog();
                    //this.Hide();
                }
                k--;

                pictureBox14.Visible = false;
                if (nr % 2 != 0)
                    btn_gata1.Visible = true;
                else
                    btn_gata2.Visible = true;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (aleg == 0 || aleg == 4)
            {
                aleg = 4;
                if (k == 1 && nr % 2 == 0)
                {
                    Jucatorul1 f = new Jucatorul1();
                    f.ShowDialog();
                    //this.Hide();
                }
                else
                    if (k == 1 && nr % 2 != 0)
                {
                    Jucatorul2 f = new Jucatorul2();
                    f.ShowDialog();
                    //this.Hide();
                }
                k--;

                pictureBox15.Visible = false;
                if (nr % 2 != 0)
                    btn_gata1.Visible = true;
                else
                    btn_gata2.Visible = true;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (aleg == 0 || aleg == 4)
            {
                aleg = 4;
                if (k == 1 && nr % 2 == 0)
                {
                    Jucatorul1 f = new Jucatorul1();
                    f.ShowDialog();
                    //this.Hide();
                }
                else
                    if (k == 1 && nr % 2 != 0)
                {
                    Jucatorul2 f = new Jucatorul2();
                    f.ShowDialog();
                    //this.Hide();
                }
                k--;

                pictureBox16.Visible = false;
                if (nr % 2 != 0)
                    btn_gata1.Visible = true;
                else
                    btn_gata2.Visible = true;
            }
        }

        private void btn_gata1_Click(object sender, EventArgs e)
        {
            label1.BackColor = Color.DarkOrange;
            label2.BackColor = Color.PaleTurquoise;
            btn_gata1.Visible = false;
            //btn_gata2.Visible = true;
            nr++;
            aleg = 0;

        }

        private void btn_gata2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.DarkOrange;
            label1.BackColor = Color.PaleTurquoise;
            btn_gata2.Visible = false;
            // btn_gata1.Visible = true;
            nr++;
            aleg = 0;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            k = 16;
            nr = 1;
            aleg = 0;
            label2.BackColor = Color.DarkOrange;
            label1.BackColor = Color.PaleTurquoise;
            btn_gata2.Visible = false;
            btn_gata1.Visible = false;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Visible = false;
            AlegeJocul f = new AlegeJocul();
            f.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (aleg == 0 || aleg == 2)
            {
                aleg = 2;
                if (k == 1 && nr % 2 == 0)
                {
                    Jucatorul1 f = new Jucatorul1();
                    f.ShowDialog();
                    //this.Hide();
                }
                else
                    if (k == 1 && nr % 2 != 0)
                {
                    Jucatorul2 f = new Jucatorul2();
                    f.ShowDialog();
                    //this.Hide();
                }
                k--;

                pictureBox2.Visible = false;
                if (nr % 2 != 0)
                    btn_gata1.Visible = true;
                else
                    btn_gata2.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (aleg == 0 || aleg == 1)
            {
                aleg = 1;
                if (k == 1 && nr % 2 == 0)
                {
                    //this.Hide();
                    Jucatorul1 f = new Jucatorul1();
                    f.ShowDialog();
                    //this.Hide();
                }
                else
                    if (k == 1 && nr % 2 != 0)
                {
                    //this.Hide();
                    Jucatorul2 f = new Jucatorul2();
                    f.ShowDialog();
                    
                }
                k--;

                pictureBox1.Visible = false;
                if (nr % 2 != 0)
                    btn_gata1.Visible = true;
                else
                    btn_gata2.Visible = true;
            }
        }
    }
}
