public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _county;

    // with newline characters where appropriate??
    public Address(string street, string city, string state, string county)
    {
        _streetAddress = street;
        _city = city;
        _stateProvince = state;
        _county = county;
    }
    public bool isUsa()
    {
        if(_county == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string Display()
    {
        string address = $"{_streetAddress}\n{_city}, {_stateProvince}\n{_county} ";
        return address;
    }
}