using system;

using system.Collection.Generic;

public class ChecklistGoal : Goal
{
    protected int _amountCompleted = 0;
    protected int _target;
    protected int _bonus = 0;

    public string ChecklistGoal(string name, string description, int points, int target, int bonus,) : base (shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }

    public void SetTarget(int target)
    {
        _target = target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
}