using System.Runtime;

public class ChecklistGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;

    public ChecklistGoal (string name, string description, int points, int target, int bonus) : base (name, description, points)
    {
        _amountComplete = 0;
        _target = target;
        _bonus = bonus;
    }
    public void SetAmountComplete(int amountCompete)
    {
        _amountComplete = amountCompete;
    }
    public override int RecordEvent()
    {
        _amountComplete = _amountComplete+1;
        if (IsComplete())
        {
            return _points + _bonus;
        }
        else
        {
            return _points;
        }
    }

    public override bool IsComplete()
    {
        if (_amountComplete >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        if(IsComplete())
        {
            return $"[X] {_shortName} ({_description}) -- Curently completed: {_amountComplete}/{_target})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) -- Curently completed: {_amountComplete}/{_target})";
        }
    }

    public override string GetStringRepresentation()
    {
        string goal = $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountComplete}";
        return goal;
    }
}