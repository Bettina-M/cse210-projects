using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;

public class Customer
{
    private string _name;
    private Address _address;

    public String Name
    {
    get{return _name;}
    set{_name = value;}
    }

    public Address Address
    {
    get{return _address;}
    set{_address = value;}
    }


    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string CustomerDetails()
    {
        return $"Customer Name: {_name},\nAddress:\n{_address.GetAddress()}";
    }

}
