// DisplayStartingMessage() : void
// DisplayEndingMessage() : void
// ShowSpinner(seconds: int) : void
// ShowCountDown(second: int) : void

// _name: string
// _description : string
// _duration : int

public class Activities
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activities(string name, string desc)
    {
        _name = name;
        _description = desc;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        string requestTime = Console.ReadLine();
        _duration = int.Parse(requestTime);

        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(3);
        Console.WriteLine("");
    }

    public void DisplayEndingMessage()
    {

        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");        
        ShowSpinner(5);
    }

    public void ShowSpinner(int time)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        int count = 0;

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        while (DateTime.Now < endTime)
        {
            string i = animation[count];
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            count++;
            if (count >= animation.Count)
            {
                count = 0;
            }
        }


    }

    public void ShowCountDown(int time)
    {
        for (int i = time; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}