using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numberToGuess = random.Next(1, 101);
        int userGuess = 0;
        int numberOfGuesses = 0;

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("I have selected a number between 1 and 100. Try to guess it!");

        while (userGuess != numberToGuess)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out userGuess))
            {
                numberOfGuesses++;

                if (userGuess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (userGuess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {numberOfGuesses} attempts.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
