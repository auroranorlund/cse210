public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string checkmark = " ";
        bool complete = IsComplete();
        if (complete == true)
        {
            checkmark = "✓";
        }
        string details = $"[{checkmark}] {_shortName} ({_description})";
        return details;
    }

    public virtual string GetStringRepresentation()
    {
        bool complete = IsComplete();
        string representation = $"SimpleGoal|{_shortName}|{_description}|{_points}|{complete}";
        return representation;
    }
}