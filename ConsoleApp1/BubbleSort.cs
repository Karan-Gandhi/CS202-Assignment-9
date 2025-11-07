using System;

class BubbleSort
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the array you want to sort:");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine($"Enter {n} integers to sort:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Sorted array:");
        foreach (int num in arr)
        {
            Console.WriteLine(num);
        }
    }
}