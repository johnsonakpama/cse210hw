using System;

using System.Collections.Generic;

using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal thejournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();
    }

    public userChoice(int)
    {
        int [] validNumber = {1, 2, 3, 4, 5};

        int choice = validNumber[0];

        Console.Write("n/*******Welcome to the journal App*******/n");

        while (userChoice !=5)
        {
            Console.WriteLine("What would you want to do? ");
        }

        Journal thejournal = new journal();

        action = userChoice();

         switch (action)
    {
        case 1:

        //write journal Entry

        string dateTime = GetDateTime();

        string prompt = JournalPrompt();
        JournalEntry.Entry = new JournalEntry();

        entry. _dateTime DateInfo;

        entry. _journalPrompt = prompt;

        Console.Write(">>");

        string userEntry = Console.ReadLine();

        entry._journal.Add(entry);

        break;

        case 2:
         Display journal Entries

        journal.Display();

        // console.writeLine("success choice 2!");

        break;
        
        case 3:

         Load

         console. writeLine("success choice 3!");

        break;

        case 4:

         Save
        Create journalFile();

         string AddEntry = journal.Display();
         AddJournalEntry(AddEntry);
         console.writeLine("success choice 4!");

        break;

        case 5:

         Quit

        Console.WriteLine("\nThank you for using the journal App!\n");

        break;

        default:
        
        Console.WriteLine("\nSorry that is not valid choice!");
        }
    
    }

}