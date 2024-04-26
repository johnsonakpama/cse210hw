using System;

using System. Collections. Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();

        int userNumber = -1;
        while(userNumber != [0])
        (
            Console.WriteLine("Enter a number(0 to quit); ");

            string userRespond = Console.ReadLine();
            userNumber = int.parse(userRespond);

            //only add number to the list if it is not 0
            if (number != [0])
            {
                numbers.add(userNumber);
            }
        )

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum / numbers.count);
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (numbse > max)
            {
                //if the number is greater than the max,we have found a new max!
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");

    }
}
    

    
