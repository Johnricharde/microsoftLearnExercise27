using System.Reflection.Metadata.Ecma335;
using System.Runtime;

namespace microsoftLearnExercise27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Would you like to play? (Y/N)");
            if (ShouldPlay())
            {
                PlayGame();
            }

            void PlayGame()
            {
                var play = true;

                while (play)
                {
                    var target = random.Next(1, 5 );
                    var roll = random.Next(1, 6);

                    Console.WriteLine($"\nRoll a number greater than {target} to win!");
                    Console.WriteLine($"You rolled a {roll}");
                    Console.WriteLine(WinOrLose(target, roll));
                    Console.WriteLine("\nPlay again? (Y/N)");

                    play = ShouldPlay();
                }
            }

            bool ShouldPlay()
            {
                char userInput = Console.ReadKey().KeyChar;

                return userInput == 'y' ? true : false;
            }

            string WinOrLose(int target, int roll)
            {
                if (roll > target)
                    return "You win!";

                return "You lose!";
            }
        }
    }
}
