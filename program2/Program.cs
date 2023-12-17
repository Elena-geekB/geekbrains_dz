using System;

class Program2
{
    static void Main()
    {
        int[,] array2 = {
            {4, 3, 1},
            {2, 6, 9},
            {4, 6, 2},
        };

        Console.WriteLine("Исходный двумерный массив:");
        PrintArray(array2);

        SwapFirstAndLastRows(array2);

        Console.WriteLine("\nДвумерный массив после обмена:");
        PrintArray(array2);
    }

    static void SwapFirstAndLastRows(int[,] array)
    {
        int rowCount = array.GetLength(0);

        if (rowCount >= 2)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int temp = array[0, j];
                array[0, j] = array[rowCount - 1, j];
                array[rowCount - 1, j] = temp;
            }
        }
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}