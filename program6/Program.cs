using System;

class Program6
{
    /*Задача 3. Задайте произвольный массив. Выведете его элементы, начиная с конца.
    Использовать рекурсию, не использовать циклы.*/
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        // Заполняем массив значениями, введенными пользователем
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Введите элемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nИсходный массив:");
        PrintArray(array, 0);

        // Выводим массив в обратном порядке после нажатия Enter
        Console.WriteLine("\nНажмите Enter для вывода массива в обратном порядке.");
        Console.ReadLine();
        PrintArrayReverse(array, 0);

        Console.ReadLine();
    }

    static void PrintArray(int[] array, int index)
    {
        if (index < array.Length)
        {
            Console.Write($"{array[index]} ");
            PrintArray(array, index + 1);
        }
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        if (index < array.Length)
        {
            PrintArrayReverse(array, index + 1);
            Console.Write($"{array[index]} ");
        }
    }
}
