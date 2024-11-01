using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        string input;
        float sum = 0;
        int greatest = 0;
        Console.WriteLine("Please enter a list of numbers, type 0 when finished.");
        while (number != 0)
        {
            Console.Write("Number: ");
            input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        foreach (int i in numbers)
        {
            sum += i;
            if (i > greatest)
            {
                greatest = i;
            }
        }
        float count = numbers.Count;
        float average = sum / count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {greatest}");

    }
}