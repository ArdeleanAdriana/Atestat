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
    public partial class TTT : Form
    {
        public TTT()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
        }


        int clic = 1;
        int ok1 = 0, ok2 = 0, ok3 = 0, ok4 = 0, ok5 = 0, ok6 = 0, ok7 = 0, ok8 = 0, ok9 = 0;
        bool end = false;
        private void label7_Click(object sender, EventArgs e)
        {
            if (clic % 2 == 0 && ok7 == 0 && end==false )
            {
                clic++;
                order.Text = "1";
                label7.Text = "0";
                ok7 = 1;
                if ((ok7 == ok8 && ok8 == ok9) || (ok3 == ok5 && ok5 == ok7) || (ok1 == ok4 && ok4 == ok7))
                {
                    //MessageBox.Show("Player 2 won!");
                    end = true;
                    g2.ShowDialog();
                   
                }
            }
            else
                if (clic % 2 != 0 && ok7 == 0 && end == false)
            {
                clic++;
                order.Text = "2";
                label7.Text = "X";
                ok7 = 2;
                if ((ok7 == ok8 && ok8 == ok9) || (ok3 == ok5 && ok5 == ok7) || (ok1 == ok4 && ok4 == ok7))
                {
                    end = true;
                    //MessageBox.Show("Player 1 won!");
                    g1.ShowDialog();
                    
                }
            }
            if (ok1 != 0 && ok2 != 0 && ok3 != 0 && ok4 != 0 && ok5 != 0 && ok6 != 0 && ok7 != 0 && ok8 != 0 && ok9 != 0 && end == false)
                g.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            if (clic % 2 == 0 && ok8 == 0 && end == false)
            {
                clic++;
                order.Text = "1";
                label8.Text = "0";
                ok8 = 1;
                if ((ok7 == ok8 && ok8 == ok9) || (ok2 == ok5 && ok5 == ok8))
                {
                    end = true;
                    //MessageBox.Show("Player 2 won!");
                    g2.ShowDialog();
                 
                }
            }
            else
                if (clic % 2 != 0 && ok8 == 0 && end == false)
            {
                clic++;
                order.Text = "2";
                label8.Text = "X";
                ok8 = 2;
                if ((ok7 == ok8 && ok8 == ok9) || (ok2 == ok5 && ok5 == ok8))
                {
                    end = true;
                    //MessageBox.Show("Player 1 won!");
                    g1.ShowDialog();
              
                }
            }
            if (ok1 != 0 && ok2 != 0 && ok3 != 0 && ok4 != 0 && ok5 != 0 && ok6 != 0 && ok7 != 0 && ok8 != 0 && ok9 != 0 && end == false)
                g.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            if (clic % 2 == 0 && ok9 == 0 && end == false)
            {
                clic++;
                order.Text = "1";
                label9.Text = "0";
                ok9 = 1;
                if ((ok7 == ok8 && ok8 == ok9) || (ok1 == ok5 && ok5 == ok9) || (ok3 == ok6 && ok6 == ok9))
                {
                    end = true;
                    //MessageBox.Show("Player 2 won!");
                    g2.ShowDialog();
                  
                }
            }
            else
               if (clic % 2 != 0 && ok9 == 0 && end == false)
            {
                clic++;
                order.Text = "2";
                label9.Text = "X";
                ok9 = 2;
                if ((ok7 == ok8 && ok8 == ok9) || (ok1 == ok5 && ok5 == ok9) || (ok3 == ok6 && ok6 == ok9))
                {
                    end = true;
                    //MessageBox.Show("Player 1 won!");
                    g1.ShowDialog();
               
                }
            }
            if (ok1 != 0 && ok2 != 0 && ok3 != 0 && ok4 != 0 && ok5 != 0 && ok6 != 0 && ok7 != 0 && ok8 != 0 && ok9 != 0 && end == false)
                g.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            order.Text = "1";
            clic = 1;
            end = false;
            ok1 = 0; ok2 = 0; ok3 = 0; ok4 = 0; ok5 = 0; ok6 = 0; ok7 = 0; ok8 = 0; ok9 = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AlegeJocul f = new AlegeJocul();
            f.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (clic % 2 == 0 && ok6 == 0 && end == false)
            {
                clic++;
                order.Text = "1";
                label6.Text = "0";
                ok6 = 1;
                if ((ok4 == ok5 && ok5 == ok6) || (ok3 == ok6 && ok6 == ok9))
                {
                    end = true;
                    //MessageBox.Show("Player 2 won!");
                    g2.ShowDialog();
                }
            }
            else
                if (clic % 2 != 0 && ok6 == 0 && end == false)
            {
                clic++;
                order.Text = "2";
                label6.Text = "X";
                ok6 = 2;
                if ((ok4 == ok5 && ok5 == ok6) || (ok3 == ok6 && ok6 == ok9))
                {
                    end = true;
                    //MessageBox.Show("Player 1 won!");
                    g1.ShowDialog();
                 
                }
            }
            if (ok1 != 0 && ok2 != 0 && ok3 != 0 && ok4 != 0 && ok5 != 0 && ok6 != 0 && ok7 != 0 && ok8 != 0 && ok9 != 0&& end==false)
                g.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (clic % 2 == 0 && ok5 == 0 && end == false)
            {
                clic++;
                order.Text = "1";
                label5.Text = "0";
                ok5 = 1;
                if ((ok5 == ok4 && ok4 == ok6) || (ok1 == ok5 && ok5 == ok9) || (ok5 == ok2 && ok2 == ok8))
                {
                    end = true;
                    //MessageBox.Show("Player 2 won!");
                    g2.ShowDialog();
                 
                }
            }
            else
               if (clic % 2 != 0 && ok5 == 0 && end == false)
            {
                clic++;
                order.Text = "2";
                label5.Text = "X";
                ok5 = 2;
                if ((ok5 == ok4 && ok4 == ok6) || (ok1 == ok5 && ok5 == ok9) || (ok5 == ok2 && ok2 == ok8))
                {
                    end = true;
                    //MessageBox.Show("Player 1 won!");
                    g1.ShowDialog();
                    
                }
            }
            if (ok1 != 0 && ok2 != 0 && ok3 != 0 && ok4 != 0 && ok5 != 0 && ok6 != 0 && ok7 != 0 && ok8 != 0 && ok9 != 0 && end == false)
                g.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (clic % 2 == 0 && ok4 == 0 && end == false)
            {
                clic++;
                order.Text = "1";
                label4.Text = "0";
                ok4 = 1;
                if ((ok4 == ok5 && ok5 == ok6) || (ok4 == ok1 && ok4 == ok7))
                {
                    end = true;
                    //MessageBox.Show("Player 2 won!");
                    g2.ShowDialog();
                    
                }
            }
            else
               if (clic % 2 != 0 && ok4 == 0 && end == false)
            {
                clic++;
                order.Text = "2";
                label4.Text = "X";
                ok4 = 2;
                if ((ok4 == ok5 && ok5 == ok6) || (ok4 == ok1 && ok4 == ok7))
                {
                    end = true;
                    //MessageBox.Show("Player 1 won!");
                    g1.ShowDialog();
                }
            }
            if (ok1 != 0 && ok2 != 0 && ok3 != 0 && ok4 != 0 && ok5 != 0 && ok6 != 0 && ok7 != 0 && ok8 != 0 && ok9 != 0 && end == false)
                g.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (clic % 2 == 0 && ok3 == 0 && end == false)
            {
                clic++;
                order.Text = "1";
                label3.Text = "0";
                ok3 = 1;
                if ((ok1 == ok2 && ok2 == ok3) || (ok3 == ok5 && ok5 == ok7) || (ok3 == ok6 && ok6 == ok9))
                {
                    end = true;
                    //MessageBox.Show("Player 2 won!");
                    g2.ShowDialog();
                }
            }
            else
                if (clic % 2 != 0 && ok3 == 0 && end == false)
            {
                clic++;
                order.Text = "2";
                label3.Text = "X";
                ok3 = 2;
                if ((ok1 == ok2 && ok2 == ok3) || (ok3 == ok5 && ok5 == ok7) || (ok3 == ok6 && ok6 == ok9))
                {
                    end = true;
                    //MessageBox.Show("Player 1 won!");
                    g1.ShowDialog();
                }

            }
            if (ok1 != 0 && ok2 != 0 && ok3 != 0 && ok4 != 0 && ok5 != 0 && ok6 != 0 && ok7 != 0 && ok8 != 0 && ok9 != 0 && end == false)
                g.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (clic % 2 == 0 && ok2 == 0 && end == false)
            {
                clic++;
                order.Text = "1";
                label2.Text = "0";
                ok2 = 1;
                if ((ok1 == ok2 && ok2 == ok3 && ok1 == ok3) || (ok2 == ok5 && ok5 == ok8 && ok2 == ok8))
                {
                    end = true;
                    //MessageBox.Show("Player 2 won!");
                    g2.ShowDialog();
                }
            }
            else
                if (clic % 2 != 0 && ok2 == 0 && end == false)
            {
                clic++;
                order.Text = "2";
                label2.Text = "X";
                ok2 = 2;
                if ((ok1 == ok2 && ok2 == ok3) || (ok2 == ok5 && ok5 == ok8))
                {
                    end = true;
                    //MessageBox.Show("Player 1 won!");
                    g1.ShowDialog();
                }
            }
            if (ok1 != 0 && ok2 != 0 && ok3 != 0 && ok4 != 0 && ok5 != 0 && ok6 != 0 && ok7 != 0 && ok8 != 0 && ok9 != 0 && end == false)
                g.ShowDialog();

        }

        private void label1_Click(object sender, EventArgs e)
        {

            if (clic % 2 == 0 && ok1 == 0 && end == false)
            {
                clic++;
                order.Text = "1";
                label1.Text = "0";
                ok1 = 1;
                if ((ok1 == ok2 && ok2 == ok3) || (ok1 == ok5 && ok5 == ok9) || (ok1 == ok4 && ok4 == ok7))
                {
                    end = true;
                    //MessageBox.Show("Player 2 won!");
                    g2.ShowDialog();
                }
            }
            else
                if (clic % 2 != 0 && ok1 == 0 && end == false)
            {
                clic++;
                order.Text = "2";
                label1.Text = "X";
                ok1 = 2;
                if ((ok1 == ok2 && ok2 == ok3) || (ok1 == ok5 && ok5 == ok9) || (ok1 == ok4 && ok4 == ok7))
                {
                    end = true;
                    //MessageBox.Show("Player 1 won!");
                    g1.ShowDialog();
                }
            }
            if (ok1 != 0 && ok2 != 0 && ok3 != 0 && ok4 != 0 && ok5 != 0 && ok6 != 0 && ok7 != 0 && ok8 != 0 && ok9 != 0 && end == false)
                g.ShowDialog();
        }

        Jucatorul1 g1 = new Jucatorul1();
        Jucatorul2 g2 = new Jucatorul2();
        Remiza g = new Remiza();


    }
}
