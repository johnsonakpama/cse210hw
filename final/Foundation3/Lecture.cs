using system;

public class Lecture : Event
{
    private string _speakerName = "";
    private int _capacity = 0;

    public string GetSpeakerName()
    {
        return _speakerName;
    }

    public void SetSpeakerName(string speakerName)
    {
        _speakerName = speakerName;
    }

    public string GetCapacity()
    {
        return _capacity;
    }

    public void SetCapacity(string capacity)
    {
        _capacity = capacity;
    }
}