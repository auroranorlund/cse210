using System;
using System.Data;

// I showed creativity by taking a data file of the entire King James Version Bible and loading it in the program to allow the user to look up any verse or verses they would like to use.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the scripture memorizer!");
        Console.Write("Please enter the book of Bible (case sensitive): ");
        string book = Console.ReadLine();
        Console.Write("Please enter the chapter number: ");
        string chapter = Console.ReadLine();
        Console.Write("Please enter the first verse number: ");
        string startVerse = Console.ReadLine();
        Console.Write("Please enter the ending verse of the range (if referencing one verse only, enter 0): ");
        string endVerse = Console.ReadLine();
        Bible bible = new Bible();
        string file = "bible_data_set.txt";
        bible.LoadFromFile(file);
        string verseText = bible.GetScripture(book, chapter, startVerse, endVerse);
        if(endVerse == "0")
        {
            int chapterNumber = int.Parse(chapter);
            int verse = int.Parse(startVerse);
            Reference reference = new Reference(book, chapterNumber, verse);
            Scripture scripture = new Scripture(reference, verseText);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            bool IsCompletelyHidden = false;
            string quit = Console.ReadLine();
            int wordsToHide = 0;
            Random rnd = new Random();
            while (IsCompletelyHidden != true)
            {
                if (quit != "quit")
                {
                    Console.Clear();
                    wordsToHide = rnd.Next(1, 3);
                    scripture.HideRandomWords(wordsToHide);
                    Console.WriteLine(scripture.GetDisplayText());
                    quit = Console.ReadLine();
                    IsCompletelyHidden = scripture.IsCompletelyHidden();
                }
                else
                {
                    IsCompletelyHidden = true;
                }
            }
        }
        else
        {
            int chapterNumber = int.Parse(chapter);
            int verse1 = int.Parse(startVerse);
            int verse2 = int.Parse(endVerse);
            Reference reference = new Reference(book, chapterNumber, verse1, verse2);
            Scripture scripture = new Scripture(reference, verseText);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            bool IsCompletelyHidden = false;
            string quit = Console.ReadLine();
            int wordsToHide = 0;
            Random rnd = new Random();
            while (IsCompletelyHidden != true)
            {
                if (quit != "quit")
                {
                    Console.Clear();
                    wordsToHide = rnd.Next(1, 3);
                    scripture.HideRandomWords(wordsToHide);
                    Console.WriteLine(scripture.GetDisplayText());
                    quit = Console.ReadLine();
                    IsCompletelyHidden = scripture.IsCompletelyHidden();
                }
                else
                {
                    IsCompletelyHidden = true;
                }
            }
        }
    }
}