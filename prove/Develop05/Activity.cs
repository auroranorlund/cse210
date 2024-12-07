using System.Runtime.InteropServices;

public class Activity
{
    private string _name = "";
    private string _description = "";
    protected int _duration = 0;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        string duration = Console.ReadLine();
        _duration = int.Parse(duration);
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}!");
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        List<string> animation = new List<string>{"|", "/", "-", "\\", "|", "/", "-", "\\"};
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animation[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count())
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        while (seconds != 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            seconds = seconds - 1;
        }
    }
}