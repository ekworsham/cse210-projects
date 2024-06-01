public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _county;

    Address(string street, string city, string state, string county)
    {
        _streetAddress = street;
        _city = city;
        _stateProvince = state;
        _county = county;
    }
    public bool isUsa()
    {
        return false;
    }
    public void Display()
    {

    }
}