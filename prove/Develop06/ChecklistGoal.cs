public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override string GetDetailsString()
    {
        string checkbox = "[ ]";
        if (IsComplete())
        {
            checkbox = "[X]";
        }
        return $"{checkbox} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override int RecordEvent()
    {
        int points = _points;
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            points += _bonus;
        }
        Console.WriteLine($"Congratulations! You have earned {points} points!");
        return points;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal·{_shortName}·{_description}·{_points}·{_amountCompleted}·{_target}·{_bonus}";
    }

    public void SetAmountCompleted(int amount) // Not in class diagram, but necessary for the GoalManager.LoadGoals() method.
    {
        _amountCompleted = amount;
    }
}