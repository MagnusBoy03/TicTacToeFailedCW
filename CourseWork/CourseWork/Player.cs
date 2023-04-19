using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{   
    class Player
    {
        private char role;
        public Player(char new_role) 
        {
            Role = new_role;
        }
        public char Role { get { return this.role; } set { this.role = value; } }
        public virtual int Row(int row)
        {
            return row;
        }
        public virtual int Column(int column)
        {
            return column;
        }
    }
    class AI : Player
    {
        Random rnd = new Random();

        public AI(char new_role) : base(new_role){}

        public override int Row(int row)
        {
            row = rnd.Next(0, 2);
            return row;
        }
        public override int Column(int column)
        {
            column = rnd.Next(0, 2);
            return column;
        }
    }
    class RealPlayer : Player 
    {
        private string name;
        public RealPlayer(string name, char new_role) : base(new_role)
        {
            Name = name;
        }
        public string Name{ get { return this.name; } set { this.name = value; } }
    }
    
}
