using System.Reflection;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _eventtype;

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public string Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public string Time
    {
        get { return _time; }
        set { _time = value; }
    }

    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public string Eventtype
    {
        get { return _eventtype; }
        set { _eventtype = value; }
    }

    public  Event ()
    {
        _title = "";
        _description = "";
        _date = "";
        _time = "";
        _eventtype = "";
        _address = new Address();
    }

    public string GetShortDetails()
    {
        return $"{Eventtype}\n{Title}\n{Date}";
    }
    public string GetStandardDetails()
    {
        return $"{Title}\n{Description}\n{Date} {Time}\n{Address.GetAddress()}";
    }

    public string GetFullDetails()
    {
        return $"{Eventtype}:{Title}\n{Description}\n{Date} {Time}\n{Address.GetAddress()}";

    }
}











