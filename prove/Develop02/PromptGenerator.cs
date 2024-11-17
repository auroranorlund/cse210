public class PromptGenerator 
{
    public List<string> _prompts = new List<string>();
    public PromptGenerator()
    {
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int listLength = _prompts.Count;
        int promptNumber = rnd.Next(0, listLength);
        string prompt = _prompts[promptNumber];
        return prompt;
    }

}