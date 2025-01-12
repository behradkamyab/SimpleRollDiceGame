using System.Windows.Input;
namespace SimpleRollDice
{

    /// <summary>
    /// the game is set to play 10 rounds and after 10 rounds the winner will be announced
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int playerWin = 0;
            int aiWin = 0;

             for (int i = 0; i < 10; i++)
               {
                 Console.WriteLine("Press Any Key To Roll The Dice: ");
                 Console.ReadKey(true);

                 int playerVal = rnd.Next(1, 7);
                 Console.WriteLine("The dice number for player is: " + playerVal);

                Console.WriteLine("...");
                Thread.Sleep(1000);

                int aiVal = rnd.Next(1, 7);
                Console.WriteLine("The dice number for AI is: " + aiVal);
                if (playerVal > aiVal)
                {
                    playerWin++;
                    Console.WriteLine($"Score for Player is {playerWin}, AI {aiWin}");
                }
                else if (aiWin > aiVal)
                {
                    aiWin++;
                    Console.WriteLine($"Score for Player is {playerWin}, AI {aiWin}");

                }
                else
                {
                    Console.WriteLine("Tie!!");
                    Console.WriteLine("--------------------------------------------------");
                }
            }
            Console.ReadKey(true);

            if (playerWin > aiWin)
            {
                Console.WriteLine("You WON!");
            }
            if (aiWin > playerWin)
            {
                Console.WriteLine("AI WON!");
            }

        }
    }
}
