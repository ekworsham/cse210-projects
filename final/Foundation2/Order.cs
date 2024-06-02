using System.Diagnostics;

public class Order
{
    private List<Product> _product;
    private Customer _customer;

    public Order(List<Product> product, Customer customer)
    {
        _customer = customer;
        _product = product;
    }
    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach(Product product in _product)
        {
            packingLabel = packingLabel + $"Product Name: {product.GetName()}, Product ID: {product.GetProductId() }\n";
        }
        return packingLabel;     
    }
    public string GetShippingLabel()
    {   
        string shippingLabel = "";
        shippingLabel = $"{_customer.GetName()}\n{_customer.GetAddress()}";
        return shippingLabel;  
    }
    public double calculateTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _product)
        {
            totalCost += product.GetTotalCost();
        }
        if (_customer.isUsa())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }
        return totalCost;    
    }
}