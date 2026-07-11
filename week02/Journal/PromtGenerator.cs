// method 1 - select a promt from the list of promts and display the prompt
// attribute 1 - string - a list of promts for the program to ask the user

public class PromtGenerator
{
    public List<string> _promts = new List<string> { "What was my favorite thing about todady?", "Who did I talk to today?", "What is one thing I learned today?", "Was there anything that I regret from today?" };
    public List<string> _motivations = new List<string> { "This can be the best part of your day!", "You Got This!", "Don't stress, if this makes sense to you then this makes sense to me!", "Even a single word counts!" };

    public PromtGenerator()
    {
    }
    public string GetRandomPromt()
    {
        Random randomGenerator = new Random();
        int promtIndex = randomGenerator.Next(0, _promts.Count());
        string selectedPrompt = _promts[promtIndex];
        return selectedPrompt;
    }

    public string GetRandomMotivation()
    {
        Random randomGenerator = new Random();
        int motivationIndex = randomGenerator.Next(0, _motivations.Count());
        string selectedPrompt = _motivations[motivationIndex];
        return selectedPrompt;
    }
}