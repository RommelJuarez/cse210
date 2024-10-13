using System;
class Order
{
    private List<Product> _products;
    private Costumer _costumer;


    public Order(Costumer costumer)
    {
        _costumer = costumer;
        _products = new List<Product>();

    }

    public void AddProductToOrder(Product newProduct)
    {
        _products.Add(newProduct);
    }

    public void TotalCost()
    {
        float _total = 0;
        float _shippingCost = _costumer.IsInUsa() ? 5.00f : 35.00f;
        foreach (Product product in _products)
        {
            float _productTotal = (product.TotalProductCost());
            _total += _productTotal;
        }
        float _total1 = _total + _shippingCost;
        Console.WriteLine($"Total Cost:{_total1}");

    }

    public void PackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"Product Name: {product.ProductLabel()}");
            Console.WriteLine($"Id Product: {product.IdLabel()}");

        }

    }
    public void ShippingLabel()
    {

        Console.WriteLine($"Costumer Name: {_costumer.NameLabel()}");
        Console.WriteLine($"Address:{_costumer.AddressString()}");



    }
}





