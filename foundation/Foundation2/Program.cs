using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order(new Customer("Daniel Capps", new Address("1210 S. Almar Cir", "Mesa", "Arizona", "United States")));
        order1.AddProduct(new Product("Monster Energy Zero Ultra 24 pack", 29421, 52.99, 1));
        order1.AddProduct(new Product("Monster Energy Vice Guava 4 pack", 29427, 9.90, 3));

        Order order2 = new Order(new Customer("Sherlock Holmes", new Address("221B Baker St", "London", "Greater London", "United Kingdom")));
        order2.AddProduct(new Product("Violin Strings", 24861, 82.95, 1));
        order2.AddProduct(new Product("Magnifying Glass", 11298, 14.99, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine(order1.GetTotal());
        Console.WriteLine("");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine(order2.GetTotal());

    }
}