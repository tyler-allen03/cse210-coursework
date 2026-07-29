using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment student1 = new Assignment("Billy Bob", "English");
        Console.WriteLine(student1.GetSummary());
        Console.WriteLine("");

        MathAssignment student2 = new MathAssignment("6.5", "8-15", "Samwell Jackson", "Science");
        Console.WriteLine(student2.GetSummary());
        Console.WriteLine(student2.GetHomeworkList());
        Console.WriteLine("");

        WritingAssignment studnet3 = new WritingAssignment("Who Killed Sonic", "Arin Hanson", "Gaming");
        Console.WriteLine(studnet3.GetSummary());
        Console.WriteLine(studnet3.GetWritingInformation());










    }

}