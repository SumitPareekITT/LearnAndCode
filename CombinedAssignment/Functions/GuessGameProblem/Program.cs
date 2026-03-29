using System;

class Program
{
    static void Main()
    {
        PlayGame();
    }

    static void PlayGame()
    {
        int secretNumber = GenerateSecretNumber();
        int guesses = 0;

        while (true)
        {
            string input = GetUserInput();

            if (!IsValidGuess(input))
            {
                ShowInvalidInputMessage();
                continue;
            }

            guesses++;
            int guess = int.Parse(input);

            if (guess < secretNumber)
                ShowTooLowMessage();
            else if (guess > secretNumber)
                ShowTooHighMessage();
            else
            {
                ShowSuccessMessage(guesses);
                break;
            }
        }
    }

    static int GenerateSecretNumber()
    {
        Random r = new Random();
        return r.Next(1, 101);
    }

    static string GetUserInput()
    {
        Console.Write("Guess a number between 1 and 100: ");
        return Console.ReadLine();
    }

    static bool IsValidGuess(string input)
    {
        return int.TryParse(input, out int num) && num >= 1 && num <= 100;
    }

    static void ShowInvalidInputMessage()
    {
        Console.WriteLine("I won't count this one. Please enter a number between 1 and 100.");
    }

    static void ShowTooLowMessage()
    {
        Console.WriteLine("Too low. Guess again.");
    }

    static void ShowTooHighMessage()
    {
        Console.WriteLine("Too high. Guess again.");
    }

    static void ShowSuccessMessage(int guesses)
    {
        Console.WriteLine($"You guessed it in {guesses} guesses!");
    }
}
