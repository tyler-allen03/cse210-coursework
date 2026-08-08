// to show creativity I added some text that is based off of the score the user gets, just so that there was a use for recieving more points and to help motivate users to continue achiving their goals.


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");

        GoalManager goalProgram = new GoalManager();
        goalProgram.Start();
    }
}