public class EternalGoal : Goal
{
    private int _timesCompleted = 0;
    public EternalGoal(string name, string description, string points, int timesCompleted) : base(name, description, points)
    {
        _timesCompleted = timesCompleted;
    }

    public override int RecordEvent()
    {
        _timesCompleted += 1;
        Console.WriteLine($"Congratulations! You have earned {_points} points.");
        int points = int.Parse(_points);
        return points;
    }

    public override bool IsComplete()
    {
        bool complete = false;
        return complete;
    }

    public override string GetDetailsString()
    {
        string details = base.GetDetailsString();
        details = $"{details} Times completed: {_timesCompleted}";
        return details;
    }

    public override string GetStringRepresentation()
    {
        string representation = $"EternalGoal|{_shortName}|{_description}|{_points}|{_timesCompleted}";
        return representation;
    }

}