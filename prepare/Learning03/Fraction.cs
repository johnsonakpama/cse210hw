using System;

public class Fraction
{
   private int _top;
    private int _button;

    public Fraction()
    {
        // default to 1/1

        _top = 1;
        _button = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _button = 1;
    }

    public Fraction(int top, int button)
    {
        _top = top;
        _button = button;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_button}";
        return text;
    }

    public double GetDecimalValue()
    {
         return (double)_top / (double)_button;

    }




}