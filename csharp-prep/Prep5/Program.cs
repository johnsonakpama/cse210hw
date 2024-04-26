using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMassage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squareNumber = SquareNumber(userNumber);

        DisplayResult(userName, squareNumber);
    }

    static void DisplayWelcomeMassage()
    {
        Console.WriteLine("What to the program");
    }

    static void PromptUserName()
    {
        Console.Write("Please enter your name");
        string name = Console.ReadLine();

        return name;
    }

    static void PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.parse(Console.ReadLine());

        return number;
    }

    static void SquareNumber(int number)
    {
        int square = number = number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of number is {square}");
    }
}