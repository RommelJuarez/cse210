using System;
public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction() : this(1, 1) { }

    public Fraction(int wholeNumber) : this(wholeNumber, 1) { }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public override string ToString()
    {
        return $"{_numerator}/{_denominator} = {GetDecimalValue()}";
    }

    private double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}