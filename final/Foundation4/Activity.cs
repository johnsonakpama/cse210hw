using system;

public abstract class Activity
{
    private string _date;
    private double _length;
    private int _minutes;

    public string Activity(string date, int length, int minutes)
    {
        _date = date;
        _length = length;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetLength()
    {
        return _length;
    }

    public int GetMinutes()
    {
        _minutes = minutes;
    }

    public abstract string GetActivitySummary();
}