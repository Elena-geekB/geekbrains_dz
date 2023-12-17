using System;

class Program3
{
    static void Main()
    {
    /*Задача 3. Задайте прямоугольный двумерный массив.
    Напишите программу, которая будет находить строку с наименьшей суммой элементов.*/
        int[,] rectangularArray = {
            {4, 3, 1},
            {2, 6, 9},
            {4, 6, 2}
        };

        Console.WriteLine("Прямоугольный двумерный массив:");
        PrintArray(rectangularArray);

        int minSumRow = FindRowWithMinSum(rectangularArray);

        Console.WriteLine($"\nСтрока с индексом {minSumRow} имеет наименьшую сумму элементов.");
    }

    static int FindRowWithMinSum(int[,] array)
    {
        int minSum = int.MaxValue;
        int minSumRow = -1;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            int currentSum = 0;

            for (int j = 0; j < array.GetLength(1); j++)
            {
                currentSum += array[i, j];
            }

            if (currentSum < minSum)
            {
                minSum = currentSum;
                minSumRow = i;
            }
        }

        return minSumRow;
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