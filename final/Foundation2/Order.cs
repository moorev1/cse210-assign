// Order.cs
using System;
using System.Collections.Generic;

class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotal()
    {
        double total = 0;
        foreach (var product in products)
        {
            total += product.Price * product.Quantity;
        }
        return total;
    }

    public string GeneratePackingLabel()
    {
        // Implementation for generating a packing label
        return "Packing Label: " + customer.IsUsaResident();
    }

    public string GenerateShippingLabel()
    {
        // Implementation for generating a shipping label
        return "Shipping Label: " + customer.IsUsaResident();
    }
}
