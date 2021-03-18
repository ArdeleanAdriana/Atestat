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
    public partial class WhackAMole : Form
    {
        public WhackAMole()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
        }
        Random rnd = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "mole")
                    x.Visible = false;
            }
            int k = rnd.Next(1, 9);
            if (k == 1)
                pictureBox1.Visible = true;
            if (k == 2)
                pictureBox2.Visible = true;
            if (k == 3)
                pictureBox3.Visible = true;
            if (k == 4)
                pictureBox4.Visible = true;
            if (k == 5)
                pictureBox5.Visible = true;
            if (k == 6)
                pictureBox6.Visible = true;
            if (k == 7)
                pictureBox7.Visible = true;
            if (k == 8)
                pictureBox8.Visible = true;
            if (k == 9)
                pictureBox9.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 5);
            pictureBox1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 5);
            pictureBox2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 5);
            pictureBox3.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 5);
            pictureBox4.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 5);
            pictureBox5.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 5);
            pictureBox6.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 5);
            pictureBox7.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 5);
            pictureBox8.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) + 5);
            pictureBox9.Visible = false;
        }

        int i = 60;
        int score;

        private void timer2_Tick(object sender, EventArgs e)
        {
            i--;
            label3.Text = Convert.ToString(i);
            if(i<=10)
            {
                label4.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;
            }
            if (i <= 0)
            {
                timer2.Stop();
                score = Convert.ToInt32(label2.Text);
                if(score>=300)
                    {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    timer1.Stop();
                    timer2.Stop();
                    FelicitariWAM f = new FelicitariWAM();
                    f.ShowDialog();
                    }
                else
                    {
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox9.Visible = false;
                    timer1.Stop();
                    timer2.Stop();
                    EsecWAM g = new EsecWAM();
                    g.ShowDialog();
                    }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            this.Visible = false;
            AlegeJocul f = new AlegeJocul();
            f.ShowDialog();
        }
    }
}
