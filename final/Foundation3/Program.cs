using System;

class Program
{
    static void Main(string[] args)
    {
        
        Address address = new Address ("721 Crimson Morning View", "Canton", "GA", "USA");
        
        Lectures lectures = new Lectures("Motions of a Hidden Fire", "God hears every prayer and responds to each according to the path He has outlined for His children", "April 6, 2024", "2:00 PM", address, "President Jeffrey R. Holland", 100);

        Receptions receptions = new Receptions("25 year anniversary", "An elegant evening with dinner and dancing", "June 3, 2024", "6:00 PM", address, "rsvpEmail@gmail.com");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Fall Festival", "A fun outdoor festival for the entire family", "October 12, 2024", "4:00 PM", address, "Sunny and breezy");

        Console.WriteLine();
        Console.WriteLine("Lecture:");
        Console.WriteLine (lectures.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine (lectures.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine("Receptions:");
        Console.WriteLine(receptions.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(receptions.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine("Outdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}