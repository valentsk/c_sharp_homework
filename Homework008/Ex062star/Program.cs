// Доп задача 1. Задача 59: Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7

Console.Clear();

Console.Write("Введите m: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите n: ");
int n = int.Parse(Console.ReadLine()!);


int[,] array = new int[m, n];

Console.WriteLine("Исходный массив: ");
FillArray(array);
PrintArray(array);

Console.WriteLine($"Индекс строк мин: {FindMin(array).Item1}. Индекс колоннок мин: {FindMin(array).Item2}");

PrintArray(CreateNewArrayZero(array, FindMin(array).Item1, FindMin(array).Item2));

Console.WriteLine("Итоговый массив: ");
int[,] arrayMin = CreateNewArray(array, FindMin(array).Item1, FindMin(array).Item2);
PrintArray(arrayMin);


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

(int, int) FindMin(int[,] array)
{
    int indexRowMin = 0;
    int indexColMin = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[indexRowMin, indexColMin])
            {
                indexRowMin = i;
                indexColMin = j;
            }
        }
    }
    var result = (indexRowMin, indexColMin);
    return result;
}

int[,] CreateNewArrayZero(int[,] array, int iMin, int jMin)
{
    int[,] arrayNew = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == iMin)
        {
            continue;
        }
        else
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == jMin)
                {
                    continue;
                }
                else
                {
                    arrayNew[i, j] = array[i, j];
                }
            }
        }

    }
    return arrayNew;
}

int[,] CreateNewArray(int[,] array, int iMin, int jMin)
{
    int[,] arrayNew = new int[m - 1, n - 1];

    // 1 четверть
    for (int i = 0; i < iMin; i++)
    {
        for (int j = 0; j < jMin; j++)
        {
            arrayNew[i, j] = array[i, j];
        }
    }

    // 2 четверть
    for (int i = 0; i < iMin; i++)
    {
        for (int j = jMin; j < array.GetLength(1) - 1; j++)
        {
            arrayNew[i, j] = array[i, j + 1];
        }
    }
    // 3 четверть
    for (int i = iMin; i < arrayNew.GetLength(0); i++)
    {
        for (int j = jMin; j < arrayNew.GetLength(1); j++)
        {
            arrayNew[i, j] = array[i + 1, j + 1];
        }
    }

    // 4 четверть
    for (int i = iMin; i < arrayNew.GetLength(0); i++)
    {
        for (int j = 0; j < jMin; j++)
        {
            arrayNew[i, j] = array[i + 1, j];
        }
    }
    return arrayNew;
}