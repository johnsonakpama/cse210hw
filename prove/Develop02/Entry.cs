using System;

using System.Collections.Generic;

using System.IO;

public class Entry
{
    string _date;
    string _promptText;
    string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_date}, {_promptText}, {_entryText}");
    }
}