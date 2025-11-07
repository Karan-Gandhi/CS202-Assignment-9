using System;

class RowMajor
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of columns:");
        int cols = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of rows:");
        int rows = int.Parse(Console.ReadLine());

        int[] rowMajorOrder = new int[rows * cols];

        Console.WriteLine($"Enter {rows * cols} elements for the 2D array:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int index = i * cols + j;
                rowMajorOrder[index] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("The elements in row-major order are:");

        foreach (int element in rowMajorOrder)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine("Elements in the original matrix format:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int index = i * cols + j;
                Console.Write(rowMajorOrder[index] + " ");
            }
            Console.WriteLine();
        }
    }
}