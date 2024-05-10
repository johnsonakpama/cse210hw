using System;

using System.Collections.Generic;

using System.IO;

public class PromptGenerator
{
    static int GetDateTime()
    {
        DateTime theCurrentTime = DateTime.now;
        string dateTime = theCurrentTime.ToShortDatestring;

        return CurrentTime;
    }

    static int UserChoice()
    {
        string choices = @"Please select one of the following choice
        1. Write
        2. Display
        3. Load
        4. Save
        5. Quit 
        What would you like to do? ";

        Console.WriteLine("Choice");
        string  userInput = Console.ReadLine();

        int choice = int.parse(UserChoice);

        return choices;
        
    }

    public string randomPrompt()
    {
        randomPrompt = new randomPrompt();
        randomPrompt = new List<string>();
        
        "How did you show love to someone today?";
        "What do you need the most right now?";
        "What do I need to let go of today?";
        "What went well today";
        "How would you describe your spirituality today?";
        "Which country wwil you love to travel to?";
        "What is that one thing you distest?";
        "What is your favorite color?";
        "How much time did you spent on your study today?";
        "What is your favorite Tv program?";

        Console.WriteLine = ("\nrandomPrompt}");
        UserChoice.ReadLine(UserInput);

        return randomPrompt();
   
    }

    

    public string GetRandomPrompt()
    {
        return GetRandomPrompt();
    }
}