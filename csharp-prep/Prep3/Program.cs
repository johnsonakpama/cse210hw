using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your magic number? ");
        int magicNumber = int.parse(Console.RreadLine());

        Random randomGenertor = new Random();
        int magicNumber = randomGenertor.Next(1, 101);

        int guess = -1;

        while (guess i= magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.parse(Console.RreadLine());
        }

        if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
        }

        else if (magicNumber < guess)
        {
            Console.WriteLine("Lower");
        }

        else
        {
            Console.WriteLine("You guess right!")
        }
    }
}