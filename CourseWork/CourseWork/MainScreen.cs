using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class MainScreen : Form
    {
        HighScoreForms hSscreen = new HighScoreForms();
        GameItself game = new GameItself();
        public MainScreen()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HighScore_Click(object sender, EventArgs e)
        {
            hSscreen.FormClosed += HS_closed;
            hSscreen.Show();
            this.Hide();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            game.FormClosed += game_FormClosed;
            game.Show();
            this.Hide();
        }
       
        private void game_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            if (game.GetWinnerName() != "")
            {
                string winner = game.GetWinnerName();
                hSscreen.IncreasHS(winner);
            }
            Application.Restart();
            Environment.Exit(0);
        }
        private void HS_closed(object sender, FormClosedEventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
