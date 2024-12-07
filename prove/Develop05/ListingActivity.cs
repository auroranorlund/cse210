public class ListingActivity : Activity
{
    private int count = 0;
    private List<string> _prompts = new List<string>();

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can about a certain topic.")
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        _prompts.Add("What are you grateful for?");
        _prompts.Add("What brings you joy in life?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Would you like to:");
        Console.WriteLine("1. Choose a prompt");
        Console.WriteLine("2. Get a random prompt");
        int choice = int.Parse(Console.ReadLine());
        string prompt = "";
        if (choice == 2)
        {
            GetRandomPrompt();
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
            Console.Clear();
            Console.WriteLine("List as many responses as you can to the following prompt:");
            Console.WriteLine($"--- {prompt} ---");
        }
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Write("\n");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }
        Console.WriteLine($"You listed {count} items!");
        DisplayEndingMessage();
        ShowSpinner(5);
    }

    private void GetRandomPrompt()
    {
        Random rnd = new Random();
        int listLength = _prompts.Count;
        int promptNumber = rnd.Next(0, listLength);
        string prompt = _prompts[promptNumber];
        Console.Clear();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
    }

}