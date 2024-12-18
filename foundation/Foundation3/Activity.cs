public class Activity
{
    private string _date;
    protected int _lengthMinutes;
    
    public Activity(string date, int lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }
    public virtual double GetDistance()
    {
        double distance = 0;
        return distance;
    }

    public virtual double GetSpeed()
    {
        double speed = 0;
        return speed;
    }

    public virtual double GetPace()
    {
        double pace = 0;
        return pace;
    }

    public virtual string GetActivityType()
    {
        string type = "";
        return type;
    }

    public string GetSummary()
    {
        string distance = GetDistance().ToString("0.00");
        string speed = GetSpeed().ToString("0.00");
        string pace = GetPace().ToString("0.00");
        string activityType = GetActivityType();
        string summary = $"{_date} {activityType} ({_lengthMinutes} minutes) - Distance {distance} miles, Speed {speed} mph, Pace: {pace} min per mile";
        return summary;
    }
}