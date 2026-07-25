using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine("");

        Address address1 = new Address("103 You Suck Ave.", "Goaway", "Missery", "America");
        Address address2 = new Address("496 Grace Parkway", "Hopetown", "Uusaa", "Africa");

        Customer customer1 = new Customer("Billy", address1);
        Customer customer2 = new Customer("Crystalina", address2);

        Product product1 = new Product("Ram", 4851564, 500, 2);
        Product product2 = new Product("Memory", 4865268, 600, 1);
        Product product3 = new Product("Monitor", 2549851, 800, 3);
        Product product4 = new Product("Tower", 1221355, 1500, 1);

        List<Product> products1 = new List<Product>();
        List<Product> products2 = new List<Product>();

        products1.Add(product1);
        products1.Add(product2);
        products2.Add(product3);
        products2.Add(product4);

        Order order1 = new Order(customer1, products1);
        Order order2 = new Order(customer2, products2);

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Products:");
        Console.WriteLine(order1.GetPackinglabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");
        Console.WriteLine("");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Products:");
        Console.WriteLine(order2.GetPackinglabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}