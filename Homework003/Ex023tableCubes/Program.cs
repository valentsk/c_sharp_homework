// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

void cubeNumberFor(int number)
{
    Console.Write("Через функцию + цикл For:   ");
    for (int i = 1; i < number + 1; i++)
    {
        Console.Write(Math.Pow(i, 3));
        if (i < number)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}

void cubeNumberWhile(int number)
{
    int i = 1;
    Console.Write("Через функцию + цикл While: ");
    while (i < number + 1)
    {
        Console.Write(Math.Pow(i, 3));
        if (i < number)
        {
            Console.Write(", ");
        }
        i++;
    }
    Console.WriteLine();
}

int x = -1;
while (true)
{
    try
    {
        Console.Write("Введите число: ");
        x = Math.Abs(int.Parse(Console.ReadLine()!));
        break;
    }
    catch
    {
        Console.WriteLine("Некорректный ввод (символы, строки), введите число");
    }
}

cubeNumberFor(x);
cubeNumberWhile(x);