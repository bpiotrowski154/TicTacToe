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
        public bool GameDone = false;


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
            for (var i = 0; i < 3; i++)
            {
                //if The first cell in row is not empty
                if (!String.IsNullOrWhiteSpace(Board[0, i]))
                {
                    //If first cell = second cell and first cell ==  third cell
                    if (Board[0, i] == Board[1, i] && Board[0, i] == Board[2, i])
                    {
                        GameDone = true;
                        return true;
                    }
                
                }
            }

            //Check the columns
            for (var i = 0; i < 3; i++)
            {
                if (!String.IsNullOrWhiteSpace(Board[i, 0]))
                {
                    if (Board[i, 0] == Board[i, 1] && Board[i, 1] == Board[i, 2])
                    {
                        GameDone = true;
                        return true;
                    }
                }
            }

            //Check diagonals
            if (!String.IsNullOrWhiteSpace(Board[0, 0]))
            {
                if (Board[0, 0] == Board[1, 1] && Board[0, 0] == Board[2, 2])
                {
                    GameDone = true;
                    return true;
                }
            }
            if (!String.IsNullOrWhiteSpace(Board[0, 2]))
            {
                if (Board[0, 2] == Board[1, 1] && Board[0, 2] == Board[2, 0])
                {
                    GameDone = true;
                    return true;
                }
            }

            return false;
        }

        //Updates the Board array
        internal void UpdateBoard(Position position, string value)
        {
            Board[position.x, position.y] = value;
        }
    }
}
