// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N. Рекурсивно
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите M: ");
int numberM = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int numberN = int.Parse(Console.ReadLine()!);

Console.WriteLine(RecSum(numberM, numberN));

int RecSum(int numberM, int numberN, int sum = 0)
{
    if (numberM <= numberN)
    {
        sum += numberM;
        numberM += 1;
        return RecSum(numberM, numberN, sum);
    }
    else
    {
        return  sum;
    }
}