using System.ComponentModel.DataAnnotations.Schema;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal (string name, string description, int points) : base (name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }
    
    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return "";
    }
}

// if (response ==1)
//                 {
//                     Console.Write("What is the name of your goal? ");
//                     Console.ReadLine();
//                     Console.Write("What is a short description of it? ");
//                     Console.ReadLine();
//                     Console.Write("What is amount of points associated with this goal? ");
//                     Console.ReadLine();
//                 }
//                 else if (response == 2)
//                 {
//                     Console.Write("What is the name of your goal? ");
//                     Console.ReadLine();
//                 }