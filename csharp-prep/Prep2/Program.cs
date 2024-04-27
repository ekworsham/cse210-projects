using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        Console.Write ("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        if (number >= 90)
        {
            Console.Write ("Your grade is A");
        }
        else if (number >= 80 && number < 90)
        {
            Console.Write ("Your grade is B");
        }
        else if (number >= 70 && number < 80)
        {
            Console.Write ("Your grade is C");
        }
        else if (number >= 60 && number < 70)
        {
            Console.Write ("Your grade is D");
        }
        else 
        {
            Console.Write ("Your grade is F");
        }

        Console.WriteLine ();

        if (number > 69)
        {
            Console.Write ("Congratulations, you passed the course");
        }
        else
        {
            Console.Write ("YOU FAILED! You can do this...Try again!");
        }
    }
}