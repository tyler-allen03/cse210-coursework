using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();

        int newNumber = -1;

        while (newNumber != 0)
        {
            Console.Write("Enter Number: ");
            string userNumber = Console.ReadLine();
            newNumber = int.Parse(userNumber);
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        }

        int totalCount = 0;
        foreach (int number in numbers)
        {
            totalCount = totalCount + number;
        }

        Console.WriteLine($"The sum is: {totalCount}");

        float average = totalCount / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int largestNumber = 0;
        foreach (int number in numbers)
        {
            if (number > largestNumber)
            {
                largestNumber = number;
            }
        }

        Console.WriteLine($"The largest number is: {largestNumber}");

        int smallestPositiveNumber = 1000000000;
        foreach (int number in numbers)
        {
            if ((number < smallestPositiveNumber) && number > 0)
            {
                smallestPositiveNumber = number;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");

        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}