// Run() : void
// GetRandomPrompt() : string
// GetListFromUser() : List<string>

// _count: int
// _prompts : List<string>

public class ListingActivity : Activities
{
    private int _count;

    private List<string> _userList = new List<string>();
    private List<string> _prompts = new List<string>();

    public ListingActivity(string name, string desc) : base(name, desc)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public string GetRandomPrompt()
    {
        Random temp = new Random();
        int index = temp.Next(0, _prompts.Count);
        return _prompts[index];
    }

    public string GetUserInput()
    {
        Console.Write("> ");
        string userInput = Console.ReadLine();
        _userList.Add(userInput);
        return userInput;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            GetUserInput();
            _count++;
        }

        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();

    }

    
}