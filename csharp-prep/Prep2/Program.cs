using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string gradePercentage = Console.ReadLine();
        int gradeNumber = int.Parse(gradePercentage);

        string letter = "";

        if (gradeNumber >= 90)
        {
            letter = "A";
         }
        else if (gradeNumber >= 80)
        {
            letter = "B";
         }
        else if (gradeNumber >= 70)
        {
            letter = "C";
         }
        else if (gradeNumber >= 60)
        {
            letter = "D";
         }
        else if (gradeNumber < 60)
        {
            letter = "F";
         }
        else
        {
            Console.WriteLine("Your input was invalid. Please try again.");
        }

        if (gradeNumber >70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the class. Try again next time!");
        }
        
        Console.WriteLine($"Your grade was: {letter}");
    }
}