using System.ComponentModel;

public abstract class Goal
{
    // Member variables should be private
    protected string _shortName;
    protected string _description;
    protected int _points;

    // This is the constructor; should be public and going to initalize the member variables. Parameters must have a data type(ex. int or string).
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    // These are the methods. The abstract method does not need a body (in parent class) because the child class has the implementation. A CHILD CLASS is REQUIRED when using abstract.
    public abstract int RecordEvent();

    public abstract bool IsComplete();
    
    // Virtual means the child class can override the method
    public virtual string GetDetailsString()
    {
        if(IsComplete())
        {
            return $"[X] {_shortName} ({_description})";
        }
        else
        {
            return $"[ ] {_shortName} ({_description})";
        }
    }
   
    public abstract string GetStringRepresentation();
    
}

