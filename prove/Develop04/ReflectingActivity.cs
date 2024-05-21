using System;
 
 public class ReflectionActivity
 {
     private List<string> _prompts = new()
    [
        "Think of a time when you stood up for someone",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What did you learn about yourself through this experience?"

    ];
    private List<string> _question = new()
    {   
        "Who are people that you appreciate?";
        "What are personal strength of yours?";
        "Who are people that you help this week?";
        "When have you felt the Holy Ghost this month";
        "Who are some of your personal heroes?"
    }
    public Reflection(int _duration): base(_duration)
    {
        _name = "Reflecting";
        _description = "This activity will help you reflect on times...";
    }
    public void Run()
    {
        StartMessage();
        Console.WriteLine("Consider the following prompts");
        Console.WriteLine(GetRandomPrmpt());
        Console.WriteLine("When you have something in mind press enter to continue");
        string input = Console.ReadLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        {
            Console.WriteLine(GetRandonQuestion());
            Spinner(10);
        }
        EndMassage();

    }
    public string GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandonQuestion()
    {
        int index = random.Next(_question.Count);
        return _questions[index];
    } 

    public void DisplayPrompt()
    {
        return "";
    }

    public void DisplayQuestion()
    (
        return "";
    )


 }