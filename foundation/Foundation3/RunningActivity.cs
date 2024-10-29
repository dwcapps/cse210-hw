public class RunningActivity : Activity
{
    double _distance;

    public RunningActivity(double duration, double distance) : base(duration)
    {
        _distance = distance;
        _name = "Running";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _duration;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}