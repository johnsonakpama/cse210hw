using system;

using system.Collection.Generic;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public void RecordEvent()
    {
        List<recordEvent> = new List<recordEvent>();
        event.Add(newrecordEvent);
    }

    public bool IsComplete()
    {
        if (goal == _description)
        {
            return IsComplete;
        }
    }

    public string GetDetailString()
    {
        string Goal = GetDetailString;

        return $"{shortName}, {description}, {points}";
    }

    public string GetStringRepresentation()
    {
        string Goal = GetStringRepresentation;

        return $"{description}, {points}";
    }

    public abstract int GetPoint();


}