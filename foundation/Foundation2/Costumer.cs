using System;
class Costumer
{

    private string _name;
    private Address _address;

    public Costumer(string name, Address address)
    {
        _name = name;
        _address = address;

    }

    public bool IsInUsa()
    {
        return _address.IsInUsa();
    }
    public string NameLabel()
    {
        return _name;
    }

    public string AddressString()
    {
        return _address.GetFullAddress();
    }


}