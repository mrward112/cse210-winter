using System;

class Program
{
    public static void Main()
        {
            Console.WriteLine("Welcome to the Scripture Memorizer!");
            // ******** gets the scripture Book, chapter, and verse from the user ********
            Console.Write("Enter the name of the book: ");
            string book = Console.ReadLine();

            Console.Write("Enter the chapter number: ");
            int chapter = int.Parse(Console.ReadLine());

            Console.Write("Enter the verse number: ");
            int verse = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a scripture verse here: ");
            string text = Console.ReadLine();


            Scripture scripture = new Scripture(book, chapter, verse, text);
            Console.Clear();
            // ******** gets the scripture Book, chapter, and verse from the user ********


            scripture.Display(); 
            Console.WriteLine("\n Here is your scripture. Press Enter to begin memorizing or type 'quit' to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                if (!scripture.HideRandomWord())
                {
                    Console.WriteLine("\nYou've memorized the scripture!!");
                    break;
                }

                Console.Clear();
                scripture.Display();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            }
        }
}
