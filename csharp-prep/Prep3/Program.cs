using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "Y";
        do{
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);
            int userGuess;
            int numOfGuesses = 0;
            do
            {
                Console.Write("Guess a number! ");
                string userInputGuess = Console.ReadLine();
                userGuess = int.Parse(userInputGuess);
                numOfGuesses++;
                if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower!");
                }
                else if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher!");
                }
            } while (userGuess != magicNumber);
            Console.WriteLine($"You guessed it! It took you {numOfGuesses} guesses.");
            Console.WriteLine("Play again? ");
            playAgain = Console.ReadLine();
        } while (playAgain == "Y");
    }
}