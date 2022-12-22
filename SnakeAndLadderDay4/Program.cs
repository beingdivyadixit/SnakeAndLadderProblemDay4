using System;

namespace SnakeAndLadderDay4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin Game");
            int Position = 0,count=0; 
            Random random= new Random();

            //taking option by using switch case
            while (Position<100)
            {
                int DiceRoll = random.Next(1, 7); //Dice roll using random method
                int Option = random.Next(0, 3);  // Checking option by using random method
                count = count + 1;
                switch (Option)
                {
                    case 0:
                        Position = Position + DiceRoll;  // Updating position
                        if(Position >100)  
                           Position = 100;
                        Console.WriteLine("Player got the Ladder and the dice : {0} Now player is in the position : {1}" , DiceRoll, Position);
                        break;
                    case 1:
                        Position = Position - DiceRoll; //Updating position
                        if (Position < 0)
                           Position = 0;
                        Console.WriteLine("Player got the Snake and the dice : {0} Now player is in the position : {1}" , DiceRoll, Position);
                        break;
                    default:
                        Console.WriteLine("No play,the dice : {0} & the player stays in same position : {1} ", DiceRoll, Position);
                        break;
                }
            }
            Console.WriteLine("{0} number of times the dice was played to win the game" , count);

        }
    }
}