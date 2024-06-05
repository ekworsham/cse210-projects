using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("June 04, 2024", 3, 30);
        Cycling cycling = new Cycling("June 06, 2024", 25, 60);
        Swimming swimming = new Swimming("June 08, 2024", 5, 60);

        List<Activity> _activities = new List<Activity>();

        _activities.Add(running);
        _activities.Add(cycling);
        _activities.Add(swimming);

        foreach (Activity activity in _activities)
        {
            Console.WriteLine (activity.GetSummary());
        }
    }
}