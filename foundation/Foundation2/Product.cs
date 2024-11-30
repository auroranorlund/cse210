using System.Reflection;

public class Product
{
    private string _name = "";
    private string _productID = "";
    private double _price = 0;
    private int _quantity = 0;

    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public string GetPackingLabelText()
    {
        string text = $"{_quantity}x {_productID} {_name}";
        return text;
    }

    public double GetCost()
    {
        double cost = _quantity * _price;
        return cost;
    }
}