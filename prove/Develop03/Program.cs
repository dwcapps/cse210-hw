using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        Reference proverbReference = new Reference("Proverbs", 3, 5, 6);
        string proverbText = "Trust in the Lord with all thine heart; and also lean not unto thine own understanding. "
                           + "In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture proverb = new Scripture(proverbReference, proverbText);

        string userInput = "";
        int numberToHide = 0; //Makes sure no words are hidden on first loop

        while (userInput != "quit" && proverb.IsCompletelyHidden() == false){
            Console.Clear();
            proverb.HideRandomWords(numberToHide);
            numberToHide = 3;
            Console.WriteLine(proverb.GetDisplayText() + "\n");
            Console.WriteLine("Press enter to continue hiding, type 'reset' to reveal all words, or type 'quit' to finish:");
            userInput = Console.ReadLine();
            if (userInput == "reset")
            {
                proverb.ResetHidden();
                numberToHide = 0;
            }
        }
    }
}
// Exceeded Requirements by:
// 1. Added reset option to show all hidden words.
// 2. Made sure only words that were not already hidden are selected at random, 
//    and accounted for when the number of remaining words is less than the number of hide attempts.