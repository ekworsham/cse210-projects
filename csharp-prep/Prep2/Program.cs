using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        Console.Write ("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        string letter;

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80 && number < 90)
        {
            letter = "B";
        }
        else if (number >= 70 && number < 80)
        {
            letter = "C";
        }
        else if (number >= 60 && number < 70)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.Write ($"Your grade is {letter}");

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