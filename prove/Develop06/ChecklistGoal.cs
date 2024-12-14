using System.Security.Cryptography.X509Certificates;

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;
    public ChecklistGoal(string name, string description, string points, int amountCompleted, string target, string bonus) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        int targetNumber = int.Parse(target);
        _target = targetNumber;
        int bonusAmount = int.Parse(bonus);
        _bonus = bonusAmount;
    }

    public override int RecordEvent()
    {
        int points = int.Parse(_points);
        _amountCompleted += 1;
        if(IsComplete() == true)
        {
            int earned = points + _bonus;
            Console.WriteLine($"Congratulations! You earned {earned} points.");
            return earned;
        }
        else
        {
            Console.WriteLine($"Congratulations! You earned {_points} points.");
            return points;
        }
    }

    public override bool IsComplete()
    {
        bool complete = false;
        if(_amountCompleted == _target)
        {
            complete = true;
        }
        return complete;
    }

    public override string GetDetailsString()
    {
        string details = base.GetDetailsString();
        details = $"{details} -- Currently completed: {_amountCompleted}/{_target}";
        return details;
    }

    public override string GetStringRepresentation()
    {
        bool complete = IsComplete();
        string representation = $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
        return representation;
    }
}