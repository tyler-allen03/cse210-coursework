// method 1 - select a promt from the list of promts and display the prompt
// attribute 1 - string - a list of promts for the program to ask the user

public class PromptGenerator
{
    public List<string> _prompts = new List<string> { "What was my favorite thing about todady?", "Who did I talk to today?", "What is one thing I learned today?", "Was there anything that I regret from today?" };
    public List<string> _motivations = new List<string> { "This can be the best part of your day!", "You Got This!", "Don't stress, if this makes sense to you then this makes sense to me!", "Even a single word counts!" };

    public PromptGenerator()
    {
    }
    public string GetRandomPromt()
    {
        Random randomGenerator = new Random();
        int promptIndex = randomGenerator.Next(0, _prompts.Count());
        string selectedPrompt = _prompts[promptIndex];
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