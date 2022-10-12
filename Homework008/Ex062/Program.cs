// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();

int[,] arrayOne = new int[4, 4];
FillArray(arrayOne);
PrintArray(arrayOne);

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
    int number = 1;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[0, j] += number;
        number++;
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        array[i, array.GetLength(1) - 1] += number;
        number++;
    }

    for (int j = array.GetLength(1) - 2; j >= 0; j--)
    {
        array[array.GetLength(0) - 1, j] += number;
        number++;
    }

    for (int i = array.GetLength(0) - 2; i > 0; i--)
    {
        array[i, 0] += number;
        number++;
    }

    for (int j = 1; j < array.GetLength(1) - 1; j++)
    {
        array[1, j] += number;
        number++;
    }

    array[2,2] += number;
    number++;

    array[2,1]+= number;
    number++;
}


