
// Square class inherits the Base Class of Shape
public class Square : Shape
{
    // Attribute for _side as a private member variable
    private double _side;

    // Constructor that accepts the side, then calling the base constructor with the color
    public Square(string color, double side) : base (color)
    {
        _side = side;
    }

    // An override method from the base class, to return the area
    public override double GetArea()
    {
        return _side * _side;
    }

}