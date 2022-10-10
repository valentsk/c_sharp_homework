// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1
// 7 -> такого числа в массиве нет

Console.Clear();
int[,] array = new int[5, 5];
FillArray(array);
PrintArray(array);

Console.Write("Введите индекс по строкам: ");
int indexI = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс по столбцам: ");
int indexJ = int.Parse(Console.ReadLine()!);
FindNumber(indexI, indexJ, array);

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
            array[i, j] = generator.Next(-9,10);
        }
    }
}

void FindNumber(int indexI, int indexJ, int[,] array)
{
   if ((indexI <= array.GetLength(0)) && (indexJ <= array.GetLength(1)))
   {
        Console.Write(array[indexI, indexJ]);
   }
   else
   {
        Console.Write("Такого элемента нет");
   }
}