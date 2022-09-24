// 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

int number = -1;
while (true)
{
    try
    {
        Console.Write("Введите пятизначное число: ");
        number = Math.Abs(int.Parse(Console.ReadLine()!));
        if (number > 9999 && number < 100000)
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорректный ввод, введите пятизначное число");
        }
    }
    catch
    {
        Console.WriteLine("Некорректный ввод (символы, строки), введите пятизначное число");
    }
}
int firstDigit = number / 10000;
int fifthDigit = number % 10;
int secondDigit = number / 1000 % 10;
int fourthDigit = number / 10 % 10;

if ((firstDigit == fifthDigit) && (secondDigit == fourthDigit))
{
    Console.Write("Число является палиндромом");
}
else
{
    Console.Write("Число не является палиндромом");
}