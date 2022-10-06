﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine()!);

Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine()!);

if (k1 * b2 == k2 * b1)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    Console.WriteLine($"Точка переключений (x; y) = ({Finddoubleersection(k1, b1, k2, b2).Item1}; {Finddoubleersection(k1, b1, k2, b2).Item2})");
}

(double, double) Finddoubleersection(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * (b2 - b1) / (k1 - k2) + b1;
    var result = (x, y);
    return (result);
}