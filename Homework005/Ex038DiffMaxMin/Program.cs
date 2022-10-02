// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double[] CreateArray()
{
    Console.Write("Введи размерность массива: ");
    int size = int.Parse(Console.ReadLine()!);
    double[] array = new double[size];
    return array;
}

void FillArray(double[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next(-99, 100);
    }
}

void PrintArray(double[] array)
{
    Console.Write("Массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

double DiffMaxMinElement(double[] array)
{
    int minInd = 0;
    int maxInd = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > array[maxInd])
        {
            maxInd = i;
        }
       if (array[i] < array[minInd])
        {
            minInd = i;
        }        
    }
    double result = array[maxInd] - array[minInd];
    return result;
}

Console.Clear();
double[] array = CreateArray();
FillArray(array);
PrintArray(array);
Console.WriteLine();
double diff = DiffMaxMinElement(array);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {diff}");