public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string desc, int points) : base(name, desc, points)
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string desc, int points, bool completed) : base(name, desc, points)
    {
        _isComplete = completed;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}