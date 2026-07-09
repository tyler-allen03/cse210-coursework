using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Console.WriteLine("");
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2025;
        job1._endYear = 2026;

        job1.DisplayJobDetails();

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Janitor";
        job2._startYear = 2025;
        job2._endYear = 2026;

        job2.DisplayJobDetails();

        Resume resume1 = new Resume();
        resume1._name = "Tyler";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayDetails();
    }
}