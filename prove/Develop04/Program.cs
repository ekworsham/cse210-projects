using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectingActivity reflectingActivity = new ReflectingActivity();
        ListingActivity listingActivity = new ListingActivity();

        int response = 0;
        while (response != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");
            Console.Write("Select a choice from the menu! ");
            response = int.Parse(Console.ReadLine());
        
            if (response == 1)
            {
                breathingActivity.Run();
                
            }
            else if (response == 2)
            {
                reflectingActivity.Run();
            }
            else if (response == 3)
            {
                listingActivity.Run();
            }
        }
        

       


        // // LISTING MESSAGE
        // Console.WriteLine("Welcome to the Listing Activity");
        // Console.Write("How long, in seconds, would you like for your session? ");
        // Console.WriteLine("Get ready...... ");
        
        // // LISTING PROMPTS
        // Console.WriteLine("Who are people that you appreciate?");
        // Console.WriteLine("What are personal strengths of yours?");
        // Console.WriteLine("Who are people that you have helped this week?");
        // Console.WriteLine("When have you felt the Holy Ghost this month?");
        // Console.WriteLine("Who are some of your personal heroes?");
        // Console.WriteLine("Well done!!");


    }
}