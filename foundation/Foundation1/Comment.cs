public class Comment
{
    private string _text;
    private string _author;

    public Comment(string author, string text)
    {
        _author = author;
        _text = text;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_author}: {_text}");
    }
}