// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

Console.WriteLine("Первый массив:");
Console.Write("Введите число строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов: ");
int n = int.Parse(Console.ReadLine()!);
int[,] arrayOne = new int[m, n];
FillArray(arrayOne);
PrintArray(arrayOne);

Console.WriteLine();

Console.WriteLine("Второй массив:");
Console.WriteLine("Для умножения матриц число столбцов первой матрицы совпадает с числом строк второй матрицы");
Console.Write("Введите число столбцов: ");
int n2 = int.Parse(Console.ReadLine()!);
int[,] arrayTwo = new int[n, n2];
Console.WriteLine("Второй массив: ");
FillArray(arrayTwo);
PrintArray(arrayTwo);

Console.WriteLine();
Console.WriteLine("Произведение массивов:");
PrintArray(ProductMatrix(arrayOne, arrayTwo));


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
