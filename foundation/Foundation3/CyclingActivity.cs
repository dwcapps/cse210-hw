public class CyclingActivity : Activity
{
    double _speed;

    public CyclingActivity(double duration, double speed) : base(duration)
    {
        _speed = speed;
        _name = "Cycling";
    }

    public override double GetDistance()
    {
        return _speed * _duration;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}