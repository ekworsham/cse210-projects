public class PromptGenerator
{
    public List<string> _prompts;
    public string GetRandomPrompt()
    {
        // Created instance [object] of the 'Random' class
        Random random = new Random();
        // Generated a random number and stored it inside a variable
        int num = random.Next(_prompts.Count);
        // Created a variable to store random prompt from the list of prompts
        string randomPrompt = _prompts[num];

        return randomPrompt;
        
    }
        
}