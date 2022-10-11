// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);


int[,] array = new int[m, n];

Console.WriteLine("Исходный массив: ");
FillArray(array);
PrintArray(array);

int sumMin = SumFirst(array);
int indexMin = 0;

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {SumArray(array, sumMin, indexMin)}");

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(0, 10);
        }
    }
}


int SumFirst(int[,] array)
{
    int sumMin = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumMin += array[0, j];
    }
    return sumMin;
}


int SumArray(int[,] array, int sumMin, int indexMin)
{
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < sumMin)
        {
            sumMin = sum;
            indexMin = i;
        }
    }
    return indexMin;
}
