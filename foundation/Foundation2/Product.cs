using System;
class Product
{
    private string _productName;
    private int _idProduct;
    private float _price;
    private int _quantity;

    public Product(Dictionary<string, object> productData)
    {
        _productName = (string)productData["ProductName"];
        _idProduct = (int)productData["IdProduct"];
        _price = (float)productData["Price"];
        _quantity = (int)productData["Quantity"];
    }
    public void ShowProductInfo()
    {
        Console.WriteLine($"Name of product: {_productName}");
        Console.WriteLine($"ID of product: {_idProduct}");
        Console.WriteLine($"Price: {_price}");
        Console.WriteLine($"Quantity: {_quantity}");
        Console.WriteLine($"{TotalProductCost()}");
    }

    public float TotalProductCost()
    {
        return _price * _quantity;
    }
    public string ProductLabel()
    {
        return _productName;
    }
    public int IdLabel()
    {
        return _idProduct;
    }
    public float PriceLabel()
    {
        return _price;
    }
    public int QuantityLabel()
    {
        return _quantity;
    }
}