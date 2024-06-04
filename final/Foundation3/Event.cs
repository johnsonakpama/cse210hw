using system;

public class Event
{
    private string _title = "";
    private string _description = "";
    private string _date = "";
    private string _time = "";
    private string _address = "";

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public string GetTime()
    {
        return _time;
    }

    public void SetTime(string time)
    {
        _time = time;
    }

    public string GetAddress()
    {
        return _address;
    }

    public void SetAddress()
    {
        _address = address;
    }

    public string DisplayEventInfo()
    {
        return $"{_title} {_description} {_date} {_time} {_address} {_speakerName} {_capacity} {_rsvpEmail} {_weatherStatement}";
    }
}
