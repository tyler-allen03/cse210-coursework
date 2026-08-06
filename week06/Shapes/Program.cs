using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        SquareShape square = new SquareShape("Silver", 4.5);

        Console.WriteLine(square.GetArea());
        Console.WriteLine(square.GetColor());

        RectangleShape rectangle = new RectangleShape("black", 3, 4);
        CircleShape circle = new CircleShape("white", 2);

        Console.WriteLine(rectangle.GetArea());
        Console.WriteLine(rectangle.GetColor());

        Console.WriteLine(circle.GetArea());
        Console.WriteLine(circle.GetColor());

        Console.WriteLine();
        Console.WriteLine("Loop Incoming");
        Console.WriteLine();

        List<Shapes> shapes = new List<Shapes>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shapes shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetColor());
        }
    }
}