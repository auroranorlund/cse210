using System.IO.Compression;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private string _name = "";
    private int _level = 1;
    private int _pointsNeededForNextLevel = 0;
    private int _pointsToNextLevel = 0;

    public GoalManager(string name)
    {
        _name = name;
        _pointsNeededForNextLevel = _level * _level * 13;
        _pointsToNextLevel = _pointsNeededForNextLevel - _score;
    }

    public void Start()
    {
        DisplayPlayerInfo();
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player: {_name}");
        Console.WriteLine($"Level: {_level}");
        _pointsToNextLevel = _pointsNeededForNextLevel - _score;
        Console.WriteLine($"Points to the next level: {_pointsToNextLevel}");
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoals()
    {
        Console.WriteLine("Your goals are:");
        string details;
        int goalCount = 0;
        foreach (Goal g in _goals)
        {
            goalCount += 1;
            details = g.GetDetailsString();
            Console.WriteLine($"{goalCount}. {details}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("What type of goal would you like to create? ");
        string goalType = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        if (goalType == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points, "False");
            _goals.Add(goal);
        }
        if (goalType == "2")
        {
            EternalGoal goal = new EternalGoal(name, description, points, 0);
            _goals.Add(goal);
        }
        if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string target = Console.ReadLine();
            Console.Write("What is the point bonus for completing it that many times? ");
            string bonus = Console.ReadLine();

            ChecklistGoal goal = new ChecklistGoal(name, description, points, 0, target, bonus);
            _goals.Add(goal);
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish? ");
        string goalNumber = Console.ReadLine();
        int goalIndex = int.Parse(goalNumber);
        goalIndex = goalIndex - 1;
        Goal goal = _goals[goalIndex];
        if (goal.IsComplete() != true)
        {
            int points = goal.RecordEvent();
            _score = _score + points;
            if (_score >= _pointsNeededForNextLevel)
            {
                Console.WriteLine("Congratulations! You leveled up!");
                while (_score >= _pointsNeededForNextLevel)
                {
                    _level += 1;
                    _pointsNeededForNextLevel = _level * _level * 13;
                }
            }
        }
        else
        {
            Console.WriteLine("Sorry, you already completed this goal. Please add a new one or complete a different goal and try again.");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_level}|null|null|null");
            outputFile.WriteLine($"{_score}|null|null|null");
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        string levelLine = lines[0];
        string[] levelParts = levelLine.Split("|");
        _level = int.Parse(levelParts[0]);
        string scoreLine = lines[1];
        string[] scoreParts = scoreLine.Split("|");
        _score = int.Parse(scoreParts[0]);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            string goalType = parts[0];
            string name = parts[1];
            string description = parts[2];
            string points = parts[3];
            if (goalType == "SimpleGoal")
            {
                string isCompleted = parts[4];
                SimpleGoal goal = new SimpleGoal(name, description, points, isCompleted);
                _goals.Add(goal);
            }
            if (goalType == "EternalGoal")
            {
                int timesCompleted = int.Parse(parts[4]);
                EternalGoal goal = new EternalGoal(name, description, points, timesCompleted);
                _goals.Add(goal);
            }
            if (goalType == "ChecklistGoal")
            {
                int amountCompleted = int.Parse(parts[4]);
                string target = parts[5];
                string bonus = parts[6];
                ChecklistGoal goal = new ChecklistGoal(name, description, points, amountCompleted, target, bonus);
                _goals.Add(goal);
            }
        }
    }
}