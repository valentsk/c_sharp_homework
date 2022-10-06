// Задача 41: Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 5
// 0
// 7
// 8
// -2
// -2 -> 2
// 5
// 1
// -7
// 567
// 89
// 223-> 3


int FindPositiveNumbers(int number)
{
    int count = 0;
    while (number > 0)
    {
        int numberNew = int.Parse(Console.ReadLine()!);
        if (numberNew > 0)
        {
            count++;
        }
        number--;
    }
    return count;
}

Console.Write("Введите количество чисел: ");
int numberM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Теперь через Enter введите числа: ");
Console.Write($"Сколько положительных чисел введено: {FindPositiveNumbers(numberM)}");