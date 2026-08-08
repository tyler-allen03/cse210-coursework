using System.IO;


public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {

        int menuChoice = 0;
        do
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goal");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit");
            Console.Write("Select a choice from the menu: ");
            string userchoice = Console.ReadLine();
            menuChoice = int.Parse(userchoice);

            if (menuChoice == 1)
            {
                CreateGoal();
            }
            else if (menuChoice == 2)
            {
                ListGoalDetails();
            }
            else if (menuChoice == 3)
            {
                SaveGoal();
            }
            else if (menuChoice == 4)
            {
                LoadGoal();
            }
            else if (menuChoice == 5)
            {
                RecordEvent();
            }

            Console.WriteLine();

        } while (menuChoice != 6);
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
        if (_score < 1000)
        {
            Console.WriteLine("You have not earned any titles.");
            Console.WriteLine("Collect 1000 points to earn a title!");
        }
        else if (_score < 2000)
        {
            Console.WriteLine("You have the Bronze Title! You are doing great!");
            Console.WriteLine("Collect 2000 points for the next title!");
        }
        else if (_score < 3500)
        {
            Console.WriteLine("You have the Silver Title! Keep it up!");
            Console.WriteLine("Collect 3500 points for the next Title!");
        }
        else if (_score < 6000)
        {
            Console.WriteLine("You have the Gold Title! You are Amaziang!");
            Console.WriteLine("Collect 6000 points for the next Title!");

        }
        else if (_score < 10000)
        {
            Console.WriteLine("You have the Platnium Title! Fantasic!");
            Console.WriteLine("Collect 10000 points for the next Title!");
        }
        else if (_score >= 10000)
        {
            Console.WriteLine("You have the Diamond Title! You are a Goal Master!");
            Console.WriteLine("You have earned the highest Title! Well Done!");
        }
    }

    public void ListGoalName()
    {
        int count = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.GetName()}");
            count++;
        }
    }
    public void ListGoalDetails()
    {
        int count = 1;
        foreach (Goal goal in _goals)
        {
            bool completed = goal.IsComplete();
            if (completed)
            {
                Console.WriteLine($"{count}. [X] {goal.GetDetailsString()}");
            }
            else
            {
                Console.WriteLine($"{count}. [ ] {goal.GetDetailsString()}");
            }
            count++;
        }


    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.Write("What type of goal would you like to create? ");
        string goalChoice = Console.ReadLine();
        int chosenGoal = int.Parse(goalChoice);
        if (chosenGoal == 1)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string desc = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string tempPoints = Console.ReadLine();
            int points = int.Parse(tempPoints);

            SimpleGoal simpGoal = new SimpleGoal(name, desc, points);
            _goals.Add(simpGoal);
        }
        else if (chosenGoal == 2)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string desc = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string tempPoints = Console.ReadLine();
            int points = int.Parse(tempPoints);

            EternalGoal eterGoal = new EternalGoal(name, desc, points);
            _goals.Add(eterGoal);
        }
        else if (chosenGoal == 3)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            Console.Write("What is a short description of it? ");
            string desc = Console.ReadLine();
            Console.Write("What is the amount of points associated with this goal? ");
            string tempPoints = Console.ReadLine();
            int points = int.Parse(tempPoints);
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string tempcompleTime = Console.ReadLine();
            int compleTime = int.Parse(tempcompleTime);
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string tempbonus = Console.ReadLine();
            int bonus = int.Parse(tempbonus);

            ChecklistGoal checkGoal = new ChecklistGoal(name, desc, points, compleTime, bonus);
            _goals.Add(checkGoal);
        }
    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalName();
        Console.Write("Which goal did you accomplish? ");
        string tempGoal = Console.ReadLine();
        int doneGoal = int.Parse(tempGoal) - 1;
        int earnedPoints = _goals[doneGoal].RecordEvent();
        Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
        _score += earnedPoints;
        Console.WriteLine($"You now have {_score} points");
    }
    public void SaveGoal()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoal()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts.Length == 4)
            {
                SimpleGoal simpGoal = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
                _goals.Add(simpGoal);
            }
            if (parts.Length == 3)
            {
                EternalGoal eterGoal = new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
                _goals.Add(eterGoal);
            }
            if (parts.Length == 6)
            {
                ChecklistGoal checkGoal = new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                _goals.Add(checkGoal);
            }
        }
    }
}