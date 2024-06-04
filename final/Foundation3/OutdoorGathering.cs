public class OutdoorGathering : Event
{
    private string _weatherForcast;

    public OutdoorGathering(string title, string description, string eventDate, string eventTime, Address eventAddress, string weatherForcast) : base(title, description, eventDate, eventTime, eventAddress)
    {
        _weatherForcast = weatherForcast;
    }

    public string GetFullDetails()
    {
        return$"Standard Details:\n{GetStandardDetails()}\n\nFull Details:\n{GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forcast: {_weatherForcast}";
    }
    public string GetShortDescription()
    {
        return$"Short Description:\nTitle: {GetTitle()}\nDate: {GetEventDate()}";
    }
}