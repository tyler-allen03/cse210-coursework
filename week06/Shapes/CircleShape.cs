
public class CircleShape : Shapes
{
    private double _radius;

    public CircleShape(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return 3.1415 * (_radius * _radius);
    }
}