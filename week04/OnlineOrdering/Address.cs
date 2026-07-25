class Address
{
    private string _address;
    private string _city;
    private string _state;
    private string _country;

    public Address(string address, string city, string state, string country)
    {
        _address = address;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsAmerican()
    {
        if (_country == "America" || _country == "america")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetFullAddress()
    {
        return $"{_address}\n{_city}, {_state}\n{_country}";
    }
}