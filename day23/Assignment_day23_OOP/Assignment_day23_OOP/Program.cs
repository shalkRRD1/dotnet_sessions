using System;

namespace NumberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessGame start = new GuessGame(3);
            start.Game();
        }
    }
   
    public class GuessGame
    {
        private int number;
        private int chances;
        private int input;

        public GuessGame(int chance)
        {
            chances = chance;
            input = 0;
            Random random = new Random();
            number = random.Next(1, 99);
        }

        public void Game()
        {
            Console.WriteLine("Please select a number between 1 and 99:");

            while (input < chances)
            {
                Console.Write("Enter your choice: ");
                int guess = Int32.Parse(Console.ReadLine());
                if (guess < 100 && guess > 0)
                {
                    input++;
                    if (guess == number)
                    {
                        Console.WriteLine($"Congratulations! You guessed the number in {input} attempts.");
                        return;
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine($"Number differ by {number-guess}. Please try again.");
                    }
                    else
                    {
                        Console.WriteLine($"Number differ by {guess-number}. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }

            Console.WriteLine($"You used all {chances} attempts. The correct number is {number}.");
        }
    }
}
