public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        int cycleNumber = _duration / 10;
        while (cycleNumber != 0)
        {
            Console.Write("Breath in... ");
            ShowCountDown(4);
            Console.Write("\n");
            Console.Write("Breath out... ");
            ShowCountDown(6);
            Console.WriteLine();
            cycleNumber = cycleNumber - 1;
        }
        Console.WriteLine();
        DisplayEndingMessage();
        ShowSpinner(5);
    }
}