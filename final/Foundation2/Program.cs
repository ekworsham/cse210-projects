using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address ("721 Crimson Morning View", "Canton", "GA", "USA");
        Customer customer1 = new Customer ("Keith Worsham", address1);
        List<Product> product1 = new List<Product>
        {
            new Product("Bike", 07, 50, 1),
            new Product("Helment", 08, 25, 1)
        };
        Order order1 = new Order(product1, customer1);
        
        Console.WriteLine();
        Console.WriteLine("ORDER 1"); 
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order1.GetPackingLabel());
        
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.Write("Total Cost: " + order1.calculateTotalCost());
        Console.WriteLine();



        Address address2 = new Address ("82 Bearden Road", "Cartersville", "GA", "USA");
        Customer customer2 = new Customer ("ProScapes of Atlanta LLC", address2);
        List<Product> product2 = new List<Product>
        {
            new Product("Skid Steer", 52, 25500, 1),
            new Product("Bucket", 32, 500, 1)
        };
        Order order2 = new Order(product2, customer2);
        
        Console.WriteLine();
        Console.WriteLine("ORDER 2"); 
        Console.WriteLine("Packing Label: ");
        Console.WriteLine(order2.GetPackingLabel());
        
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.Write("Total Cost: " + order2.calculateTotalCost());
        Console.WriteLine();
           
    }
}