// Run() : void

public class BreathingActivity : Activities
{
    public BreathingActivity(string name, string desc) : base(name, desc)
    {

    }
    
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in... ");
            ShowCountDown(4);
            Console.WriteLine();

            Console.WriteLine("Now breathe out... ");
            ShowCountDown(6);
            Console.WriteLine();
        }

        DisplayEndingMessage();

    }
}