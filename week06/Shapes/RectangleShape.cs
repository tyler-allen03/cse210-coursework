
public class RectangleShape : Shapes
{
    private double _longSide;
    private double _shortSide;

    public RectangleShape(string color, double length, double width) : base(color)
    {
        _longSide = length;
        _shortSide = width;
    }

    public override double GetArea()
    {
        return _longSide * _shortSide;
    }
}