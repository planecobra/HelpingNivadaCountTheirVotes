using System;
using System.Windows.Forms;

namespace Advanced_voter_system
{
    public partial class Form1 : Form
    {
        public static int VotesForBiden = 0;
        public static int VotesForTrump = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VotesForBiden++;
            label5.Text = Convert.ToString(VotesForBiden);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VotesForBiden--;
            label5.Text = Convert.ToString(VotesForBiden);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VotesForTrump++;
            label2.Text = Convert.ToString(VotesForTrump);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VotesForTrump--;
            label2.Text = Convert.ToString(VotesForTrump);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = Convert.ToString(VotesForBiden);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = Convert.ToString(VotesForTrump);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VotesForBiden = VotesForBiden + 1000;
            label5.Text = Convert.ToString(VotesForBiden);
        }
    }
}
