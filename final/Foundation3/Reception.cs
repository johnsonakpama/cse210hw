using system;

public class Reception : Event
{
    private string _rsvpEmail;

    public string GetRsvpEmail()
    {
        return _rsvpEmail;
    }

    public void SetRsvpEmail(string rsvpEmail)
    {
        _rsvpEmail = rsvpEmail;
    }
}