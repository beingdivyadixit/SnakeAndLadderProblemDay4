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
            int DiceRoll = random.Next(1,7); //Dice roll using random method  
            Console.WriteLine("Player is in Position {0} & Dice After Roll is {1}", Position, DiceRoll);

        }
    }
}
