// Run() : void
// GetRandomPrompt() : string
// GetRandomQuestion() : string
// DisplayPrompt() : void
// DisplayQuestions() : void

// _prompts: List<string>
// _questions : List<string>

public class ReflectingActivity : Activities
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string desc) : base(name, desc)
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public string GetRandomPrompt()
    {
        Random temp = new Random();
        int index = temp.Next(0, _prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random temp = new Random();
        int index = temp.Next(0, _questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they are related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()}");
            ShowSpinner(10);
        }

        DisplayEndingMessage();

    }



}