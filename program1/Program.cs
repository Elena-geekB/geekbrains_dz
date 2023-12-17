using System;

class Program1
{
    static void Main()
    {
        /*Задача 1. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
        и возвращает значение этого элемента или же указание, что такого элемента нет.*/
        int[,] array2 = {
            {4, 3, 1},
            {2, 6, 9},
        };

        PrintArray(array2);

        Console.Write("Введите строку: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите столбец: ");
        int column = int.Parse(Console.ReadLine());

        int result = GetElementValue(array2, row, column);

        if (result != int.MinValue)
        {
            Console.WriteLine($"Значение элемента в позиции [{row}, {column}]: {result}");
        }
        else
        {
            Console.WriteLine($"Элемента в позиции [{row}, {column}] не существует.");
        }
    }

    static void PrintArray(int[,] array)
    {
        Console.WriteLine("Двумерный массив:");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j],4}");
            }
            Console.WriteLine();
        }
    }

    static int GetElementValue(int[,] array, int row, int column)
    {
        int rowCount = array.GetLength(0);
        int columnCount = array.GetLength(1);

        return (row >= 0 && row < rowCount && column >= 0 && column < columnCount) ? array[row, column] : int.MinValue;
    }
}