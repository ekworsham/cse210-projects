public class Order
{
    private List<Product> _product = new List<Product>();
    private string _customer;

    public Order(string product, string customer)
    {
        
        _customer = customer;
    }

    public string GetPackingLabel()
    {
        return"";
    }
    public string GetShippingLabel()
    {
        return"";
    }
    public double calculateTotalCost()
    {
        return 0;
    }
}