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

            /// Game start message
            Console.WriteLine("Game starts\n");
            Console.WriteLine("Player Position: " + player1Pos);

            /// Game run
            while (player1Pos < END)
            {
                /// Rolling die
                int dieRoll = rand.Next(1, 7);
                int choice = rand.Next(0, 3);

                Console.WriteLine("No on Die: " + dieRoll);
                Console.WriteLine("Choice: " + choice);


                /// Checking choice and updating position
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Ladder");
                        player1Pos += dieRoll;
                        break;
                    case 2:
                        Console.WriteLine("Snake");
                        player1Pos -= dieRoll;
                        break;
                    default:
                        Console.WriteLine("No play");
                        break;
                }


                /// Check if player has reached below 0, then restart from 0
                if (player1Pos < START )
                {
                    player1Pos = START;
                }

                /// Check if player has  reached 100, then declare the player as winner
                /// and check if player has reached above 100, then don't update position
                if (player1Pos == END)
                {
                    Console.WriteLine("Congrats Player");
                }
                else if (player1Pos > END)
                {
                    player1Pos -= dieRoll;
                }

                /// Display current position at each play
                Console.WriteLine("Player Position: " + player1Pos + "\n");
            }
        }
    }
}
