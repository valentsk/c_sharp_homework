// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.Write("Введите положительное число: ");
string input = Console.ReadLine();
int number = int.Parse(input);
int startNumber = 1;

if (number <= 0)
{
    Console.Write("Введено неположительное число!");
}
else
{
    while (startNumber <= number)
    {
        if (startNumber % 2 == 0)
        {
            Console.Write($"{startNumber}, ");
        }
        startNumber += 1;
    }
}