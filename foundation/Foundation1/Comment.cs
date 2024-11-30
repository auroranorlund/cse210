public class Comment
{
    private string _author = "";
    private string _commentText = "";

    public Comment(string author, string commentText)
    {
        _author = author;
        _commentText = commentText;
    }
    public string GetDisplayText()
    {
        string text = $"{_author}: {_commentText}";
        return text;
    }
}