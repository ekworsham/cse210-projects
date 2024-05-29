public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comment = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comment = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comment.Add(comment);
    }
    public void Display()
    {
        Console.WriteLine ($"Title: {_title}, Author: {_author}, Seconds: {_length}, Number of comments: {_comment.Count}"); 

        foreach (Comment comment in _comment)
        {
            comment.Display();
        }

    }

}