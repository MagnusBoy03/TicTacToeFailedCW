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
    public partial class HighScoreForms : Form
    {
        HighScore hsthisScreen = new HighScore();
        bool exit = false;
        public HighScoreForms()// Label highscore
        {
            InitializeComponent();
            label2.Text = hsthisScreen.text;
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)//Exit
        {
            this.Close();
        }
        public void IncreasHS(string name)
        {
            hsthisScreen.IncreaseScore(name);
        }//Increase HS
    }
}
