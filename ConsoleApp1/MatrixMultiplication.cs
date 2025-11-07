using System;

class MatrixMultiplication
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the dimentions of matrix 1 (rows and columns):");
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[,] matrix1 = new int[n, m];
        Console.WriteLine("Enter the elements of matrix 1:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter the dimentions of matrix 2 (rows and columns):");
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());

        if (m != p)
        {
            Console.WriteLine("Matrix multiplication is not possible with the given dimensions.");
            return;
        }

        int[,] matrix2 = new int[p, q];
        Console.WriteLine("Enter the elements of matrix 2:");
        for (int i = 0; i < p; i++)
        {
            for (int j = 0; j < q; j++)
            {
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int[,] result = new int[n, q];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < q; j++)
            {
                result[i, j] = 0;
                for (int k = 0; k < m; k++)
                {
                    result[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }

        Console.WriteLine("Resultant matrix after multiplication:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < q; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}