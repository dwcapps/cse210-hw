using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int num;
        do
        {
            Console.Write("Enter a number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0)
            {
            numList.Add(num);
            }
        } while (num != 0);


        int largest = 0;
        int smallestPos = int.MaxValue;
        int sum = 0;
        foreach (int number in numList)
        {
            sum += number;
            if (number > largest)
            {
                largest = number;
            }
            if (number < smallestPos && number > 0)
            {
                smallestPos = number;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {((float)sum)/numList.Count}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPos}");
        Console.WriteLine($"The sorted list is:");
        numList.Sort();
        foreach (int number in numList)
        {
            Console.WriteLine(number);
        }
    }
}