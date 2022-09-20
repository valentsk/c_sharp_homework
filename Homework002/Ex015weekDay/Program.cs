// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

int day = -1;
while (true)
{
    try
    {
        Console.Write("Введите день недели: ");
        day = int.Parse(Console.ReadLine()!);
        if (day > 0 && day < 8)
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорректный ввод, введите день недели от 1 до 7");
        }
    }
    catch
    {
        Console.WriteLine("Некорректный ввод (символы, строки), введите день недели от 1 до 7");
    }
}

if (day > 5)
{
    Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("Это не выходной день");
}