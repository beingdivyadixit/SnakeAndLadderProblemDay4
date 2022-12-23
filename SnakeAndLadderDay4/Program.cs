using System;

namespace SnakeAndLadderDay4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin Game");
            Console.WriteLine("Enter the Name Player one"); // Taking user input for player 1
            string PlayerOne = Console.ReadLine();
            Console.WriteLine("Enter the Name Player two"); // Taking user input for player 2
            string PlayerTwo = Console.ReadLine();
            // Initializing value
            int Player1Position = 0, Player2Position = 0, count =0; 
            bool PlayerTurn =true;
            Random random= new Random(); //  Object creation

            //taking option by using switch case
            while (Player1Position < 100 && Player2Position < 100)
            {
                int DiceRoll = random.Next(1, 7); //Dice roll using random method
                int Option = random.Next(0, 3);  // Checking option by using random method
                count = count + 1;
                if (PlayerTurn == true)   // condtion for player's turn if ldder than same player will play else other one
                {
                    if (Player1Position < 100)
                    {
                        switch (Option)
                        {
                            case 0:
                                Player1Position = Player1Position + DiceRoll;  // Updating position of 1st player
                                if (Player1Position > 100)
                                    Player1Position = 100;
                                Console.WriteLine("{0} got the Ladder and the dice : {1} Now player is in the position : {2}", PlayerOne, DiceRoll, Player1Position);
                                PlayerTurn = true;   // AS laader so ensuring that same player play again
                                if (Player1Position == 100)
                                    Console.WriteLine("<***{0}***> Won", PlayerOne);
                                 break;
                            case 1:
                                Player1Position = Player1Position - DiceRoll; //Updating position of 1st player
                                if (Player1Position < 0)
                                    Player1Position = 0;
                                Console.WriteLine("{0} got the Snake and the dice : {1} Now player is in the position : {2}", PlayerOne, DiceRoll, Player1Position);
                                PlayerTurn = false; // AS snake so ensuring that second player play
                                break;
                            default:
                                Console.WriteLine("No play,the dice : {0} & the {1} stays in same position : {2} ", DiceRoll, PlayerOne,Player1Position);
                                PlayerTurn = false; // AS no play so ensuring that second player play
                                break;
                        }
                    }
                }
                else
                {
                    if (Player2Position < 100)
                    {
                        switch (Option)
                        {
                            case 0:
                                Player2Position = Player2Position + DiceRoll;  // Updating position of 2nd player
                                if (Player2Position > 100)
                                    Player2Position = 100;
                                Console.WriteLine("{0} got the Ladder and the dice : {1} Now player is in the position : {2}",PlayerTwo ,DiceRoll, Player2Position);
                                PlayerTurn = false; // AS laader so ensuring that same player play again
                                if (Player2Position == 100)
                                    Console.WriteLine("<***{0}***> Won" ,PlayerTwo);
                                break;
                            case 1:
                                Player2Position = Player2Position - DiceRoll; //Updating position of 2nd player
                                if (Player2Position < 0)
                                    Player2Position = 0;
                                Console.WriteLine("{0} got the Snake and the dice : {1} Now player is in the position : {2}", PlayerTwo, DiceRoll, Player2Position);
                                PlayerTurn = true; // AS snake so ensuring that first player play 
                                break;
                            default:
                                Console.WriteLine("No play,the dice : {0} & the {1} stays in same position : {2} ", DiceRoll,PlayerTwo , Player2Position);
                                PlayerTurn = true;  // AS no play so ensuring that first player play
                                break;
                        }
                    }

                }
            }
             Console.WriteLine("{0} number of times the dice was played to win the game" , count);

        }
    }
}