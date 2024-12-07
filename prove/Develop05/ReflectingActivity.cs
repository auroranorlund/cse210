public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you accomplished a long-term goal.");
        _prompts.Add("Think of a time when you overcame a challenge.");
        _prompts.Add("Think of a time when you fixed a mistake you made.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Write("\n");
        int questionNumber = _duration / 15;
        while (questionNumber != 0)
        {
            DisplayQuestions();
            ShowSpinner(15);
            questionNumber = questionNumber - 1;
        }
        DisplayEndingMessage();
        ShowSpinner(5);
    }

    private string GetRandomPrompt()
    {
        Random rnd = new Random();
        int listLength = _prompts.Count;
        int promptNumber = rnd.Next(0, listLength);
        string prompt = _prompts[promptNumber];
        return prompt;
    }
    private string GetRandomQuestion()
    {
        Random rnd = new Random();
        int listLength = _questions.Count;
        int questionNumber = rnd.Next(0, listLength);
        string question = _questions[questionNumber];
        return question;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("Would you like to:");
        Console.WriteLine("1. Choose a prompt");
        Console.WriteLine("2. Get a random prompt");
        int choice = int.Parse(Console.ReadLine());
        string prompt = "";
        if (choice == 2)
        {
            prompt = GetRandomPrompt();
        }
        else
        {
            int index = 0;
            foreach (string p in _prompts)
            {
                Console.WriteLine($"{index}. {p}");
                index++;
            }
            Console.WriteLine("Please type the number next to the prompt you would like.");
            int promptChoice = int.Parse(Console.ReadLine());
            prompt = _prompts[promptChoice];
        }
        Console.Clear();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine($"--- {prompt} ---");
    }

    public void DisplayQuestions()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"> {question}");
    }
}