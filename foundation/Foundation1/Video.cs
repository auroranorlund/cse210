public class Video
{
    private string _title = "";
    private string _author = "";
    private int _lengthInSeconds = 0;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }
    
    public void AddComment(string author, string commentText)
    {
        Comment comment = new Comment(author, commentText);
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        int length = _comments.Count();
        return length;
    }

    public void DisplayText()
    {
        string text = "";
        int commentNumber = GetNumberOfComments();
        Console.WriteLine($"{_title} by {_author}, {_lengthInSeconds} seconds");
        Console.WriteLine($"{commentNumber} comments");
        foreach (Comment c in _comments)
        {
            text = c.GetDisplayText();
            Console.WriteLine(text);
        }
    }
}