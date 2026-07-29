public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string textbook, string problem, string name, string topic) : base(name, topic)
    {
        _textbookSection = textbook;
        _problems = problem;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} - Problems {_problems}";
    }
}