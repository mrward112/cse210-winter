using System;


class Program
{
    static void Main(string[] args)
    {
        string userChoice = "1";

        while (userChoice != "5")
        {


        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices: ");
        Console.WriteLine(" 1. Write \n 2. Display \n 3. load \n 4. Save \n 5. Quit");

        userChoice = Console.ReadLine();
        
        switch (userChoice)
        {
            case "1":
                Console.WriteLine("What would you like to write?");
                // string date = DateTime.Now.ToString("MM/dd/yyyy");
                // Console.WriteLine("Enter a prompt:");
                // string prompt = Console.ReadLine();
                // Console.WriteLine("Enter your entry:");
                // string text = Console.ReadLine();
                // Entry newEntry = new Entry(date, prompt, text);
                break;
            case "2":
                Console.WriteLine("Here's your journal: ");
                break;
            case "3":
                Console.WriteLine("What would you like to load?");
                break;
            case "4":
                Console.WriteLine("Would you like to save?");
                break;
            case "5":
                Console.WriteLine("Goodbye!");
                break;
            default:
                Console.WriteLine("Please enter a number between 1 and 5.");
                break;
        }
        }

    }
}