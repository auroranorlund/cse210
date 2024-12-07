using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("John Doe", "Theater History");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment("Stephanie Waters", "Long Division", "9.2", "10-20");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());

        WritingAssignment assignment3 = new WritingAssignment("Anthony Sanchez", "Romeo and Juliet", "The Cultural Legacy of Romeo and Juliet");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}