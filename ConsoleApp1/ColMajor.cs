using System;

class ColMajor
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number of columns:");
        int cols = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of rows:");
        int rows = int.Parse(Console.ReadLine());

        int[] colMajorOrder = new int[rows * cols];

        Console.WriteLine($"Enter {rows * cols} elements for the 2D array:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int index = j * rows + i;
                colMajorOrder[index] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("The elements in column-major order are:");
        foreach (int element in colMajorOrder)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine("Elements in the original matrix format:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int index = j * rows + i;
                Console.Write(colMajorOrder[index] + " ");
            }
            Console.WriteLine();
        }
    }
}