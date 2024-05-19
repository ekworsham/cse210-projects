public class ReflectingActivity : Activity
{
    // private List<Prompt> _prompts = new List<Prompt>();
    // private List<Question> _questions = new List<Question>();

    public ReflectingActivity()
    {
        _name = "Reflective Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        DisplayStartMessage();
    }

    public string GetRandomPrompt()
    {
        // REFLECTION PROMPTS
        return ("Think of a time when you stood up for someone else.");
        // return ("Think of a time when you did something really difficult");
        // return ("Think of a time when you helped someone in need.");
        // return("Think of a time when you did something truly selfless.");
        // return ("Well done!!");
    }

    public string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestion()
    {

    }
}