using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        public string userName;
        public string userMove;
        public List<string> playerHand;
        public int score;



        public Player()
        {
            playerHand = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }

        //public List <string>[] playerMoves = new string[]

        //{
        //    "Rock",
        //    "Paper",
        //    "Scissors",
        //    "Lizard",
        //    "Spock",
        //};


        

        public abstract void SetName();
        public abstract void DisplayName();
        public abstract void ChooseMove();


    }
}
