using system;

using system.Collection.Generic;

using system.IO;

public class GoalManager
{
    protected string List<Goal> _goals = new List<Goal>();
    protected int _score;

    public GoalManager()
    {
        _goals = goals;
        _score = score;
    }

    public void Start(Goal goals)
    {
        int score = 0;
        StartMessage()
        Console.WriteLine("Which type of goal would you like to create? ");
        Console.ReadLine();
        Console.WriteLine("What is the name of goal? ");
        Console.ReadLine();
        Console.WriteLine("What is a short description of your goal? ");
        Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal");
        Console.ReadLine();
    }

    public void DisplayPlayerInfo()
    {
        string List<DisplayPlayerInfo> goal new List<DisplayPlayerInfo>();

       foreach(string goal in goals)
       {
        Console.WriteLine($"{_goals}");
       }

       DisplayPlayerInfo();
    }

    public void ListGoalNames()
    {
        string List<ListGoalNames> goal new List<ListGoalNames>();

       foreach(string goal in goals)
       {
        Console.WriteLine($"{_goals}");
       }

       ListGoalNames();
    }

    public void ListGoalDetails()
    {
         string List<ListGoalDetails> goal new List<ListGoalDetails>();

       foreach(string goal in goals)
       {
        Console.WriteLine($"{_goals}");
       }

       ListGoalDetails();
    }

    public void CreateGoal()
    {
        List<CreateGoal> = new List<CreateGoal>();
        event.Add(newCreateGoal);
    }

    public void RecordEvent()
    {
        List<recordEvent> = new List<recordEvent>();
        event.Add(newrecordEvent);
    }

    public void SaveGoals()
    {
         Console.WriteLine("Saving to file...");

        string filename = "goal.txt";

        using (streamWriter outputFile = new streamWriter(filename));
        {
            foreach(goal g in goals)
            {
                outputFile.WriteLine $"{_shortName} ~~ {_description} ~~ {_point}";
            }
        }
    }

    public void LoadGoal()
    {
        Console.WriteLine("Loading from file...");

       List<event> Goal = new List<event>();

       string file = "goal.txt";

       string[] line = System.IO.file.LoadAllLines(filename);

       foreach(string line in lines)
       {
        string[] parts = line.split("~~");
       }

        return event();

    }
}