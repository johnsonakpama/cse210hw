using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first  name?");
        string first = ReadLine();

        Console.Write("What is your last name?");
        string last = ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");

    }
}