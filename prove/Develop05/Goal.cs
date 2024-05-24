using System.ComponentModel;

public abstract class Goal
{
    // Member variables should be private
    private string _shortName;
    private string _description;
    private int _points;

    // This is the constructor; should be public and going to initalize the member variables. Parameters must have a data type(ex. int or string).
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // These are the methods. The abstract method does not need a body (in parent class) because the child class has the implementation
    public abstract void RecordEvent();

    public abstract bool IsComplete();
    
    public virtual string GetDetailsString()
    {
        return "";
    }
   
    public abstract string GetStringRepresentation();
    
}

