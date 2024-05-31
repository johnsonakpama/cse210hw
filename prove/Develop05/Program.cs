using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal sGoal = new SimpleGoal();
        sGoal.SetshortName ("");
        sGoal.Setdescription("");
        sGoal.Setpoint("");

        EternalGoal eGoal = new EternalGoal();
        eGoal.SetshortName("");
        eGoal.Setdescription("");
        eGoal.Setpoint("");

        ChecklistGoal gChecklistGoal = new ChecklistGoal();
        gChecklistGoal.SetshortName("");
        gChecklistGoal.Setdescription("");
        gChecklistGoal.Setpoint("");

        List<Goal> goal = new List<Goal>();
        SimpleGoal.Add(SimpleGoal);
        EternalGoal.Add(EternalGoal);
        ChecklistGoal.Add(ChecklistGoal);

        foreach (Goal goal in goals)
        {
            int point = goal.GetPoint;
        }

        public static void DisplayPlayerInfo(Goal goal);
        {
            int points = Goal.GetPoint;
            Console.WriteLine($"goal {DisplayDetail}");
        }
        


    }
}