using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer = new Customer();

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double GetPrice()
    {
        double price = 0;
        double itemPrice = 0;
        double shipping = 0;
        foreach(Product p in _products)
        {
            itemPrice = p.GetCost();
            price = price + itemPrice;
        }
        bool IsUSA = _customer.LivesInUSA();
        if (IsUSA == true)
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        price = price + shipping;
        return price;
    }
        public string GetPackingLabel()
    {
        string label = "";
        string productText = "";
        foreach(Product p in _products)
        {
            productText = p.GetPackingLabelText();
            label = label + "\n" + productText;
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string label = _customer.GetShippingText();
        return label;
    }
}