using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    internal class Board
    {
        private char[,] gameboard = { { '\0', '\0', '\0' }, { '\0', '\0', '\0' }, { '\0', '\0', '\0' } };
        private int num_turns = 0;
        public void EnterTurn(int row, int column, char turn)
        {    
            gameboard[row, column] = turn;
            num_turns++;
        }
        public bool IsEmpty(int row, int column)
        {
            if (gameboard[row, column] == '\0')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsWinner(char player)
        {
            bool winner = false;
            if ((gameboard[0, 0] == player) && (gameboard[0, 1] == player) && (gameboard[0, 2] == player))
            {
                winner = true;
            }
            else if ((gameboard[1, 0] == player) && (gameboard[1, 1] == player) && (gameboard[1, 2] == player))
            {
                winner = true;
            }
            else if ((gameboard[2, 0] == player) && (gameboard[2, 1] == player) && (gameboard[2, 2] == player))
            {
                winner = true;
            }
            else if ((gameboard[0, 0] == player) && (gameboard[1, 0] == player) && (gameboard[2, 0] == player))
            {
                winner = true;
            }
            else if ((gameboard[0, 2] == player) && (gameboard[1, 2] == player) && (gameboard[2, 2] == player))
            {
                winner = true;
            }
            else if ((gameboard[0, 1] == player) && (gameboard[1, 1] == player) && (gameboard[2, 1] == player))
            {
                winner = true;
            }
            else if ((gameboard[0, 0] == player) && (gameboard[1, 0] == player) && (gameboard[2, 0] == player))
            {
                winner = true;
            }
            else if ((gameboard[0, 2] == player) && (gameboard[1, 2] == player) && (gameboard[2, 2] == player))
            {
                winner = true;
            }
            else if ((gameboard[0, 0] == player) && (gameboard[1, 1] == player) && (gameboard[2, 2] == player))
            {
                winner = true;
            }
            else if ((gameboard[0, 2] == player) && (gameboard[1, 1] == player) && (gameboard[2, 0] == player))
            {
                winner = true;
            }
            return winner;
        }
        public bool Draw()
        {
            if(num_turns == 9)
            {
                if (IsWinner('X') == false)
                {
                    if (IsWinner('O') == false)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
