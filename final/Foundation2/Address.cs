public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public String Street
    {
    get{return _street;}
    set{_street = value;}
    }

    public String City
    {
    get{return _city;}
    set{_city = value;}
    }

    public String State
    {
    get{return _state;}
    set{_state = value;}
    }

    public String Country
    {
    get{return _country;}
    set{_country = value;}
    }

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    

    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";

    }

}