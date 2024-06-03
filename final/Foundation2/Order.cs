using system;

public class Order
{
    List<Product> _product = new List<Product>();
    List<Customer> _customer = new List<customer>();

    public Order()
    {
        _product = Product;
        _customer = customer;
    }

    public string Customer(string product, string customer)
    {
        customer.Add(product);
        customer.Add(customer);
    }

    public int shippingCost()
    {
        _shippingCost = shippingCost;
        {
            if (country = USA)
            {
                shippingCost = $5;
            }
            else
            {
                shippingCost = $35;
            }
        }
    }
    public string PlaceLive(string PlaceLive)
    {
        _placeLive = placeLive;
    }

    public int totalSum()
    {
        totalSum =_product * _price * _quanity * _shippingCost;

        return totalSum;
    }

    public string GetPackingLabel()
    {
        PackingLabel = PackingLabel;
    }

    public void SetPackingLabel()
    {
        return PackingLabel;
    }

    public string GetShippingLabel()
    {
        ShippingLabel = ShippingLabel;
    }

    public void SetShippingLabel()
    {
        return ShippingLabel;
    }

    public PackingLabel(string productName, int productID)
    {
        Console.WriteLine($"Name: {_productName} ProductID; {_productID}"):
    }

    public string ShippingLabel()
    {
        Console.WriteLine($"Customer: {_customer} Address: {_address}");
    }
}