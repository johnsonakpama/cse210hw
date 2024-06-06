using system;

public class Running : Activity
{
    private int _distance;

    public Running(string date, double length, int minutes, int distance) : base(date, length, minutes)
    {
        _distance = distance;
    }

    public override string GetActivitySummary();
}