using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Clear();
        Console.Write("\n*** Welcome to the Mindfulness Program ****\n");
        
        Choices choice = new Choices();
        int seconds;

        int action = 0;
        while (action != 4)
        {
            
            action = choice.UserChoice(); // This will display options, asking for user input (1-4)
            switch (action)
            {
                case 1:
                    
                    Console.Clear();
                    BreathingActivity breathing = new BreathingActivity("Breathing", 0); // This will Start the Breathing Activity
                    breathing.GetActivityName();
                    breathing.GetActivityDescription();
                    seconds = breathing.GetActivityTime();
                    breathing.GetReady();
                    breathing.Breathing(seconds);
                    breathing.GetDone();
                    break;
                case 2:
                    
                    Console.Clear();
                    ReflectingActivity reflecting = new ReflectingActivity("Reflecting", 0); //This will Start the Reflecting Activity
                    reflecting.GetActivityName();
                    reflecting.GetActivityDescription();
                    seconds = reflecting.GetActivityTime();
                    reflecting.GetReady();
                    reflecting.DisplayPrompt(seconds);
                    reflecting.GetDone();
                    break;
                case 3:
                    
                    Console.Clear();
                    ListingActivity listing = new ListingActivity("Listing", 0); // This will Start the Listing Activity
                    listing.GetActivityName();
                    listing.GetActivityDescription();
                    seconds = listing.GetActivityTime();
                    listing.GetReady();
                    listing.ReturnPrompt(seconds);
                    listing.GetDone();
                    break;
                case 4:
                    
                    Console.WriteLine("\nThank you for using the Mindfulness Program!\n"); 
                    break;
                default:
                    Console.WriteLine($"\nSorry the option you entered is invalid.");
                    break;
            }
        }
    }
}