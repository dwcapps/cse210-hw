class Program
{
    static void Main(string[] args)
    {
        string menu = @"
Menu Options: 
    1. Start breathing activity
    2. Start reflecting activity
    3. Start listing activity
    4. Quit
Select a choice from the menu: ";

        int userMenuChoice = 0;
        while (userMenuChoice != 4)
        {
            Console.Clear();
            Console.Write(menu);
            string userRawInput = Console.ReadLine();
            if (int.TryParse(userRawInput, out userMenuChoice))
            {
                switch (userMenuChoice)
                {
                    case 1:
                        BreathingActivity breathingActivity = new BreathingActivity();
                        breathingActivity.Run();
                        break;
                    case 2:
                        ReflectingActivity reflectingActivity = new ReflectingActivity();
                        reflectingActivity.Run();
                        break;
                    case 3:
                        ListingActivity listingActivity = new ListingActivity();
                        listingActivity.Run();
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                Thread.Sleep(3000);
            }
        }
    }
}

// I have attempted to exceed the requirements by doing the following:
// - Ensured that no random selection can be picked twice.
// - Allowed the user to choose how many questions they'd like to be ask, which then adjusts the amount of time given per question to fit the previously defined time limit.
// - Added exception handling for the user Main Menu input.
// - Added exception handling for if the Program runs out of prompts in the Reflection Activity.