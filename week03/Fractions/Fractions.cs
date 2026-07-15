public class Fractions
{
    private int _numerator;
    private int _denominator;

    public Fractions()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fractions(int wholeNum)
    {
        _denominator = 1;
        _numerator = wholeNum;
    }

    public Fractions(int topNum, int bottumNum)
    {
        _denominator = bottumNum;
        _numerator = topNum;
    }

    public void GetTop()
    {
        Console.WriteLine(_numerator);
    }

    public void SetTop(int num)
    {
        _numerator = num;
    }

    public void GetBottom()
    {
        Console.WriteLine(_denominator);
    }

    public void SetBottom(int num)
    {
        _denominator = num;
    }

    public string getFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public double getDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }
}