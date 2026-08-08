public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string desc, int points)
    {
        _shortName = name;
        _description = desc;
        _points = points;
    }

    public virtual int RecordEvent()
    {
        Console.WriteLine("Something has gone wrong");
        return -1;
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{_points}";
    }

    public string GetName()
    {
        return _shortName;
    }
}