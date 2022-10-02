// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray()
{
    Console.Write("Введи размерность массива: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];
    return array;
}

void FillArray(int[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(0, 9);
    }
}

void PrintArray(int[] array)
{
    Console.Write("Массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int FindSummNoEvenIndex(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            result += array[i];
        }
    }
    return result;
}

Console.Clear();
int[] array = CreateArray();
FillArray(array);
PrintArray(array);
Console.WriteLine();
int sumNoEven = FindSummNoEvenIndex(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumNoEven}");