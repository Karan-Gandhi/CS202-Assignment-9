using System;

class LoopsAndFunctions
{
    public static int Factorial(int n)
    {
        if (n <= 1)
            return 1;
        return n * Factorial(n - 1);
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Printing numbers from 1 to 10 using for loop:");

        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Printing numbers from 1 to 10 using foreach loop:");

        foreach (int number in Enumerable.Range(1, 10))
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        Console.WriteLine("We will now keep accepting input until you type 'exit'.");

        string input;

        do
        {
            input = Console.ReadLine();
            Console.WriteLine($"You entered: {input}");
        } while (input.ToLower() != "exit");

        Console.WriteLine("Exited the loop.");

        Console.WriteLine("Enter number for which you want to calculate factorial:");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"Factorial of {num} is {Factorial(num)}");
    }
}