using System;
using System.IO;

public class Entry
{
    public string Date { get; }
    public string Prompt { get; }
    public string Text { get; }

    public Entry(string date, string prompt, string text)
    {
        Date = date;
        Prompt = prompt;
        Text = text;
        
        SaveToJournal();
    }

    private void SaveToJournal()
    {
        string entryLine = $"Date: {Date} - Prompt: {Prompt}\n{Text}";

        // Append the entry to the Journal.txt file
        using (StreamWriter writer = new StreamWriter("Journal.txt", true))
        {
            writer.WriteLine(entryLine);
        }
    }
}