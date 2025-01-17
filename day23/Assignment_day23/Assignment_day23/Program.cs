
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
class NumberGuessGame
{
    static void Main()
    {
        Random random = new Random();
        int number = random.Next(1, 99);
        int guess = 0;
        int chanceToGuess = 5;

        Console.WriteLine("Hello This is Number Guessing Game!!");
        Console.WriteLine("Please enter a number between 1 and 99:");

        while (guess != chanceToGuess)
        {
            Console.Write("Enter your guess: ");
            guess = Int32.Parse(Console.ReadLine());
            if (guess < 100 && guess >0)
            {
                chanceToGuess--;

                if (guess < number)
                {
                    Console.WriteLine($"Almost {number-guess} difference. Number is {number}.Please try again!");
                }
                else if (guess > number)
                {
                    Console.WriteLine($"Almost {guess-number} difference. Number is {number}.Please try again!");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {chanceToGuess} attempts.");
                }
            }
            else
            {
                Console.WriteLine("Please enter a number within range:");
            }
        }
    }
}
