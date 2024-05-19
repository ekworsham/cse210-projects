public class ListingActivity : Activity
{
    // private int _count;
    // private List<Prompt> _prompts = new List<Prompt>()

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        DisplayStartMessage();
    }

    public void GetRandomPrompt()
    {

    }

    // public string List GetListFromUser()
    // {

    // }

}