using System.Net;
using System.Reflection;

class Video
{
    private string _title;
    private string _author;
    private int _time;
    private List<Comment> _comments;

    public Video(string title, string author, int time, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _time = time;
        _comments = comments;
    }

    public int GetNumberOfComments()
    {
        return _comments.Count();
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetTime()
    {
        return _time;
    }

    public string GetComments()
    {
        string returnString = "";

        foreach(Comment comment in _comments)
        {
            string tempName = comment.GetCommentName();
            string tempComment = comment.GetCommentComment();

            returnString += $"{tempName} - {tempComment}.\n";
        }

        return returnString;
    }
}