using System.Dynamic;

public class Product
{
    private string _name;
    private int _productId;
    private double _price;
    private double _quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    
    public string GetName()
    {
        return _name;
    }
    public double GetProductId()
    {
        return _productId;
    }
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    
}