public class SwimmingActivity : Activity
{
    double _numOfLaps;

    public SwimmingActivity(double duration, double numOfLaps) : base(duration)
    {
        _numOfLaps = numOfLaps;
        _name = "Swimming";
    }

    public override double GetDistance()
    {
        return _numOfLaps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _duration;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}