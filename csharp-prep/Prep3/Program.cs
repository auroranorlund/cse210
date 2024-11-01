using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        string again;
        string guess;
        int guessnumber;
        do 
        {
            int number = randomGenerator.Next(1, 101);
            int attempts = 1;
                do
                {
                    Console.Write("What is your guess? ");
                    guess = Console.ReadLine();
                    guessnumber = int.Parse(guess);
                    if (guessnumber > number)
                    {
                        Console.WriteLine("Lower");
                        attempts++;
                    }
                    else if (guessnumber < number)
                    {
                        Console.WriteLine("Higher");
                        attempts++;
                    }
                } while (guessnumber != number);
            Console.WriteLine($"You guessed it! It took you {attempts} tries.");
            Console.Write("Would you like to play again? ");
            again = Console.ReadLine();
        } while (again == "yes");
        Console.WriteLine("Thank you for playing!");
    }
}