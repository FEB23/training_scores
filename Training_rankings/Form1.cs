using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Training_rankings
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            Training_rankings.Communication Komm = new Training_rankings.Communication();
            InitializeComponent();
            
            richTextBox2.Text = DateTime.Now.ToString();
            label8.Text = Komm.FencerName.ToString();
        }

        private void Score_Text()
        {
            Training_rankings.Communication Komm = new Training_rankings.Communication();
            string Name = richTextBox1.Text.ToString();
            string wins = textBox1.Text;
            float Wins = float.Parse(wins);
            string matches = textBox2.Text;
            float Matches = float.Parse(matches);
            string defeats = textBox3.Text;
            float Defeats = float.Parse(defeats);

            if (Matches != Wins + Defeats )
            {

                MessageBox.Show("Type your wins losses and matches in again.");
            }
            else
            {
                float Score = ((Wins * 10) - (Defeats * -2)) / Matches;
                textBox4.Text = Score.ToString();
                MessageBox.Show(Name + " here is your Score: " + Score.ToString());
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Score_Text();
            
        }
               
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
