using System.Security.Cryptography.X509Certificates;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string address, string city, string state, string country)
    {
        _streetAddress = address;
        _city = city;
        _state = state;
        _country = country;
    }
    public string GetAddressDetails()
    {
        return$"{_streetAddress}, {_city}, {_state}, {_country}";
    }
}