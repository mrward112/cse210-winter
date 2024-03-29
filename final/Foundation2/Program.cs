using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create Address
        Address address = new Address();
        address.SetAddress("123 Main St", "Springfield", "IL", "USA");

        // Create Customer
        Customer customer = new Customer();
        customer.SetCustomer("John Doe", address);

        // Create Products
        List<Product> products = new List<Product>();
        Product product1 = new Product();
        product1.setProduct("Phone", "P001", 599.99, 1);
        products.Add(product1);

        Product product2 = new Product();
        product2.setProduct("Laptop", "P002", 999.99, 1);
        products.Add(product2);

        // Create Order
        Order order = new Order(products, customer);

        // Display Results
        order.DisplayResults();
    }
}
