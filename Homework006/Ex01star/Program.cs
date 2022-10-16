// Задача 1*. Написать программу, которая рекурсивным методом переводит числа из десятичной системы счисления в двоичную
// 2 -> 10
// 11 -> 1011
// 16 -> 10000
 
string TranslateDexToBin(int number, string str = "")
{
    if (number == 1)
    {
        return str +="1";
    }
    else
    {
        int res = number % 2;
        str += Convert.ToString(res);
        number = number / 2;
        return TranslateDexToBin(number, str);
    }
}

string StringToReverseString(string str)
{
    string newStr = "";
    for (int i = str.Length - 1; i > -1; i--)
    {
        newStr += str[i];
    }
    return newStr;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
string str = TranslateDexToBin(number);
Console.WriteLine($"В двоичном: {StringToReverseString(str)}");

