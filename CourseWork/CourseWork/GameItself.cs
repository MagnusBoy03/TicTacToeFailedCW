using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace CourseWork
{

    public partial class GameItself : Form
    {

        Board gameboard = new Board();
        string name1, name2;
        bool pvp = false;
        int count = 1;
        RealPlayer player1 = new RealPlayer("max", 'X');
        RealPlayer player2 = new RealPlayer("max", 'O');
        AI robot = new AI('O');
        Random rnd = new Random();
        string winner_name = "";
        Dictionary<System.Windows.Forms.Button, Tuple<Label, int, int>> allButtons = new Dictionary<System.Windows.Forms.Button, Tuple<Label, int, int>>();
        public GameItself()

        {
            InitializeComponent();
            this.ControlBox = false;
            System.Windows.Forms.Button[] gameButtons = { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
            Label[] gameLabels = {label1, label2, label3, label4, label5, label6,label7, label8, label9};
            string[] gamePositions = { "0,0", "0,1", "0,2", "1,0", "1,1", "1,2", "2,0", "2,1", "2,2" };
            for(int i=0; i<9; i++)
            {
                allButtons.Add(gameButtons[i], new Tuple<Label, int, int>(gameLabels[i], (int)Char.GetNumericValue((gamePositions[i])[0]), (int)Char.GetNumericValue((gamePositions[i])[2])));
            }

        }
        private void ButtonTurn(System.Windows.Forms.Button button)
        {
            EnterToBoard(allButtons[button].Item2, allButtons[button].Item3);
            Turn(button, allButtons[button].Item1);
            AITurn();
            Draw();
        }
        private void EnterToBoard(int row, int column)
        {
            char temp;
            if (count% 2 == 0) 
            {
                temp = player2.Role;
            }
            else
            {
                temp = player1.Role;
            }
            gameboard.EnterTurn(row, column, temp);
        }

        private void Turn(System.Windows.Forms.Button fun, System.Windows.Forms.Label temp)
        {
            fun.Enabled = false;
            var temp_name = "Computer";
            if (count % 2 == 0)
            {
                if (pvp == true)
                {
                    temp.Text = player2.Role.ToString();
                    temp_name = player2.Name;
                }
                else
                {
                    temp.Text = robot.Role.ToString();
                    
                }
            }
            else
            {
                temp.Text = player1.Role.ToString();
                temp_name= player1.Name;
            }
            temp.Show();
            if(gameboard.IsWinner(Convert.ToChar(temp.Text))) 
            {
                label10.Text = temp_name + " won!";
                winner_name = temp_name;
                label10.Show();
                DisableButtons();
            }
            count++;
        } 
        public string GetWinnerName()
        {
            return winner_name;
        }
        private void AITurn()
        {
            if (pvp == false)
            {
                if ((count % 2 == 0)&& count<9)
                {
                    RandomButton();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ButtonTurn(button1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ButtonTurn(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonTurn(button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonTurn(button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonTurn(button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {

            ButtonTurn(button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            ButtonTurn(button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonTurn(button8);
        }
        

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonTurn(button9);
        }

        private void Draw()
        {
            if(gameboard.Draw() == true)
            {
                label10.Text = "Draw";
                label10.Show();
            }
        }
        private void RandomButton()
        {
            int ai_random = rnd.Next(1, 9);
            for (int i = 0; i < 9; i++) {
                if (ai_random == i)
                {
                    if (gameboard.IsEmpty(allButtons[allButtons.ElementAt(i).Key].Item2, allButtons[allButtons.ElementAt(i).Key].Item3))
                    {
                        EnterToBoard(allButtons[allButtons.ElementAt(i).Key].Item2, allButtons[allButtons.ElementAt(i).Key].Item3);
                        Turn(allButtons.ElementAt(i).Key, allButtons[allButtons.ElementAt(i).Key].Item1);
                    }
                    else
                    {
                        RandomButton();
                        break;
                    }
                    }
                }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PVP.Hide();
            PVE.Hide();
            ShowButtons();
            Player1Text.Show();
            PlayerBox1.Show();
            PlayerBox2.Show();
            PlayerText2.Show();
            pvp = true;
        }//PVP

        private void button11_Click(object sender, EventArgs e)
        {
            PVP.Hide();
            PVE.Hide();
            ShowButtons();
            Player1Text.Show();
            PlayerBox1.Show();
           
        }//PVE
        private void ShowButtons()
        {
            for (int i = 0;i < 9; i++) {
                allButtons.ElementAt(i).Key.Show();
            }
        }
        private void EnableButtons()
        {
            for (int i = 0;i < 9; i++) {
                allButtons.ElementAt(i).Key.Enabled = true;
            }
        }
        private void DisableButtons()
        {
            for (int i = 0; i < 9; i++)
            {
                allButtons.ElementAt(i).Key.Enabled = false;
            }
        }
        private void PlayerBox2_TextChanged(object sender, EventArgs e)
        {
            name2 = PlayerBox2.Text;
            if (name2.Contains(' '))
            { 
                player2.Name = name2.Remove(name2.Length - 1, 1);
                PlayerBox2.Text = "";
                PlayerBox2.Hide();
                PlayerText2.Hide();         
                EnableButtons();
            }
        }//2nd Player name

        private void PlayerBox1_TextChanged(object sender, EventArgs e)
        {
            name1 = PlayerBox1.Text;
            if (name1.Contains(' '))
            {
                player1.Name = name1.Remove(name1.Length - 1, 1);
                PlayerBox1.Text = "";
                PlayerBox1.Hide();
                Player1Text.Hide();
                if (pvp == false)
                {
                    EnableButtons();
                }
            }
        }//1st Player name
        private void button10_Click_1(object sender, EventArgs e) //exit
        {
            this.Close();
        }
    }
}
