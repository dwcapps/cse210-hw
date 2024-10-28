public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal·{_shortName}·{_description}·{_points}·{_isComplete}";
    }

    public void SetCompleted(bool completed) // Not in class diagram, but necessary for the GoalManager.LoadGoals() method.
    {
        _isComplete = completed;
    }
}