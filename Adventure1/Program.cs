// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да



System.Console.WriteLine("Enter num");
int a = Convert.ToInt32(Console.ReadLine());
if (a > 99999 || a < 10000)
{
    System.Console.WriteLine("Это не пятизначное число");
}
else
    System.Console.WriteLine("Это пятизначное число");


int b = (a % 10 - a % 1) / 1;

int d = (a % 100000 - a % 10000) / 10000;

int c = (a % 100 - a % 10) / 10;

int e = (a % 10000 - a % 1000) / 1000;


if (b == d && c == e)
{
    System.Console.WriteLine($"Число {a} является палендромом ");
}
else
    System.Console.WriteLine($"Число {a} не является палендромом ");