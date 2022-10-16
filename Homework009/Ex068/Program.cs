// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


Console.Clear();

Console.Write("Введите M: ");
int numberM = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int numberN = int.Parse(Console.ReadLine()!);

Console.WriteLine(RecAccerman(numberM, numberN));

int RecAccerman(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return (numberN + 1);
    }
    else if ((numberN == 0) && (numberM > 0))
    {
        return RecAccerman(numberM - 1, 1);
    }
    else
    {
        return RecAccerman(numberM - 1, RecAccerman(numberM, numberN - 1));
    }
}