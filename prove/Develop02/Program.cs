using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Welcome to the Journal Program!");
        Journal myJournal = new Journal();
        int userChoice = -1;
        do{
            Console.Write("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\nWhat would you like to do? ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1) //Write
            {
                Entry newEntry = new Entry();
                myJournal.AddEntry(newEntry);
            }

            if (userChoice == 2) //Display
            {
                foreach (Entry entry in myJournal._entries)
                {
                    entry.Display();
                }
            }

            if (userChoice == 3) //Load
            {
                Console.WriteLine("What is the filename?");
                myJournal.LoadFromFile(Console.ReadLine());
            }
            
            if (userChoice == 4) //Save
            {
                Console.WriteLine("What is the filename?");
                myJournal.SaveToFile(Console.ReadLine());
            }
        }while (userChoice != 5);
    }
}