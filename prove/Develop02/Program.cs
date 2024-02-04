using System;


class Program
{
    public static void Main(string[] args)
    {
        string userChoice = "1";

        while (userChoice != "5")
        {
            Console.WriteLine("Welcome to your Journal Program!");
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine(" 1. Write an entry \n 2. Display all entries \n 3. load a journal \n 4. Save to a file \n 5. Quit program");

            userChoice = Console.ReadLine();
            
            Journal myJournal = new Journal();

            switch (userChoice)
            
            {
                case "1":
                    PromptGenerator promptGenerator = new PromptGenerator();
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);


                    string date = DateTime.Now.ToString("MM/dd/yyyy");
                    


                    Console.WriteLine("Please write your entry: ");
                    string text = Console.ReadLine();
                    Entry newEntry = new Entry(date, prompt, text);
                    Console.WriteLine();
                    break;
                    

                case "2":
                    // Journal myJournal = new Journal();
                    foreach (Entry entry in myJournal._entries)
                    {
                        Console.WriteLine($"Date: {entry.Date} - Prompt: {entry.Prompt}\n{entry.Text}");
                    }


                    Console.WriteLine();

                    break;
                case "3":
                    myJournal.LoadFromFile();

                    break;

                case "4":

                    Console.WriteLine("Please provide a file name:");
                    string fileName = Console.ReadLine();
                    using (StreamReader reader = new StreamReader("Journal.txt"))
                    {
                        using (StreamWriter writer = new StreamWriter(fileName + ".txt"))
                        {
                            string line = "";
                            while (line != null)
                            {
                                line = reader.ReadLine();
                                if (line != null)
                                {
                                    writer.WriteLine(line);
                                }
                            }
                        }
                        myJournal.ResetJournal();
                    }

                    break;

                case "5":
                    Console.WriteLine("Goodbye!");

                    break;

                default:
                    Console.WriteLine("Please enter a number between 1 and 5.");
                    Console.WriteLine();

                    break;
            }
        }
    }
}