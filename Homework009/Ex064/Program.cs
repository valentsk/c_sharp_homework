﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные
//  числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Введите N: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine(RecNum(number));

int RecNum(int number)
{
    if (number > 1)
    {
        Console.Write($"{number} ");
        return RecNum(number - 1);
    }
    else
    {
        return 1;
    }
}