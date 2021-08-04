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

            Console.WriteLine("Game starts\n");
            Console.WriteLine("Player Position: " + player1Pos);

            int dieRoll = rand.Next(1, 7);
            int choice = rand.Next(0, 3);

            Console.WriteLine("No on Die: " + dieRoll);
            Console.WriteLine("Choice: " + choice);

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Ladder");
                    player1Pos += dieRoll;
                    Console.WriteLine("Player Position: " + player1Pos);
                    break;
                case 2:
                    Console.WriteLine("Snake");
                    player1Pos -= dieRoll;
                    Console.WriteLine("Player Position: " + player1Pos);
                    break;
                default:
                    Console.WriteLine("No play");
                    Console.WriteLine("Player Position: " + player1Pos);
                    break;
            }
        }
    }
}
