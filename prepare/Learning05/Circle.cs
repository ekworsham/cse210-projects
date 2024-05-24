// Circle class inherits the Base Class of Shape
public class Circle : Shape
{
    // Attribute for _radius as a private member variable
    protected double _radius;

    // Constructor that accepts the radius, then calling the base constructor with the color
    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }


    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}