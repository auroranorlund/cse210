using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;

//I showed creativity by allowing the user to load their own list of prompts or use a provided prompt file.
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string option = "";
        string fileName = "";

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Would you like to:");
        Console.WriteLine("1. Load your own list of prompts");
        Console.WriteLine("2. Use the default list of prompts");
        Console.Write("Which would you like to do? ");
        string choice = Console.ReadLine();
        string promptFile = "";
        if (choice == "1")
        {
            Console.Write("Please enter the name of the prompt list file you would like to load:");
            promptFile = Console.ReadLine();
        }
        if (choice == "2")
        {
            promptFile = "prompts.txt";
        }
        PromptGenerator promptGenerator = new PromptGenerator();
        string[] lines = System.IO.File.ReadAllLines(promptFile);
        foreach (string line in lines)
        {
            promptGenerator._prompts.Add(line);
        }
        Console.WriteLine("Please select from the following options: ");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        option = Console.ReadLine();
        while (option != "5")
        {
            if (option == "1")
            {
                Entry entry = new Entry();
                DateTime currentTime = DateTime.Now;
                entry._date = currentTime.ToShortDateString();
                entry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine(entry._promptText);
                Console.Write("> ");
                entry._entryText = Console.ReadLine();
                journal.AddEntry(entry);
            }
            if (option == "2")
            {
                journal.DisplayAll();
            }
            if (option == "3")
            {
                Console.Write("Please enter the file name: ");
                fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            if (option == "4")
            {
                Console.Write("Please enter the file name: ");
                fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
            Console.WriteLine("Please select from the following options: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            option = Console.ReadLine();
        }
    }
}