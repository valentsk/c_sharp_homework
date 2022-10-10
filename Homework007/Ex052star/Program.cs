// Задача *. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Console.Write("Введите N: ");
int number = int.Parse(Console.ReadLine()!);
int numberZero = 0;
int numberOne = 1;

int[] array = new int[number + 1];
array[0] = 0;
array[1] = 1;
for (int i = number; i > 1; i--)
{
    array[i] = number;
    number -= 1;
}

void PrintArray(int[] array)
{
    Console.Write("Массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PrintArray(array);
FibArray(array);

void FibArray(int[] array)
{
    Console.Write("Фибо: ");
    int res = array[0] + array[1];
    for (int i = 2; i < array.Length - 1; i++)
    {
        res += array[i];
        Console.Write($"{res} ");
    }
}