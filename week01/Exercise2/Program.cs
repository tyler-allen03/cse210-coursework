using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("");

        string letterGrade;
        string letterSign = "";

        Console.Write("Please enter your grade here: ");
        string usersGrade = Console.ReadLine();
        int grade = int.Parse(usersGrade);

        int gradeFloat = grade % 10;


        if ((grade < 93) && (grade >= 60))
        {
            if (gradeFloat >= 7)
            {
                letterSign = "+";
            }
            else if (gradeFloat < 3)
            {
                letterSign = "-";
            }
        }

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        Console.WriteLine($"Your Grade: {letterGrade}{letterSign}");

        bool passed = false;
        if (grade >= 70)
        {
            passed = true;
        }

        if (passed)
        {
            Console.WriteLine("Congradulations, You Passed!");
        }
        else
        {
            Console.WriteLine("Sorry, You'll do better Next Time!");
        }

    }
}