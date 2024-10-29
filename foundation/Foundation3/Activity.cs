public class Activity
{
    string _date = DateTime.Today.ToString("dd MMM yyyy");
    protected double _duration;
    protected string _name;

    public Activity(double duration)
    {
        _duration = duration / 60;
    }

    // I'd just make these 3 functions abstract, but the description specifically says virtual. 
    public virtual double GetDistance()
    {
        return GetSpeed() * _duration;
    }

    public virtual double GetSpeed()
    {
        return 60 / GetPace();
    }

    public virtual double GetPace()
    {
        return 60 / GetSpeed();
    }



    public string GetSummary()
    {
        return $"{_date} {_name} ({_duration * 60} min)- Distance {GetDistance():0.00} miles, Speed {GetSpeed():0.00} mph, Pace: {GetPace():0.00} min per mile";
    }
}