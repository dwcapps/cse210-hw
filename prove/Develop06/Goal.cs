public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points; // Class diagram says this should be a string, I'm assuming that's an error?

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent(); // Class diagram says this should not return a value, but the description of the method says it should return the rewarded point value. 
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    public virtual string GetDetailsString()
    {
        string checkbox = "[ ]";
        if (IsComplete())
        {
            checkbox = "[X]";
        }
        return $"{checkbox} {_shortName} ({_description})";
    }

    public string GetShortName() // Not in class diagram, but necessary for the GoalManager.ListGoalNames() method.
    {
        return _shortName;
    }

    public int GetPoints() // Part of Stretch Goal.
    {
        return _points;
    }
}