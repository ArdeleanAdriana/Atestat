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
    public partial class MemoryGame : Form
    {
        Random random = new Random();

        List<string> icons = new List<string>()
        {
            //"!","!","N","N",",",",","k","k","b","b","v","v","w","w","z","z"
            "o","o","L","L","m","m","Z","Z","b","b","e","e","j","j","Y","Y"
        };

        Label firstClicked, secondClicked;
        public MemoryGame()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }
        private void AssignIconsToSquares()
        {
            Label label;
            int randomNumber;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else
                    continue;

                randomNumber = random.Next(0, icons.Count);
                label.Text = icons[randomNumber];
                icons.RemoveAt(randomNumber);
            }
        }
        int timp = 100;
        Castig h = new Castig();
        Pierdut g = new Pierdut();

        
        private void CheckForWinner()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;
                if (label != null && label.ForeColor == label.BackColor)
                    return;
            }
            timer2.Stop();
            
            h.ShowDialog();
            //MessageBox.Show("Ati castigat! :)");
            //Close();
            //Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void label_Click(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
                return;
            Label clickedLabel = sender as Label;
            if (clickedLabel == null)
                return;
            if (clickedLabel.ForeColor == Color.Maroon)
                return;
            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Maroon;
                return;
            }
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Maroon;

            CheckForWinner();

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
                timer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            AlegeJocul f = new AlegeJocul();
            f.ShowDialog();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = timp;
            timp--;
            if (timp == 0)
            {
                timer2.Stop();
                g.ShowDialog();
            }
        }

        

    }
}
