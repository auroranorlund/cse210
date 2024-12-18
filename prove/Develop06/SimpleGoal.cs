public class SimpleGoal : Goal
{
    private bool _isComplete = false;
    public SimpleGoal(string name, string description, string points, string isCompleted) : base(name, description, points)
    {
        if (isCompleted == "True")
        {
            _isComplete = true;
        }
    }
    public override int RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You earned {_points} points");
        int points = int.Parse(_points);
        return points;
    }

    public override bool IsComplete()
    {
        bool complete = _isComplete;
        return complete;
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}