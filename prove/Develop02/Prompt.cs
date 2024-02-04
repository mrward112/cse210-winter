using System;

public class PromptGenerator
{
    public string[] _prompts = new string[]
    {
        "Write about a memorable experience you had recently.",
        "Describe a person who has had a significant impact on your life.",
        "What are you grateful for today?",
        "Write about a challenge you overcame and what you learned from it.",
        "Reflect on your goals and write about steps you can take to achieve them.",
        "What do you think is the most important lesson you've learned from your experiences so far?",
        "Describe a time when you had to overcome obstacles to reach a goal.",
        "Write about a book or movie that has had a significant impact on your life.",
        "What are your long-term career goals?",
        "How did you handle stress today?",
    };


    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Length);
        return _prompts[randomIndex];

    }


    }