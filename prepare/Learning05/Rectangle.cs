
// Rectangle class inherits the Base Class of Shape
public class Rectangle : Shape
{
    // Attribute for _length and _wide as a private member variable
    private double _length;
    private double _width;

    // Constructor that accepts the length and width, then calling the base constructor with the color
    public Rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }

    // An override method from the base class, to return the area
    public override double GetArea()
    {
        return _length * _width;
    }

}