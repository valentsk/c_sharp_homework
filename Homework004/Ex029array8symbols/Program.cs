// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Ограничения:
// - Должна быть отдельная функция, которая создаёт массив и отдельная функция вывода
// - Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода или в функции вывода


int[] MakeArray()
{
    int length = 8;
    int[] array = new int[length];
    return array;
}

void FillArray(int[] array)
{
    Random randGenerator = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = randGenerator.Next();
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i < array.Length - 1)
        {
            Console.Write($", ");
        }
        else
        {
            Console.Write($"]");
        }
    }
}

Console.Clear();

int[] array = MakeArray();
FillArray(array);
PrintArray(array);