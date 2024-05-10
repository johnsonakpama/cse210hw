using System;

using System.Collections.Generic;

using System.IO;

public class Journal
[
    public List<Entry> _entries;

    public void AddEntry(newEntry.Entry)
    {
       List<eventEntry> = new List<eventEntry>();
       
       event.Add(newEntry);
    }

    public void DisplayAll()
    {
       string List<string> event new List<string>();

       foreach(string event in events)
       {
        Console.WriteLine($"{_entries}");
       }

       DisplayAll();
    }

    public void SaveToFile(string file)
    {
        Console.WriteLine("Saving to file...");

        string filename = "Everyday.txt";

        using (streamWriter outputFile = new streamWriter(filename))
        {
            foreach(journal e in journal)
            {
                outputFile.WriteLine $"{_date} ~~ {_promptText} ~~ {_entryText}";
            }
        }
    }

    public void LoadFromFile(string file)
    {
       Console.WriteLine("Loading from file...");

       List<event> Journal = new List<event>();

       string file = "Everyday.txt";

       string[] line = System.IO.file.LoadAllLines(filename)

       foreach(string line in lines)
       {
        string[] parts = line.split("~~");
       }

        return event;

    }
]