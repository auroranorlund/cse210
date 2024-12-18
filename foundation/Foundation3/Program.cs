using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running("28 Nov 2024", 30, 3);
        Cycling cycling = new Cycling("29 Nov 2024", 45, 4);
        Swimming swimming = new Swimming("30 Nov 2024", 20, 8);
        List<Activity> activities = new List<Activity>{running, cycling, swimming};

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}