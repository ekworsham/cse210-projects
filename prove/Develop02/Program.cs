using System;
using System.Net;

public class Program
{
    static void Main(string[] args)
    {
        //Create new instance [object] of generator class 
        PromptGenerator promptGenerator = new PromptGenerator();

        //Create list of prompts
        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        // Save list of prompts to instance [object]
        promptGenerator._prompts = prompts;

        string input = "";
        int response = 0;
        // ONLY ONCE, BEFORE While Loop, Created a new instance [object] of the Journal Class
        Journal journal = new Journal();
        while (response < 5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please Select One of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            response = int.Parse (Console.ReadLine());
            if (response == 1)
            {
                // returns a random prompt and stores it in a variable named ranPrompt
                string ranPrompt = promptGenerator.GetRandomPrompt();
                // writes to the console the random prompt
                Console.WriteLine (ranPrompt);
                Console.Write(">");
                // user inputs their entry text from the random prompt 
                input = Console.ReadLine();
                // DateTime class storing current time as theCurrentTime
                DateTime theCurrentTime = DateTime.Now;
                // take theCurrentTime and converts to a string and stores as dateText
                string dateText = theCurrentTime.ToShortDateString();

                // Created a new instance [object] of the Entry Class
                Entry entry = new Entry();
                entry._date = dateText;
                entry._entryText = input;
                entry._promptText = ranPrompt;

                // Adding entry to the Journal
                journal.AddEntry(entry);
            }

            else if (response == 2)
            {
                journal.DisplayAll();
                
            }
            else if (response == 3)
            {
                Console.WriteLine("What is your desired file name?" );
                string fileName = Console.ReadLine();
                journal.LoadFromFile($"{fileName}.txt");
            }
            else if (response == 4)
            {
                Console.WriteLine("What is your desired file name?" );
                string fileName = Console.ReadLine();
                journal.SaveToFile($"{fileName}.txt");
            }
           
        }
    }
}