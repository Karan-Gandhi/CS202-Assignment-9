using System;

class BasicSyntax
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int b = int.Parse(Console.ReadLine());

        int sum = a + b;
        int difference = a - b;
        int product = a * b;
        double quotient = (double)a / b;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
        Console.WriteLine($"Product: {product}");
        Console.WriteLine($"Quotient: {quotient}");

        if (sum % 2 == 0)
        {
            Console.WriteLine("The sum is even.");
        }
        else
        {
            Console.WriteLine("The sum is odd.");
        }
    }
}