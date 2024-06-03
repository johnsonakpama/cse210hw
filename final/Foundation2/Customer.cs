using system;

public class Customer
{
    private string _customerName;
    private string _address;
    private bool _liveUSA;

    public Address(string customerName, string address)
    {
        List<string> address = new List<string>();
        address.Add(customerName);
        address.Add(address);
    }

    public LiveUSA(string address)
    {
        if (address == USA)
        {
            return true;
        }
        else
        {
            return fasle;
        }
    }
}