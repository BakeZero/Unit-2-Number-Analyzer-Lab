using System;

public class Program
{
    static void Main()
    {
        Console.Write("Welcome to the Number Analyzer, what is your name? ");
        string name = Console.ReadLine();
        int numInput;

        while (true)
        {
            Console.Write($"{name}, please enter a number between 1 and 100: ");
            numInput = int.Parse(Console.ReadLine());
            if (numInput < 1 || numInput > 100)
            {
                Console.WriteLine("Invalid input, please try again.\n");
                continue;
            }

            if (numInput%2 == 1) // Odds
            { 
                if (numInput < 60)
                    Console.WriteLine($"{numInput} is odd and less than 60");
                else
                    Console.WriteLine($"{numInput} is odd and greater than 60");
            }
            else // Evens
            {
                if (numInput <= 24)
                    Console.WriteLine($"{numInput} is even and less than 25");
                else if (numInput <= 60)
                    Console.WriteLine($"{numInput} is even and between 26 and 60 inclusive");
                else
                    Console.WriteLine($"{numInput} is even and greater than 60");
            }

            Console.Write("Continue? y/n: ");
            string prompt = Console.ReadLine();
            Console.WriteLine();
            if (prompt == "n")
                break;
        }
        Console.WriteLine("Bye!");
    }
}