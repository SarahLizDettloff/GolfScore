using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golf
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        int count = 0;

        public class ScoreCard
        {
            public string Name { get; set; }
            public int Score { get; set; }
        }
        double[,] ScoreCardArray = new double[1, 5];
        public int[,] scores18 = new int[1,19];


        public void playerName(int count)
        {
            
            switch (count)
            {
                case 1:
                    lblPlayer1Name.Text = txtAddPlayer.Text;
                    lblPlayer1NameScore.Text = txtAddPlayer.Text;
                    //Name = new ScoreCard(txtAddPlayer.Text);
                    break;
                case 2:
                    lblPlayer2Name.Text = txtAddPlayer.Text;
                    lblPlayer2NameScore.Text = txtAddPlayer.Text;
                    break;
                case 3:
                    lblPlayer3Name.Text = txtAddPlayer.Text;
                    lblPlayer3NameScore.Text = txtAddPlayer.Text;
                    break;
                case 4:
                    lblPlayer4Name.Text = txtAddPlayer.Text;
                    lblPlayer4NameScore.Text = txtAddPlayer.Text;
                    break;
            }
            
            return;
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            playerName(count += 1);

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        } //cannot change without creating error on the frmMain.Cs[Design]

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void clearArray()
        {
            ScoreCardArray = new double[1, 5];
            scores18 = new int[1,19];
            return;
        }
        public void enterScore()
        {
            scores18 = new int[1, 19]; //set to value, for loop to show count, make sure they collorlate with names
            return;
        }
        public void TotalScore()
        {
            return;
        }
        public void reset()
        {
            txtAddPlayer.Text = "";
            txtHoleNumber.Text = "";
            txtPlayerNumber.Text = "";
            txtStokes.Text = "";
            lblPlayer1Name.Text = "";
            lblPlayer2Name.Text = "";
            lblPlayer3Name.Text = "";
            lblPlayer4Name.Text = "";
            lblPlayer1NameScore.Text = "Player 1 : ";
            lblPlayer2NameScore.Text = "Player 2 : ";
            lblPlayer3NameScore.Text = "Player 3 : ";
            lblPlayer4NameScore.Text = "Player 4 : ";
            count = 0;
            return;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string playerNumber = txtPlayerNumber.Text;
            string points = txtStokes.Text;
            string holeNumber = txtHoleNumber.Text;

               if (playerNumber == "")
            {
                MessageBox.Show("Please enter the player's number", "Input Error");
            }
               if (points == "")
            {
                MessageBox.Show("Please enter the player's stoke amount", "Input Error");
            }
               if (holeNumber == "")
            {
                MessageBox.Show("Please enter the hole number", "Input Error");
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Ready to play miniature golf?\nLets get started!", "Welcome to miniature golf!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
