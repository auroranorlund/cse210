public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int lengthMinutes, int laps) : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        double distance = _laps * 50;
        distance = distance / 1000;
        distance = distance * 0.62;
        return distance;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        double speed = (distance / _lengthMinutes) * 60;
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
        string type = "Swimming";
        return type;
    }
}