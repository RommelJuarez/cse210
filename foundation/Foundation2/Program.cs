using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Dictionary<string, object> productData1 = new Dictionary<string, object> {
            { "ProductName", "Laptop" },
            { "IdProduct", 1 },
            { "Price", 50.00f},
            { "Quantity", 10 }
        };
        Dictionary<string, object> productData2 = new Dictionary<string, object> {
            { "ProductName", "Tv" },
            { "IdProduct", 2 },
            { "Price", 100.00f},
            { "Quantity", 1 }
        };
        Dictionary<string, object> productData3 = new Dictionary<string, object> {
            { "ProductName", "SmartPhone" },
            { "IdProduct", 3 },
            { "Price", 150.00f},
            { "Quantity", 2 }
        };



        string[] addressUsa = { "123 Main St", "New York", "NY", "USA" };
        string[] addressEcu = { "123 Main St", "New York", "NY", "Ecuador" };
        Address address1 = new Address(addressUsa);
        Address address2 = new Address(addressEcu);
        Costumer costumer1 = new Costumer("Rommel Juarez", address1);
        Costumer costumer2 = new Costumer("Andres Cevallos", address2);

        Product product1 = new Product(productData1);
        Product product2 = new Product(productData2);
        Product product3 = new Product(productData3);
        Console.WriteLine();
        Console.WriteLine("-----------Order 1------------");
        Order order1 = new Order(costumer1);
        order1.AddProductToOrder(product1);
        order1.AddProductToOrder(product2);

        order1.PackingLabel();
        order1.ShippingLabel();

        order1.TotalCost();
        Console.WriteLine();
        Console.WriteLine("-----------Order 2------------");
        Order order2 = new Order(costumer2);
        order2.AddProductToOrder(product3);
        order2.AddProductToOrder(product2);

        order2.PackingLabel();
        order2.ShippingLabel();

        order2.TotalCost();

    }
}