using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        string response;



        do
        {
            Random randomGenerator = new Random();
            int secretNumber = randomGenerator.Next(1, 100);

            int guesses = 0;
            int guess;


            do
            {
                Console.WriteLine("");
                Console.Write("What is your guess? ");
                string userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);
                guesses++;

                if (guess > secretNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You Got It!");
                }

            } while (guess != secretNumber);

            Console.WriteLine("");

            Console.WriteLine($"It took you {guesses} guesses to get it.");
            Console.WriteLine("");

            Console.Write("Do you want to replay? ");
            response = Console.ReadLine();
        } while (response == "yes");
    }
}