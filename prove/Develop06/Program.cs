using System;
// I showed creativity by creating a leveling system and adding a "times completed" to eternal goals.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the goal program!");
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        string choice = "";
        Console.Clear();
        GoalManager goalManager = new GoalManager(name);
        while(choice != "6")
        {
            goalManager.Start();
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            if (choice == "1")
            {
                goalManager.CreateGoal();
            }
            if (choice == "2")
            {
                goalManager.ListGoals();
            }
            if (choice == "3")
            {
                goalManager.SaveGoals();
            }
            if (choice == "4")
            {
                goalManager.LoadGoals();
            }
            if (choice == "5")
            {
                goalManager.RecordEvent();
            }
        }
    }
}