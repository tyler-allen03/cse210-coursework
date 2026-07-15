using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fractions test1 = new Fractions();
        Fractions test2 = new Fractions(5);
        Fractions test3 = new Fractions(2, 3);


        Console.WriteLine(test1.getFractionString());
        Console.WriteLine(test2.getFractionString());
        Console.WriteLine(test3.getFractionString());

        Console.WriteLine(test1.getDecimalValue());
        Console.WriteLine(test2.getDecimalValue());
        Console.WriteLine(test3.getDecimalValue());
        
    }
}