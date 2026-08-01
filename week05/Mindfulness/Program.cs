// To show some creativity I added another activity that the user can select.


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        int userChoice = 0;

        BreathingActivity activity1 = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectingActivity activity2 = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingActivity activity3 = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        StretchingActivity activity4 = new StretchingActivity("Stretching", "This activity will help you relax your musles by walking you through some stretches that you can perform anywhere, and will generally help with aches.");
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Start stretching activity");
            Console.WriteLine("   5. Quit");
            Console.Write("Select a choice from the menu: ");
            string tempChoice = Console.ReadLine();
            userChoice = int.Parse(tempChoice);

            if (userChoice == 1)
            {
                activity1.Run();
            }
            if (userChoice == 2)
            {
                activity2.Run();
            }
            if (userChoice == 3)
            {
                activity3.Run();
            }
            if (userChoice == 4)
            {
                activity4.Run();
            }

        } while (userChoice != 5);
    }
}










