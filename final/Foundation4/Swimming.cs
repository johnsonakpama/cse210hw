using system;

public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string date, double length, int minutes, int numberOfLaps) : base(date, length, minutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override string GetActivitySummary();
}