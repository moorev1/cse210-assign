// Program.cs
using System;

class Program
{
    static void Main()
    {
        // Create Products
        Product product1 = new Product("Product 1", 1, 10.99, 3);
        Product product2 = new Product("Product 2", 2, 24.99, 2);

        // Create Customer
        Address customerAddress = new Address("123 Main St", "Cityville", "CA", "USA");
        Customer customer = new Customer("John Doe", customerAddress);

        // Create Order
        Order order = new Order(customer);
        order.AddProduct(product1);
        order.AddProduct(product2);

        // Order Processing
        double total = order.CalculateTotal();
        string packingLabel = order.GeneratePackingLabel();
        string shippingLabel = order.GenerateShippingLabel();

        // Display Order Information
        Console.WriteLine("Order Details:");
        Console.WriteLine($"Total Cost: ${total}");
        Console.WriteLine(packingLabel);
        Console.WriteLine(shippingLabel);

        // Additional project description
        Console.WriteLine("\nProject Description:");
        Console.WriteLine("This project aims to develop a robust online ordering system, emphasizing the principles of encapsulation.");
        Console.WriteLine("The program includes classes for Product, Customer, Address, and Order, with a focus on ensuring data privacy");
        Console.WriteLine("by making member variables private. The implementation involves providing appropriate getters, setters,");
        Console.WriteLine("and constructors to encapsulate the internal details of each class. The program's core functionality includes");
        Console.WriteLine("calculating the total cost of orders and generating packing labels and shipping labels based on the customer's location.");
        Console.WriteLine("Through these features, the project effectively showcases the benefits and principles of encapsulation in object-oriented design.");
    }
}
