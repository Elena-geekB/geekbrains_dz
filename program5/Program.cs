using System;

class Program5
{
    /*Задача 2. Напишите программу вычисления функции Аккермана с помощью рекурсии.
    Даны два неотрицательных числа m и n.*/
    static void Main()
    {
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());
    
        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());
    
        int result = AckermannFunction(m, n);
    
        Console.WriteLine($"A({m}, {n}) = {result}");
    
        Console.ReadLine();
    }
    
    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
        else
        {
            Console.WriteLine("Ошибка: некорректные входные данные.");
            return -1;
        }
    }
}