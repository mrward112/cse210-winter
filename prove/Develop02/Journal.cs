using System;
using System.Collections.Generic;

public class Journal 
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string date, string prompt, string entry)
    {
        Entry newEntry = new Entry(date, prompt, entry);
        _entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"Date: {entry.Date} - Prompt: {entry.Prompt}\n{entry.Text}");
        }
    }

    public void ResetJournal()
    {
        _entries.Clear();
    }

    public void LoadFromFile()
    {
        Console.Write("Enter the file name: ");
        string fileName = Console.ReadLine();
        _entries.Clear();

        using (StreamReader reader = new StreamReader(fileName))
        {
            string line = "";
            while (line != null)
            {
                line = reader.ReadLine();
                if (line != null)
                {
                    string[] parts = line.Split("|");
                    string date = parts[0];
                    string prompt = parts[1];
                    string entry = parts[2];
                    Entry newEntry = new Entry(date, prompt, entry);
                    _entries.Add(newEntry);
                }
            }
        }
    }
}


    