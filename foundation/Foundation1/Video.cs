public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public int NumOfComments()
    {
        return _comments.Count;
    }

    public void AddComment(string commentAuthor, string commentText)
    {
        _comments.Add(new Comment(commentAuthor, commentText));
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author}\nLength: {_length} Seconds\nNumber of Comments: {NumOfComments()}");
        foreach (Comment comment in _comments)
        {
           comment.DisplayComment();
        }
        Console.WriteLine("");
    }
}