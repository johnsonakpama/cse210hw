using system;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    private bool _liveUSA;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }
    
    public string GetStreetAddress()
    {
        _streetAddress = streetAddress;
    }

    public void SetStreetAddress(string streetAddress)
    {
        return streetAddress;
    }

    public string GetCity()
    {
        _city = city;
    }

    public void SetCity(string city)
    {
        return city;
    }

    public string GetState()
    {
        _state = state;
    }

    public void SetState(string state)
    {
        return state;
    }

    public string GetCountry(bool liveUSA)
    {
        _country = country;
    }

    public void SetCountry()
    {
        return country;
    }

    public bool PlaceLive()
    {
        if (country == USA)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string FullAddress()
    {
        Console.WriteLine($"Address: {_streetAddress}, {_city}, {_state}, {_country}");
    }

}

