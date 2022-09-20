// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

int number = -1;
while (true)
{
    try
    {
        Console.Write("Введите число: ");
        number = Math.Abs(int.Parse(Console.ReadLine()!));
        break;
    }
    catch
    {
        Console.WriteLine("Некорректный ввод (символы, строки), введите число");
    }
}

if (number < 100)
{
    Console.WriteLine($"Третьей цифры нет");
}
else
{
    string numberA = Convert.ToString(number);
    Console.WriteLine($"Третья цифра: {numberA[2]}");
}
