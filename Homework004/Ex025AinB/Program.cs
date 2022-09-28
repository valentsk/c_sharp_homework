// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Ограничения:
// - Нельзя использовать класс Math
// - Должна быть отдельная функция Power, которая возвразает результат
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

int Power(int number1, int number2)
{
    int result = number1;
    for (int i = 1; i < number2; i++)
    {
        result *= number1;
    }
    return result;
}

Console.Clear();

Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine()!);
int numberB = -1;
while (true)
{
    try
    {
        Console.Write("Введите натуральную степень числа: ");
        numberB = int.Parse(Console.ReadLine()!);
        if (numberB > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорректный ввод, введите натуральную степень числа (1, 2, 3, ...): ");
        }
    }
    catch
    {
        Console.WriteLine("Некорректный ввод (символы, строки), введите натуральную степень числа (1, 2, 3, ...): ");
    }
}

Console.WriteLine($"Результат возведения числа {numberA} в степень {numberB} равен {Power(numberA, numberB)}");
