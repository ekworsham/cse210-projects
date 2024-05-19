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
        // // BREATHING MESSAGE
        // Console.Write("How long, in seconds, would you like for your session? ");
        // Console. ReadLine();

        // // BREATHING PROMPTS 
        // Console.WriteLine("Get ready....");
        // Console.WriteLine("Breathe in.....");
        // Console.WriteLine("Breathe out....");
        // Console.WriteLine("Well done!!");


        // // REFLECTION MESSAGE
        // Console.WriteLine("Welcome to the reflecting activity");
        // Console.Write("How long, in seconds, would you like for your session? ");
        // Console.WriteLine("Get ready...... ");
        // Console.WriteLine("Consider the following prompt: ");
        // Console.WriteLine("When you have something in mind, press enter to continue.");
        
        // // REFLECTION PROMPTS
        // Console.WriteLine("Think of a time when you stood up for someone else.");
        // Console.WriteLine("Think of a time when you did something really difficult");
        // Console.WriteLine("Think of a time when you helped someone in need.");
        // Console.WriteLine("Think of a time when you did something truly selfless.");
        // Console.WriteLine("Well done!!");

        // // REFLECTION QUESTIONS
        // Console.WriteLine("Why was this experience meaningful to you?");
        // Console.WriteLine("Have you ever done anything like this before?");
        // Console.WriteLine("How did you get started?");
        // Console.WriteLine("How did you feel when it was complete?");
        // Console.WriteLine("What made this time different than other times when you were not as successful?");
        // Console.WriteLine("What is your favorite thing about this experience?");
        // Console.WriteLine("What could you learn from this experience that applies to other situations?");
        // Console.WriteLine("What did you learn about yourself through this experience?");
        // Console.WriteLine("How can you keep this experience in mind in the future?");


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