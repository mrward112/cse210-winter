using System;

// public class PromptGenerator
// {
//     private static string[] prompts = 
//     {
//         "Write about a memorable experience you had recently.",
//         "Describe a person who has had a significant impact on your life.",
//         "What are you grateful for today?",
//         "Write about a challenge you overcame and what you learned from it.",
//         "Reflect on your goals and write about steps you can take to achieve them."
//     };

//     public static void Main(string[] args)
//     {
//         Random random = new Random();
//         int numPrompts = 5;

//         Console.WriteLine("Welcome to the Journal Program!");

//         for (int i = 0; i < numPrompts; i++)
//         {
//             int randomIndex = random.Next(prompts.Length);
//             string prompt = prompts[randomIndex];

//             Console.WriteLine($"\nPrompt {i+1}: {prompt}");
//             Console.WriteLine("What would you like to write?");

//             string userEntry = Console.ReadLine();

//             // Save userEntry to journal or perform any other desired actions

//             Console.WriteLine("Entry saved!\n");
//         }

//         Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
//     }
    // }