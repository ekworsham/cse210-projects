using System.ComponentModel;
using System.Reflection;

public class Receptions : Event
{
    private string _rsvpEmail;

    public Receptions(string title, string description, string eventDate, string eventTime, Address eventAddress,string rsvpEmail) : base(title, description, eventDate, eventTime, eventAddress)
    {
        _rsvpEmail = rsvpEmail;
    }
    public string GetFullDetails()
    {
        return$"Standard Details:\n{GetStandardDetails()}\n\nFull Details:\n{GetStandardDetails()}\nType: Reception\nRSVP Email: {_rsvpEmail}";
    }
    public string GetShortDescription()
    {
        return$"Short Description:\nEvent: Reception\nTitle: {GetTitle()}\nDate: {GetEventDate()}";
    }

}