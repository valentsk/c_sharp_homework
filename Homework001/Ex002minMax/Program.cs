// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7 min = 5
// a = 2 b = 10 -> max = 10 min = 2
// a = -9 b = -3 -> max = -3 min = -9

Console.Clear();

Console.WriteLine("Введите два различных числа");

Console.Write("Введите первое число: ");
string inputA = Console.ReadLine();
int numberA = int.Parse(inputA);

Console.Write("Введите второе число: ");
string inputB = Console.ReadLine();
int numberB = int.Parse(inputB);

if (numberA > numberB)
{
    Console.WriteLine("Первое число больше второго.");
    Console.WriteLine("max: " + numberA);
    Console.WriteLine("min: " + numberB);
}
else if (numberA < numberB)
{
    Console.WriteLine("Второе число больше первого.");
    Console.WriteLine("max: " + numberB);
    Console.WriteLine("min: " + numberA);
}
else
{
    Console.WriteLine("Числа равны");
}