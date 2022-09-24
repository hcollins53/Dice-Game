using System;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerNum;
            int otherPlayerNum;

            int playerPoints = 0;
            int otherPlayerPoints = 0;

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
               Console.WriteLine("Press any key to roll the dice!");

                Console.ReadKey();

                playerNum = random.Next(1, 7);
                Console.WriteLine($"Player 1 rolled a {playerNum}");

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                otherPlayerNum = random.Next(1, 7);
                Console.WriteLine($"Player 2 rolled a {otherPlayerNum}");

                if(playerNum > otherPlayerNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player 1 wins this round!");
                }
                else if(playerNum < otherPlayerNum)
                {
                    otherPlayerPoints++;
                    Console.WriteLine("Player 2 wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine($"The score is now - Player 1 : {playerPoints} and Player 2 : {otherPlayerPoints} ");
                Console.WriteLine();
            }

            if(playerPoints > otherPlayerPoints)
            {
                Console.WriteLine("Player 1 wins!");
            }
            else if(playerPoints < otherPlayerPoints)
            {
                Console.WriteLine("Player 2 wins!");

            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
            
        }
    }
}
