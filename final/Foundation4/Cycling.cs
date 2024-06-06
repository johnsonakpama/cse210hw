using system;

public class Cycling : Activity
{
    private int _speed;

    public Cyling(string date, double length, int minutes, int speed) : base(date, length, minutes)
    {
        _speed = speed;
    }

    public override string GetActivitySummary()
    {
        return _speed;
    }
} 