using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulation Program\n");

            /// Variables
            int START = 0;
            int END = 100;

            int player1Pos = START;
            Random rand = new Random();

            int dieRoll = rand.Next(1, 7);

            Console.WriteLine("Game starts\n");
            Console.WriteLine("Player Position: " + player1Pos);
            Console.WriteLine("No on Die: " + dieRoll);
        }
    }
}
