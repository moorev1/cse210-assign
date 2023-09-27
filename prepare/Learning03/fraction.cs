using System;

public class Fraction
{
    private int numerator;
    private int denominator;

    // Constructor with no parameters
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor with one parameter for the top
    public Fraction(int top)
    {
        numerator = top;
        denominator = 1;
    }

    // Constructor with two parameters for both top and bottom
    public Fraction(int top, int bottom)
    {
        numerator = top;
        SetDenominator(bottom);
    }

    // Getter and Setter for the top number
    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; }
    }

    // Getter and Setter for the bottom number
    public int Denominator
    {
        get { return denominator; }
        set { SetDenominator(value); }
    }

    private void SetDenominator(int value)
    {
        if (value != 0)
            denominator = value;
        else
            throw new ArgumentException("Denominator cannot be zero.");
    }

    // Method to return the fraction representation as a string
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Method to return the decimal representation of the fraction
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}