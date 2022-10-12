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
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = generator.Next(1, 10);
        }
    }
}


int[,] ProductMatrix(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] arrayProduct = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];

    for (int i = 0; i < arrayProduct.GetLength(0); i++)
    {
        for (int j = 0; j < arrayProduct.GetLength(1); j++)
        {
            for (int k = 0; k < arrayOne.GetLength(0); k++)
            {
                arrayProduct[i, j] += arrayOne[i, k] * arrayTwo[k, j];
            }
        }
    }
    return arrayProduct;
}
