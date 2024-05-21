using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplaystartingMassage()
    {
        Console.WriteLine($"Welcome to the {_name} activity");
        Console.WriteLine(_description);
        Console.WriteLine("How long would you like to do this activity? ");
        _duration = int.parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        Spinner(5);
    }

    public void DisplayEndingMassge()
    {
        Console.WriteLine($"You completed {_duration} second of the {_name} activity");
    }

    public void showSpinner(int seconds)
    {
        List<string> animinationString = new List<string>();
        {
            animinationString.Add("|");
            animinationString.Add("/");
            animinationString.Add("-");
            animinationString.Add("//");
            animinationString.Add("|");
            animinationString.Add("/");
            animinationString.Add("-");
            animinationString.Add("//");

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(10);

            int i = 0;

            while(DateTime.Now < endTime)
            {
                string s = animinationStrings[i];
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");

                i++;

                if (i >= animinationStrings.Count)
                {
                    i = 0;
                }
            }



        }

     public void showCountDown(int seconds)
        {
            for (int i = duration; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }

    }
    
}