public class Running : Activity
{
    private double _distance;

    public Running(string date, int lengthMinutes, double distance) : base(date, lengthMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        double distance = _distance;
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = (_distance / _lengthMinutes) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double speed = GetSpeed();
        double pace = 60 / speed;
        return pace;
    }

    public override string GetActivityType()
    {
        string type = "Running";
        return type;
    }

}