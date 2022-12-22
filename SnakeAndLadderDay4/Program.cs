using System;

namespace SnakeAndLadderDay4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin Game");
            int Position = 0; 
            Random random= new Random();
            int DiceRoll = random.Next(1,7);  //Dice roll using random method
            int Option = random.Next(0, 3);  // Checking option by using random method
            //taking option by using switch case
            switch (Option)
            {
                case 0:
                    Position = Position + DiceRoll;  // Updating position
                    Console.WriteLine("Player got the Ladder and the dice : {0} Now player is in the position : {1}",DiceRoll,Position);
                    break;
                case 1:
                    Position = Position - DiceRoll; //Updating position
                    if (Position < 0)
                        Position = 0;
                    Console.WriteLine("Player got the Snake and the dice : {0} Now player is in the position : {1}", DiceRoll, Position);
                    break;
                default:
                    Console.WriteLine(" No play , the dice :{0} & the player stays in same position : {} ", DiceRoll, Position);
                    break;
          }

        }
    }
}
