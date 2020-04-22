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
    public partial class StartBox : Form
    {
        public string fencer_Name;
        public StartBox()
        {
            InitializeComponent();
           
    }
        private void button1_Click(object sender, EventArgs e)
        {
            Training_rankings.Form1 Main = new Training_rankings.Form1();
            Training_rankings.Communication Komm = new Training_rankings.Communication();
            fencer_Name = textBox1.Text.ToString();
            Main.Show();
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
