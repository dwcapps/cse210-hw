public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>{
                                                        "Who are people that you appreciate?",
                                                        "What are personal strengths of yours?",
                                                        "Who are people that you have helped this week?",
                                                        "When have you felt the Holy Ghost this month?",
                                                        "Who are some of your personal heroes?"
                                                    };
    private int _count = 0;
    private Random _random = new Random();
    private HashSet<int> _usedPromptIndices = new HashSet<int>();

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Write($"List as many responses as you can to the following prompt:\n--- {GetRandomPrompt()} ---\nYou may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();

        GetListFromUser();
        
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine();
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        if (_usedPromptIndices.Count >= _prompts.Count)
        {
            return "Error: Out of Prompts.";
        }

        int randomIndex;
        do
        {
            randomIndex = _random.Next(0, _prompts.Count);
        }
        while (_usedPromptIndices.Contains(randomIndex));

        _usedPromptIndices.Add(randomIndex);
        return _prompts[randomIndex];
    }

    private List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> answers = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            answers.Add(Console.ReadLine());
            _count++;
        }
        return answers;
    }
}