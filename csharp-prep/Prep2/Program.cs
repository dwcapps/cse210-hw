using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string percentInText = Console.ReadLine();
        int percent = int.Parse(percentInText);
        string letter = "Error";
        string sign = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else if (percent < 60)
        {
            letter = "F";
        }
        
        int signNum = percent % 10;

        if (signNum >= 7)
        {
            sign = "+";
        }
        else if (signNum < 3)
        {
            sign = "-";
        }

        if (percent > 93)
        {
            sign = "";
        }
        else if (percent < 60)
        {
            sign = "";
        }

        Console.Write(letter);
        Console.WriteLine(sign);

        if (percent > 70)
        {
            Console.WriteLine("Congrats, you passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass. You'll get it next time!");
        }
    }
}