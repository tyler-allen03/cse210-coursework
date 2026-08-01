// Run() : void
// GetRandomPrompt() : string
// GetListFromUser() : List<string>

// _count: int
// _prompts : List<string>

public class StretchingActivity : Activities
{
    private List<string> _prompts = new List<string>();

    public StretchingActivity(string name, string desc) : base(name, desc)
    {
        _prompts.Add("Stretch as High as you can.");
        _prompts.Add("Touch your toes.");
        _prompts.Add("Do some neck rolls.");
        _prompts.Add("Do some arm circles.");
        _prompts.Add("Hold your sholders back.");
    }

    public string GetRandomPrompt()
    {
        Random temp = new Random();
        int index = temp.Next(0, _prompts.Count);
        return _prompts[index];
    }


    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Stand up and get in a position where you can safely stretch.");
        Console.Write("You may begin in: ");
        ShowCountDown(9);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomPrompt());
            ShowCountDown(9);
            Console.WriteLine();
        }

        DisplayEndingMessage();

    }


}