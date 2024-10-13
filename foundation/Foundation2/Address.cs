using System;
class Address
{

    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string[] address)
    {
        _streetAddress = address[0];
        _city = address[1];
        _stateOrProvince = address[2];
        _country = address[3];
    }

    public bool IsInUsa()
    {
        return _country.ToLower() == "usa" || _country.ToLower() == "united states";
    }
    public string GetFullAddress()
    {
        return $"{_streetAddress} {_city}, {_stateOrProvince} {_country}";
    }
}