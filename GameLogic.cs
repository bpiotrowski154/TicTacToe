using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class GameLogic
    {

        //String member variable initialized to X player
        public string CurrentPlayer { get; set; } = x;
        private const string x = "X";
        private const string o = "O";
        private string[,] Board = new string[3, 3];


        //Checks current player and then swaps to the next player to change turns
        public void SetNextPlayer()
        {
            if (CurrentPlayer == x)
            {
                CurrentPlayer = o;
            }
            else
            {
                CurrentPlayer = x;
            }
        }

        public bool PlayerWin()
        {
            //Check horizontal row
            for(var i = 0; i < 3; i++)
            {
                //if The first cell is not empty
                if (!String.IsNullOrWhiteSpace(Board[0, i]))
                {
                    //If first cell = second cell and first cell ==  third cell
                    if (Board[0, i] == Board[1, i] && Board[0, i] == Board[2, i])
                        return true;
                }
            }

            //Check the columns


            //Check diagonals


            return false;
        }

        //Updates the Board array
        internal void UpdateBoard(Position position, string value)
        {
            Board[position.x, position.y] = value;
        }
    }
}
