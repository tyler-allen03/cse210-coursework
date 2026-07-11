// method 1 - Display the entry
// attribute 1 - string - date
// attribute 2 - string - promt
// attribute 3 - string - entry

public class Entry
{
    public string _date;
    public string _promtText;
    public string _entryText;
    public string _motivationText;

    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine("");
        Console.WriteLine($"{_date} - Promt: {_promtText} - Motivation: {_motivationText}");
        Console.WriteLine(_entryText);
        Console.WriteLine("");
    }
}