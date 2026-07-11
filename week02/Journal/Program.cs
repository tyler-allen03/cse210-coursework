// I figured that most people don't have the motivation to write so I added motivational text to go along with the promts


using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        int selectedChoice = -1;
        Journal journal = new Journal();

        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? (1-5) ");
            string userchoice = Console.ReadLine();
            selectedChoice = int.Parse(userchoice);
            if (selectedChoice == 1)
            {
                // Console.WriteLine("You selected write");
                PromtGenerator motivation = new PromtGenerator();
                string tempMotivation = motivation.GetRandomMotivation();
                Console.WriteLine("");
                Console.WriteLine(tempMotivation);
                Console.WriteLine("");

                PromtGenerator prompt = new PromtGenerator();
                string tempPrompt = prompt.GetRandomPromt();
                Console.WriteLine(tempPrompt);
                string userResponse = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();

                Entry response = new Entry();
                response._date = dateText;
                response._entryText = userResponse;
                response._promtText = tempPrompt;
                response._motivationText = tempMotivation;

                journal.AddEntry(response);
            }
            if (selectedChoice == 2)
            {
                // Console.WriteLine("You selected Display");
                journal.DisplayAll();
            }
            if (selectedChoice == 3)
            {
                // Console.WriteLine("You selected Load");
                Console.WriteLine("What is the filename");
                string enteredFilename = Console.ReadLine();
                journal.LoadFromFile(enteredFilename);
            }
            if (selectedChoice == 4)
            {
                // Console.WriteLine("You selected Save");
                Console.WriteLine("What is the filename");
                string enteredFilename = Console.ReadLine();
                journal.SaveToFile(enteredFilename);
            }

        } while (selectedChoice != 5);
    }
}