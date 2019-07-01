using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        public Human()
        {

        }
        public override void SetName()
        {
            Console.WriteLine("Please enter your name.");
            string userInput = Console.ReadLine().ToUpper();
            userName = userInput;
        }

        public override void DisplayName()
        {
            Console.WriteLine("\nWelcome to the game " + userName);
        }


        public override void ChooseMove()
        {
            Console.WriteLine("Please Choose Your Move. Type 1 for Rock, 2 for Paper, 3 for Scissors, 4 for Lizard, and 5 for Spock");
            userMove = Console.ReadLine();
            switch (userMove)
            {
                case "1":
                    userMove = playerHand[(0)];
                    Console.WriteLine("\n" + userName + " Has Decided To Throw: " + userMove);
                    break;

                case "2":
                    userMove = playerHand[(1)];
                    Console.WriteLine("\n" + userName + " Has Decided To Throw: " + userMove);
                    break;

                case "3":
                    userMove = playerHand[(2)];
                    Console.WriteLine("\n" + userName + " Has Decided To Throw: " + userMove);
                    break;

                case "4":
                    userMove = playerHand[(3)];
                    Console.WriteLine("\n" + userName + " Has Decided To Throw: " + userMove);
                    break;

                case "5":
                    userMove = playerHand[(4)];
                    Console.WriteLine("\n" + userName + " Has Decided To Throw: " + userMove);
                    break;

                default:
                    Console.WriteLine("\nPlease Try again");
                    ChooseMove();
                    break;
            }
        }


    }
}
