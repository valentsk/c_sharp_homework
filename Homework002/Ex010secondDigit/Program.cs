// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();

int number = -1;
while (true)
{
    try
    {
        Console.Write("Введите трехзначное число: ");
        number = Math.Abs(int.Parse(Console.ReadLine()!));
        if (number > 99 && number < 1000)
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорректный ввод, введите трехзначное число");
        }
    }
    catch
    {
        Console.WriteLine("Некорректный ввод (символы, строки), введите трехзначное число");
    }
}

int secondDigit = number % 100 / 10;
Console.WriteLine($"Вторая цифра: {secondDigit}");
