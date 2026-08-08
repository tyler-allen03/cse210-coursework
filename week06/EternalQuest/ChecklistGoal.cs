public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string desc, int points, int target, int bonus) : base(name, desc, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string desc, int points, int completed, int target, int bonus) : base(name, desc, points)
    {
        _amountCompleted = completed;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted += 1;
        int returnamount = _points;
        if (_amountCompleted == _target)
        {
            returnamount += _bonus;
        }
        return returnamount;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
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
        return $"{_shortName}: {_description} -- Times Completed {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}