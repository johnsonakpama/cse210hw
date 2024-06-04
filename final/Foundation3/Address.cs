using system;

public class Address : Event
{
    private string _street = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";

    public string GetStreet()
    {
        return _street;
    }

    public void SetStreet(string street)
    {
        _street = street;
    }

    public string GetCity()
    {
        return _city;
    }

    public void SetCity()
    {
        _city = city;
    }

    public string GetState()
    {
        return _state;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public string GetCountry()
    {
        return _country;
    }

    public void SetCountry()
    {
        _country = country;
    }
}