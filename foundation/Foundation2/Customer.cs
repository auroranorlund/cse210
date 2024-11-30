public class Customer
{
    private string _name = "";
    private Address _address = new Address("", "", "", "");

    public Customer()
    {
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        bool LivesInUSA = _address.IsInUSA();
        return LivesInUSA;
    }

    public string GetShippingText()
    {
        string addressText = _address.GetDisplayText();
        string text = $"{_name}\n{addressText}";
        return text;
    }
}