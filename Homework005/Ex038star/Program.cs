// Найти в массиве самую длинную последовательность, состоящую из одинаковых элементов.
// Вывести на экран количество элементов самой длиной последовательности, 
// элемент самой последовательности и номер элемента, который является ее началом.

void PrintArray(int[] array)
{
    Console.Write("Массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

(int, int, int) LongDigits(int[] array)
{
    int countMax = 1; // счетчик для запоминания максимального из всех последовательностей
    int countNow = 1; // счетчик для запоминания длины текущей последовательности
    int indexMax = 0; // индекс первого максимального
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i + 1])
        {
            countNow++;
        }
        else
        {
            if (countMax < countNow)
            {
                countMax = countNow;
                indexMax = i - countNow + 1; // из текущего индекса вычитаем 
                countNow = 1;
            }
            else
            {
                countNow = 1;
            }
        }
    }
    if (countMax < countNow) // для случая, если максимальной оказывается последняя последовательность
    {
        countMax = countNow;
        indexMax = array.Length - countNow;
    }

    (int, int, int) result = (countMax, indexMax, array[indexMax]); // список из нужных данных
    
    return result;
}

int[] array1 = { 1, 2, 2, 3, 3, 3, 4, 4, 5, 5, 6, 6, 6, 6, 8, 8, 8, 8, 8 }; // в конце
int[] array2 = { 1, 2, 2, 3, 3, 3, 4, 4, 5, 5, 6, 6, 6, 6, 8, 8, 8, 8, 8, 1 }; // в середине
int[] array3 = { 1, 1, 1, 5, 5, 1, 1, 1 }; // в начале
int[] array4 = { 1, 2, 2, 4, 4, 4, 4, 3, 3, 3 }; // c условия

PrintArray(array1);
Console.WriteLine();
Console.WriteLine($"Длина последовательности, индекс начала, элемент последовательности: {LongDigits(array1)}");

PrintArray(array2);
Console.WriteLine();
Console.WriteLine($"Длина последовательности, индекс начала, элемент последовательности: {LongDigits(array2)}");

PrintArray(array3);
Console.WriteLine();
Console.WriteLine($"Длина последовательности, индекс начала, элемент последовательности: {LongDigits(array3)}");

PrintArray(array4);
Console.WriteLine();
Console.WriteLine($"Длина последовательности, индекс начала, элемент последовательности: {LongDigits(array4)}");
