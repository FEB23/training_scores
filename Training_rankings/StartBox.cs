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
        Training_rankings.Communication Komm = new Training_rankings.Communication();
        public string fencer_Name = "";
        public StartBox()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            
            Training_rankings.Communication Com = new Training_rankings.Communication();
            fencer_Name = textBox1.Text.ToString();
            Com.setfencerName = fencer_Name;
            Training_rankings.Form1 Main = new Training_rankings.Form1();
            Main.Show();
        }

        private void StartBox_Load(object sender, EventArgs e)
        {

        }
    }
}
