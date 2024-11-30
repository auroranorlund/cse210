using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Pavo Peacock Plush", "PA1130", 30.99, 1);
        Product product2 = new Product("Noctua Owl Plush", "NA0430", 30.99, 1);
        Product product3 = new Product("Leo Lion Plush", "LE0314", 30.99, 1);
        List<Product> order1Products = new List<Product>{product1, product2, product3};
        Address address1 = new Address("1234 E Broadway St", "Phoenix", "AZ", "USA");
        Customer customer1 = new Customer("Aurelia Ragnvindr", address1);
        Order order1 = new Order(customer1, order1Products);

        string order1PackingLabel = order1.GetPackingLabel();
        string order1ShippingLabel = order1.GetShippingLabel();
        double order1Price = order1.GetPrice();

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1PackingLabel);
        Console.WriteLine();
        Console.WriteLine("Ship to:");
        Console.WriteLine();
        Console.WriteLine(order1ShippingLabel);
        Console.WriteLine();
        Console.WriteLine($"Total cost: ${order1Price}");
        Console.WriteLine();

        Product product4 = new Product("Mini Pavo Peacock Plush", "MPA1130", 10.99, 2);
        Product product5 = new Product("Mini Noctua Owl Plush", "MNA0430", 10.99, 2);
        Product product6 = new Product("Mini Leo Lion Plush", "MLE0314", 10.99, 2);
        List<Product> order2Products = new List<Product>{product4, product5, product6};
        Address address2 = new Address("1234 E Pemberley St", "Toronto", "Ontario", "CA");
        Customer customer2 = new Customer("Caspian Smith", address2);
        Order order2 = new Order(customer2, order2Products);

        string order2PackingLabel = order2.GetPackingLabel();
        string order2ShippingLabel = order2.GetShippingLabel();
        double order2Price = order2.GetPrice();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2PackingLabel);
        Console.WriteLine();
        Console.WriteLine("Ship to:");
        Console.WriteLine();
        Console.WriteLine(order2ShippingLabel);
        Console.WriteLine();
        Console.WriteLine($"Total cost: ${order2Price}");
    }
}