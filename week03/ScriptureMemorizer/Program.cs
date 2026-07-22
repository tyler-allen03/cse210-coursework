// Do add creativity I added a part of the program that requires the user to enter the full scripture without the underscores. I added a method to the scriptures class that will return the unaltered text to be compaired to, whilest allowing the program to remember what words have been hidden. I did this because when memorizing a scripture it is often best to repeat the scripture while progressing though the hiding system.

//***NEW***
// I took out the privious addition where the user would enter the scripture after each cycle, and instead added a few more verses that can appear each time someone boots the program to hopefully better follow the rubric

using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        string userInput = "";

        List<string> books = new List<string>();
        List<int> chapers = new List<int>();
        List<int> startVerse = new List<int>();
        List<int> endVerse = new List<int>();
        List<string> verse = new List<string>();

        books.Add("Alma");
        chapers.Add(37);
        startVerse.Add(6);
        endVerse.Add(6);
        verse.Add("Now ye may suppose that this is foolishness in me; but behold I say unto you, that by small and simple things are great things brought to pass; and small means in many instances doth confound the wise.");

        books.Add("Ether");
        chapers.Add(12);
        startVerse.Add(27);
        endVerse.Add(27);
        verse.Add("And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");

        books.Add("D&C");
        chapers.Add(84);
        startVerse.Add(81);
        endVerse.Add(85);
        verse.Add("Therefore, take ye no thought for the morrow, for what ye shall eat, or what ye shall drink, or wherewithal ye shall be clothed. For, consider the lilies of the field, how they grow, they toil not, neither do they spin; and the kingdoms of the world, in all their glory, are not arrayed like one of these. For your Father, who is in heaven, knoweth that you have need of all these things. Therefore, let the morrow take thought for the things of itself. Neither take ye thought beforehand what ye shall say; but treasure up in your minds continually the words of life, and it shall be given you in the very hour that portion that shall be meted unto every man.");


        Random randomGenerator = new Random();
        int indexNum = randomGenerator.Next(0, books.Count());

        Reference reference = new Reference(books[indexNum], chapers[indexNum], startVerse[indexNum], endVerse[indexNum]);
        Scripture scripture = new Scripture(reference, verse[indexNum]);


        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            userInput = Console.ReadLine();

            scripture.HideRandomWords(3);
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                break;
            }

        } while (userInput != "quit");
    }
}