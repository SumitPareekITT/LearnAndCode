using System;

namespace GuessCorrectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var game = new GuessingGame();
            game.Play();

            Console.ReadLine();
        }
    }

    class GuessingGame
    {
        private int targetNumber;
        private int noOfAttempts;

        public GuessingGame()
        {
            targetNumber = NumberGenerator.CreateRandomNumber();
            noOfAttempts = 0;
        }

        public void Play()
        {

            while (true)
            {
                Console.Write("Guess a number between 1 and 100: ");
                var userInput = Console.ReadLine();

                if (!InputValidator.Validate(userInput))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
                    continue;
                }

                int guessedNumber = int.Parse(userInput);
                noOfAttempts++;

                if(guessedNumber == targetNumber)
                {
                    Console.WriteLine("You guessed it in " + noOfAttempts + " guesses!");
                    break;
                }

                Console.WriteLine(guessedNumber < targetNumber 
                    ? "Too low. Guess again." 
                    : "Too high. Guess again.");
            }
        }
    }

    class NumberGenerator
    {
        public static int CreateRandomNumber()
        {
            Random random = new Random();
            return random.Next(1, 101);
        }
    }

    class InputValidator
    {
        public static bool Validate(string input)
        {
            int number;
            return int.TryParse(input, out number) && number >= 1 && number <= 100;
        }
    }

}