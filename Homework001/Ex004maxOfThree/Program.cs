// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Clear();

Console.WriteLine("Введите три различных числа");

Console.Write("Введите первое число: ");
string inputA = Console.ReadLine();
int numberA = int.Parse(inputA);

Console.Write("Введите второе число: ");
string inputB = Console.ReadLine();
int numberB = int.Parse(inputB);

Console.Write("Введите третье число: ");
string inputC = Console.ReadLine();
int numberC = int.Parse(inputC);

if (numberA > numberB & numberA > numberC)
{
    Console.WriteLine("Первое число максимальное и равно "+ numberA);
}
else if (numberB > numberA & numberB > numberC)
{
    Console.WriteLine("Второе число максимальное и равно "+ numberB);
}
else if (numberC > numberA & numberC > numberB)
{
    Console.WriteLine("Третье число максимальное и равно "+ numberC);
}
else
{
    Console.WriteLine("Какие-то числа равны между собой");
}