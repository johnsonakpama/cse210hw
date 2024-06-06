using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> a1 = new List<Activity>();

        Running run = new Running("30/11/2019, 3.0miles, 30minutes");
        run.Add(run);

        Cycling cyc = new Cycling("30/04/2020, 3.0miles, 30minutes, speed = 6.0mph");
        cyc.Add(Cyc);

        Swimming Swin = new Swimming("30/03/2021, length = 50meters");
        Swin.Add(Swin);

        foreach (Activity act in Activitys)
        {
            string date = act GetDate();

            double length = act GetLength();

            int minutes = act GetMinutes();

            Console.WriteLine($"the {date} lenght {length} minutes {minutes}");

        }
    }
}