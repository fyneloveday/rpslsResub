using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI : Player
    {
        public AI()
        {
            userName = "Omega";
        }

        public override void SetName()
        {

        }

        public override void DisplayName()
        {
            Console.WriteLine("\nWelcome to the game " + userName);
        }


        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);

        }

        public override void ChooseMove()
        {
            Random random = new Random();
            userMove = playerHand[random.Next(0, playerHand.Count)];
            Console.WriteLine("\n" + userName + " Has Decided To Throw: " + userMove);

        }

        

    }

}
