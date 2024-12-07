using System;
using System.ComponentModel.Design;
// I showed creativity by allowing the user to either choose their own prompt or get a random one for the Listing and Reflecting Activities.
class Program
{
    static void Main(string[] args)
    {
        int menuOption = 0;
        while (menuOption != 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activty");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option from the menu: ");
            menuOption = int.Parse(Console.ReadLine());
            if (menuOption == 1)
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            if (menuOption == 2)
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
            }
            if (menuOption == 3)
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
        }
    }
}