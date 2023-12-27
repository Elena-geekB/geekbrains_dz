using System;

class Program4
{
    /*Задача 1. Задайте значения M и N.
    Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
    Использовать рекурсию, не использовать циклы.*/
    static void Main()
    {
            Console.Write("Введите значение M: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите значение N: ");
            int n = int.Parse(Console.ReadLine());

            PrintNaturalNumbersInRange(m, n);

            Console.ReadLine();
    }

    //Рекурсивная функция
    static void PrintNaturalNumbersInRange(int m, int n)
    {
        if (m <= n)
        {
                Console.Write($"{m}, ");
                PrintNaturalNumbersInRange(m + 1, n);
        }
    }
}