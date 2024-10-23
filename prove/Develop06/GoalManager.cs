using System.ComponentModel;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    private static string _mainMenu = @"
Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Delete Goal
    7. Quit
Select a choice from the menu: ";
    private static string _goalMenu = @"
The types of Goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
Which type of goal would you like to create? ";

    public GoalManager()
    {

    }

    public void Start()
    {
        int userMenuSelection = 0;
        while (userMenuSelection != 6)
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.Write(_mainMenu);
            userMenuSelection = int.Parse(Console.ReadLine());
            switch (userMenuSelection)
            {
                case 1:
                    CreateGoal();
                    break;

                case 2:
                    ListGoalDetails();
                    break;

                case 3:
                    SaveGoals();
                    break;

                case 4:
                    LoadGoals();
                    break;

                case 5:
                    RecordEvent();
                    break;

                case 6:
                    DeleteGoal();
                    break;
                
                case 7:
                    break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine();
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. " + _goals[i].GetShortName());
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. " + _goals[i].GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.Write(_goalMenu);
        int userGoalSelection = int.Parse(Console.ReadLine());
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int goalPoints = int.Parse(Console.ReadLine());

        switch (userGoalSelection)
        {
            case 1:
                SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
                _goals.Add(simpleGoal);
                break;
            case 2:
                EternalGoal eternalGoal = new EternalGoal(goalName, goalDescription, goalPoints);
                _goals.Add(eternalGoal);
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int goalTarget = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that many times? ");
                int goalBonus = int.Parse(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);
                _goals.Add(checklistGoal);
                break;
        }
    }

    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int accomplishedGoalIndex = int.Parse(Console.ReadLine()) - 1;
        _score += _goals[accomplishedGoalIndex].RecordEvent();
        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Count(); i++)
        {
            string[] parts = lines[i].Split('·');
            string goalType = parts[0];
            string goalName = parts[1];
            string goalDescription = parts[2];
            int goalPoints = int.Parse(parts[3]);

            switch (goalType)
            {
                case "SimpleGoal":
                    string goalIsComplete = parts[4];
                    _goals.Add(new SimpleGoal(goalName, goalDescription, goalPoints));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(goalName, goalDescription, goalPoints));
                    break;
                case "ChecklistGoal":
                    int goalAmountCompleted = int.Parse(parts[4]);
                    int goalTarget = int.Parse(parts[5]);
                    int goalBonus = int.Parse(parts[6]);
                    ChecklistGoal goal = new ChecklistGoal(goalName, goalDescription, goalPoints, goalTarget, goalBonus);
                    goal.SetAmountCompleted(goalAmountCompleted);
                    _goals.Add(goal);
                    break;
            }
        }
    }

    public void DeleteGoal() // Part of Stretch Goal
    {
        ListGoalNames();
        Console.Write("Which goal would you like to delete? ");
        Goal deletedGoal = _goals[int.Parse(Console.ReadLine()) - 1];
        if ((deletedGoal is not EternalGoal) && !deletedGoal.IsComplete()) // If a goal is never meant to be completed, you can't really give up on it. // If you already completed the goal, you shouldn't recieve a penalty.
        {
            _score -= deletedGoal.GetPoints(); // Applies penalty for "giving up" on your goal. 
            Console.WriteLine($"Penalty applied. You now have {_score} points.");
        }
        _goals.Remove(deletedGoal);
    }
}