using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Fraction test1 = new Fraction();
        Fraction test2 = new Fraction(6);
        Fraction test3 = new Fraction(6,7);

        Console.WriteLine("GetFractionString Tests:");
        Console.WriteLine(test1.GetFractionString());
        Console.WriteLine(test2.GetFractionString());
        Console.WriteLine(test3.GetFractionString());
        Console.WriteLine();

        Console.WriteLine("GetDecimalValue Tests:");
        Console.WriteLine(test1.GetDecimalValue());
        Console.WriteLine(test2.GetDecimalValue());
        Console.WriteLine(test3.GetDecimalValue());
        Console.WriteLine();

        Console.WriteLine("SetTop and SetBottom Tests:");
        test3.SetTop(3);
        test3.SetBottom(4);
        Console.WriteLine(test3.GetFractionString());
        Console.WriteLine(test3.GetDecimalValue());
        Console.WriteLine();

        Console.WriteLine("GetTop and GetBottom Tests:");
        Console.WriteLine(test3.GetTop());
        Console.WriteLine(test3.GetBottom());
        Console.WriteLine();



    }
}