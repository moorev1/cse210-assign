// Comment.cs
// Comment class definition
class Comment
{
    private string commenter;
    private string text;

    public Comment(string commenter, string text)
    {
        this.commenter = commenter;
        this.text = text;
    }

    public string Commenter { get { return commenter; } }
    public string Text { get { return text; } }
}
