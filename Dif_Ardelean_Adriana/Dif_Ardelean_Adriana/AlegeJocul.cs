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
    public partial class AlegeJocul : Form
    {
        public AlegeJocul()
        {
            InitializeComponent();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MemoryGame f = new MemoryGame();
            f.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            WhackAMole f = new WhackAMole();
            f.ShowDialog();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TTT f = new TTT();
            f.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Matches f = new Matches();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
