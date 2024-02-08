using System;
using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    private int _top;
    private int _bottom;

    // 1/1 fraction
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // whole number (2/1 = 2)
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // typical fraction (1/2 = 0.5)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fractionValue = $"{_top}/{_bottom}";

        return fractionValue;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}