using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        Console.WriteLine("");
        DisplayWelcome();
        string givenName = PromptUserName();
        int givenNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(givenNumber);
        DisplayResult(givenName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please Enter Your Name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please Enter Your Favorite Number: ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);
        return number;
    }

    static int SquareNumber(int number)
    {
        int sqNumber = number * number;
        return sqNumber;
    }

    static void DisplayResult(string userName, int userNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {userNumber}");
    }

}