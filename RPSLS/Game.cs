using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {

        int wins;
        public int playerOnePoint;
        public int playerTwoPoint;
        Player playerOne;
        Player playerTwo;



        public Game()
        {

        }

        
        // member methods
        public void DisplayRules()
        {
            Console.WriteLine("Welcome To Rock, Paper, Scissors, Lizard, Spock.");
            Console.WriteLine("Here Are The Rules");
            Console.WriteLine("The rules follow the same rules as Rock, Paper, Scissors, except with a few caveats thrown in.");
            Console.WriteLine("Rock beats (or smashes) scissoras as always.");
            Console.WriteLine("Scissors beats (or cuts) paper");
            Console.WriteLine("Paper beats (or covers) rock.");
            Console.WriteLine("Rock also crushes Lizard in addition to smashing scissors.");
            Console.WriteLine("Scissors cuts Lizard in addition to cutting paper.");
            Console.WriteLine("Paper beats (or disproves) Spock in addition to covering Rock");
            Console.WriteLine("Spock beats (or vaporizes) Rock");
            Console.WriteLine("Spock beats (or smashes) Scissors");
            Console.WriteLine("Lizard beats (or poisons) Spock");
            Console.WriteLine("Lizard beats (or eats) Paper.");
            Console.WriteLine("... Good Luck ...");
        }

        public void GetPlayer()           
        {
            //userInput
            Console.WriteLine("How many Players? [1] Human vs AI, [2] Human vs Human");
            string userInput = Console.ReadLine();
            //Console.WriteLine("Please Enter Your Name If You Want To Play");
            if (userInput == "1")
            {
                playerOne = new Human();
                playerTwo = new AI();
                playerOne.SetName();
                playerTwo.DisplayName();
                Console.WriteLine("\n---------- " + playerOne.userName + " ---------- VS ---------- " + playerTwo.userName + " ----------");
            }
            else if (userInput == "2")
            {
                playerOne = new Human();
                playerTwo = new Human();
                playerOne.SetName();
                playerOne.DisplayName();
                playerTwo.SetName();
                playerTwo.DisplayName();
                Console.WriteLine("\n---------- " + playerOne.userName + " ---------- VS ---------- " + playerTwo.userName + " ----------");
            }
            else
            {
                Console.WriteLine("Sorry. Only 2 players per game.");
                GetPlayer();
            }
        }


        public void GameRounds()
        {
            Console.WriteLine("Please Select Length Of Match");
            Console.WriteLine("Enter '3' For Best Of 'THREE' Match");
            Console.WriteLine("Enter '5' For Best Of 'FIVE' Match");
            Console.WriteLine("Enter '7' For Best Of 'SEVEN' Match");
            string matchLength = Console.ReadLine();
            switch (matchLength)
            {
                case "3":
                    wins = 2;
                    Console.WriteLine("This Match Is Set For A Best 2 Out Of 3");
                    break;
                case "5":
                    wins = 3;
                    Console.WriteLine("This Match Is Set For A Best 3 Out Of 5");
                    break;
                case "7":
                    wins = 4;
                    Console.WriteLine("This Match Is Set For A Best 4 Out Of 7");
                    break;
                default:
                    Console.WriteLine("\nPlease Try again");
                    GameRounds();
                    break;
            }
        }


        //public void compareUserMoves(string playerOneMove, string playerTwoMove)
        //{
        //    switch (playerOneMove)
        //    {
        //        case "Rock":
        //            if (playerOneMove == playerTwoMove)
        //            {
        //                Console.WriteLine("Tie");
        //            }
        //            else if (playerTwoMove == "Paper")
        //            {
        //                playerTwo.score++;
        //               Console.WriteLine("Paper Covers Rock! " + playerTwo.userName + "Wins!");
        //            }
        //            else if (playerTwoMove == "Scissors")
        //            {
        //                playerOne.score++;
        //                Console.WriteLine("Rock Smashes Scissors! " + playerOne.userName + "Wins!");
        //            }
        //            else if (playerTwoMove == "Lizard")
        //            { 
        //                playerOne.score++;
        //                Console.WriteLine("Rock Smashes Lizard! " + playerOne.userName + "Wins!");
        //            }
        //            else if (playerTwoMove == "Spock")
        //            {
        //                playerTwo.score++;
        //                Console.WriteLine("Spock Vaporizes Rock! " + playerTwo.userName + "Wins!");
        //            }
        //            break;
        //        case "Paper":
        //            if (playerOneMove == playerTwoMove)
        //            {
        //                Console.WriteLine("Tie!");
        //            }
        //            else if (playerTwoMove == "Rock")
        //            {
        //                playerOne.score++;
        //                Console.WriteLine("Paper Covers Rock! " + playerOne.userName + "Wins!");
        //            }
        //            else if (playerTwoMove == "Scissors")
        //            {
        //                playerTwo.score++;
        //                Console.WriteLine("Scissors Cuts Paper! " + playerTwo.userName + "Wins!");
        //            }
        //            else if (playerTwoMove == "Lizard")
        //            {
        //                playerOne.score++;
        //                Console.WriteLine("Lizard Eats Paper! " + playerOne.userName + "Wins!");
        //            }
        //            else if (playerTwoMove == "Spock")
        //            {
        //                playerTwo.score++;
        //                Console.WriteLine("Spock Vaporizes Paper! " + playerTwo.userName + "Wins!");
        //            }
        //            break;

        //        case "Scissors":
        //            if (playerOneMove == playerTwoMove)
        //            {
        //                Console.WriteLine("Tie!");
        //            }
        //            else if (playerTwoMove == "Rock")
        //            {
        //                playerTwo.score++;
        //                Console.WriteLine("Rock Smashes Scissors! " + playerTwo.userName + "Wins!");
        //            }
        //            else if (playerTwoMove == "Paper")
        //            {
        //                playerOne.score++;
        //                Console.WriteLine("Scissors Cuts Paper! " + playerOne.userName + "Wins!");
        //            }
        //            else if (playerTwoMove == "Lizard")
        //            {
        //                playerOne.score++;
        //                Console.WriteLine("Scissors Cuts Lizard! " + playerOne.userName + "Wins!");
        //            }
        //            else if (playerTwoMove == "Spock")
        //            {
        //                playerTwo.score++;
        //                Console.WriteLine("Spock Smashes Scissors! " + playerTwo.userName + "Wins!");
        //            }

        //            break;
        //        case "Lizard":
        //            if (playerOneMove == playerTwoMove)
        //            {
        //                Console.WriteLine("Tie!");
        //            }
        //            else if (playerTwoMove == "Rock")
        //            {
        //                playerTwo.score++;
        //                Console.WriteLine("Rock Smashes Lizard! " + playerTwo.userName + "Wins!");
        //            }
        //            else if (playerTwoMove == "Paper")
        //            {
        //                playerOne.score++;
        //                Console.WriteLine("Lizard Eats Paper! " + playerOne.userName + "Wins!");
        //            }
        //            else if (playerTwoMove == "Scissors")
        //            {
        //                playerTwo.score++;
        //                Console.WriteLine("Scissors Cuts Lizard! " + playerTwo.userName + "Wins!");
        //            }
        //            else if (playerTwoMove == "Spock")
        //            {
        //                playerOne.score++;
        //                Console.WriteLine("Lizard Poisons Spock! " + playerOne.userName + "Wins!");
        //            }

        //            break;
        //        case "Spock":
        //            if (playerOneMove == playerTwoMove)
        //            {
        //                Console.WriteLine("Tie!");
        //            }
        //            else if (playerTwoMove == "Rock")
        //            {
        //                playerOne.score++;
        //                Console.WriteLine("Spock Vaporizes Rock! " + playerOne.userName + "Wins!");
        //            }
        //            else if (playerTwoMove == "Paper")
        //            {
        //                playerTwo.score++;
        //                Console.WriteLine("Paper Disproves Spock! " + playerTwo.userName + "Wins!");
        //            }
        //            else if (playerTwoMove == "Scissors")
        //            {
        //                playerOne.score++;
        //                Console.WriteLine("Spock Smashes Scissors! " + playerOne.userName + "Wins!");
        //            }
        //            else if (playerTwoMove == "Lizard")
        //            {
        //                playerTwo.score++;
        //                Console.WriteLine("Lizard Poisons Spock! " + playerTwo.userName + "Wins!");
        //            }

        //            break;

        //            if(playerOne.score == 2)
        //            {
        //                Console.WriteLine("Congrats " + playerOne.userName + " ! You Won!");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Congrats " + playerTwo.userName + " ! You Won!");
        //            }



        //  public int callChamp;

        // if (player1.score = 3);
        // {
        // Console.WriteLine(player1 + " Is The Champ!");
        // }
        // else 
        // {
        //  Console.WriteLine(player2 + " Is The Champ!");
        // }
        //"Rock, Lizard, Scissors":
        //Console.WriteLine("Rock beats

        //    }


        //}



        public void ScorePoints()
        {
            if ((playerOne.userMove == "Rock" && playerTwo.userMove == "Rock") || (playerOne.userMove == "Paper" && playerTwo.userMove == "Paper") || (playerOne.userMove == "Scissors" && playerTwo.userMove == "Scissors") || (playerOne.userMove == "Lizard" && playerTwo.userMove == "Lizard") || (playerOne.userMove == "Spock" && playerTwo.userMove == "Spock"))
            {
                Console.WriteLine("'Pagh' Its a Draw. 0 Points Awarded");
            }
            else if ((playerOne.userMove == "Rock" && playerTwo.userMove == "Scissors") || (playerOne.userMove == "Rock" && playerTwo.userMove == "Lizard") || (playerOne.userMove == "Paper" && playerTwo.userMove == "Rock") || (playerOne.userMove == "Paper" && playerTwo.userMove == "Spock") || (playerOne.userMove == "Scissors" && playerTwo.userMove == "Paper") || (playerOne.userMove == "Scissors" && playerTwo.userMove == "Lizard") || (playerOne.userMove == "Lizard" && playerTwo.userMove == "Spock") || (playerOne.userMove == "Lizard" && playerTwo.userMove == "Paper") || (playerOne.userMove == "Spock" && playerTwo.userMove == "Scissors") || (playerOne.userMove == "Spock" && playerTwo.userMove == "Rock"))
            {
                Console.WriteLine("\n" + playerOne.userName + " Won This Round and Scored '1' Point");
                playerOnePoint++;
            }
            else
            {
                Console.WriteLine("\n" + playerTwo.userName + " Won This Round and Scored '1' Point");
                playerTwoPoint++;
            }
        }

        public void TotalPoints()
        {
            Console.WriteLine("\n" + playerOne.userName + "'s" + " Score is: " + playerOnePoint + "     " + playerTwo.userName + "'s" + " Score is: " + playerTwoPoint);
        }


        public void DeclareWinner()
        {
            if (playerOnePoint >= 0)
            {
                Console.WriteLine("\n----------" + playerOne.userName + "----------");
                Console.WriteLine("\n----------Wins The Match----------");
            }
            else if (playerTwoPoint >= 0)
            {
                Console.WriteLine("\n----------" + playerTwo.userName + "----------");
                Console.WriteLine("\n----------Wins The Match----------");
            }
        }

        public void StartOver()
        {
            Console.WriteLine("\n----------Start Over?----------");
            Console.WriteLine("\n----------Type '1' for Yes or '2' for no----------");
            string matchResetYesNo = Console.ReadLine();
            switch (matchResetYesNo)
            {
                case "1":
                    playerOnePoint = 0;
                    playerTwoPoint = 0;
                    RunGame();
                    break;

                case "2":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("\nPlease Try again");
                    StartOver();
                    break;
            }
        }


            public void RunGame()
        {
            Console.Clear();
            do
            {
                DisplayRules();
                GetPlayer();
                GameRounds();
                while (playerOnePoint < wins && playerTwoPoint < wins)
                {

                    Console.WriteLine("\n" + playerOne.userName + " Choose Your Play");
                    playerOne.ChooseMove();
                    Console.Clear();
                    Console.WriteLine("\n" + playerTwo.userName + " Choose Your Play");
                    playerTwo.ChooseMove();
                    ScorePoints();
                    TotalPoints();

                }
                DeclareWinner();
                StartOver();
            }
            while (playerOnePoint == 0 && playerTwoPoint == 0);
        }

    }
}



// if-else statement
//if (condition)
//{
//    then-statement;
//}
//else
//{
//    else-statement;
//}
//// Next statement in the program.

//// if statement without an else
//if (condition)
//{
//    then-statement;
//}
//// Next statement in the program.