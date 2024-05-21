using System;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("\n******Welcome to the breathe App******\n"
        + "1. Breathing\n"
        + "2. Reflection\n"
        + "3. Listing\n");
    Console.WriteLine("Select an activity");
    string choice = Console.ReadLine();
    Console.WriteLine("How long would you like to do this activity?");
    int duration = int.parse(Console.ReadLine());
    switch (choice)
    {
        
        case "1":
            BreathingActivity breathing = new( duration );
            breathing.Run();
            break;
            
        case "2":
            ReflectionActivity reflection = new( duration );
            breathing.Run();
            break;

        case "3":
            ListingActivity listing = new( duration );
            breathing.Run();
            break;
    }
    }
}