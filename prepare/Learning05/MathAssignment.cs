public class MathAssignment : Assignment
{
    string _textbookSection;
    string _problems;

    public MathAssignment(string textbookSection, string problems, string name, string topic) : base(name, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection}, Problems {_problems}";
    }
}