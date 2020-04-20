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
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Here you can get your training score!");
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
     
        }
        private void Score_Text()
        {
            
                string wins = textBox1.Text;
                float Wins = float.Parse(wins);
                string matches = textBox2.Text;
                float Matches = float.Parse(matches);
                string defeats = textBox3.Text;
                float Defeats = float.Parse(defeats);
            
            if (Matches != Wins + Defeats)
            {
                MessageBox.Show("Type your wins losses and matches in again.");
            }
            else
            {
                float Score = ((Wins * 10) - (Defeats * -2)) / Matches;
                MessageBox.Show("Here is your Score: " + Score.ToString());
            }
                        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Score_Text();
        }
    }
}
