// Задача 2*. Написать программу, которая принимает от пользователя положительные числа и считает среднее значение этих чисел.
// Ввод числе осуществляется до тех пор, пока пользовател не введёт -1. Ввод чисел и расчёт должен происходит в рекурсии
// 1
// 2
// 3
// 4
// -1
// -> 2,5

double Avarage(double result = 0, double count = 1, double sum = 0)
{
    double newNumber = double.Parse(Console.ReadLine()!);
    if (newNumber == -1)
    {
        return Math.Round(result,2);
    }
    else
    {
        sum += newNumber;
        result = sum / count;
        count++;
        return Avarage(result, count, sum);
    }
}

Console.Write("Введите числа через Enter, в конце -1: ");
Console.Write(Avarage());