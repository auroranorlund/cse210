public class Cycling : Activity
{
    private double _speed;

    public Cycling(string date, int lengthMinutes, double speed) : base(date, lengthMinutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double lengthHour = _lengthMinutes;
        lengthHour = lengthHour / 60;
        double distance = _speed * lengthHour;
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = _speed;
        return speed;
    }

    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }

    public override string GetActivityType()
    {
        string type = "Cycling";
        return type;
    }
}