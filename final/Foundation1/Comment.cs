using System;

public class Comment
{
    public string _name;
    public List<Text> _text = new List<Text>();

    public void Display()
    {
        Console.WriteLine($"Name:{_name}, Text: {_text}");

        foreach (Text text in Text)
        {
            text.Display();
        }
    }
}