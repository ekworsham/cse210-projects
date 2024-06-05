using System.Runtime.CompilerServices;

public class Activity
{
    private string _date;
   
    private double _minutes;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }
    public virtual string GetActivityType()
    {
        return"";
    }
    public double GetMinutes()
    {
        return _minutes;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public string GetSummary()
    {
        return$"{_date} {GetActivityType()} ({GetMinutes()} min)- {GetDistance():f2} miles, Speed {GetSpeed():f2} mph, Pace: {GetPace():f2} min per mile";
    }
}