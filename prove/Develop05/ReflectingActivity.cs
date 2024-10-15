public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>    {
                                                        "Think of a time when you stood up for someone else.",
                                                        "Think of a time when you did something really difficult.",
                                                        "Think of a time when you helped someone in need.",
                                                        "Think of a time when you did something truly selfless."
                                                        };
    private List<string> _questions = new List<string> {
                                                        "Why was this experience meaningful to you?",
                                                        "How did you get started?",
                                                        "Have you ever done anything like this before?",
                                                        "How did you feel when it was complete?",
                                                        "What made this time different than other times when you were not as successful?",
                                                        "What is your favorite thing about this experience?",
                                                        "What could you learn from this experience that applies to other situations?",
                                                        "What did you learn about yourself through this experience?",
                                                        "How can you keep this experience in mind in the future?"
                                                        };

    private Random _random = new Random();
    private HashSet<int> _usedPromptIndices = new HashSet<int>();
    private HashSet<int> _usedQuestionIndices = new HashSet<int>();
    private int _numRequestedQuestions;


    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        Console.Clear();
        DisplayQuestions();
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

    private string GetRandomQuestion()
    {
        if (_usedQuestionIndices.Count >= _questions.Count)
        {
            return "Error: Out of Questions.";
        }

        int randomIndex;
        do
        {
            randomIndex = _random.Next(0, _questions.Count);
        }
        while (_usedQuestionIndices.Contains(randomIndex));

        _usedQuestionIndices.Add(randomIndex);
        return _questions[randomIndex];
    }

    private void DisplayPrompt()
    {
        Console.Write($"Consider the following prompt:\n\n--- {GetRandomPrompt()} ---\n\nNext, how many questions would you like to see? ");
        _numRequestedQuestions = int.Parse(Console.ReadLine());
        Console.Write("Now ponder on each of the following questions as they related to this experience.\nYou may begin in: ");
        ShowCountdown(5);
    }

    private void DisplayQuestions()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int questionsAsked = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()} ");
            questionsAsked++;
            ShowSpinner(_duration / _numRequestedQuestions);
            Console.WriteLine();
        }
    }
}