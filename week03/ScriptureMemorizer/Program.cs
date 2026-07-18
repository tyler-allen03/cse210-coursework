// Do add creativity I added a part of the program that requires the user to enter the full scripture without the underscores. I added a method to the scriptures class that will return the unaltered text to be compaired to, whilest allowing the program to remember what words have been hidden. I did this because when memorizing a scripture it is often best to repeat the scripture while progressing though the hiding system.

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        string userInput = "";

        Reference alma = new Reference("Alma", 37, 6);
        Scripture scripture = new Scripture(alma, "Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise.");


        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter the full scripture to continue or type 'quit' to finish:"); 
            do
            {
                userInput = Console.ReadLine() + " ";
                if (userInput == "quit ")
                {
                    break;
                }
                if (userInput != scripture.GetFullScripture())
                {
                    Console.Clear();
                    Console.WriteLine(scripture.GetDisplayText());
                    Console.WriteLine();
                    Console.WriteLine("Sorry, that is incorrect, please try again.");
                }
            } while (userInput != scripture.GetFullScripture());
            scripture.HideRandomWords(3);
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }

        } while (userInput != "quit ");
    }
}