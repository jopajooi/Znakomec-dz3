// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


double x1 = ReadDouble("Введите координату X первой точки: ");
double y1 = ReadDouble("Введите координату Y первой точки: ");
double z1 = ReadDouble("Введите координату Z первой точки: ");
double x2 = ReadDouble("Введите координату X второй точки: ");
double y2 = ReadDouble("Введите координату Y второй точки: ");
double z2 = ReadDouble("Введите координату Z второй точки: ");

double A = x2 - x1;
double B = y2 - y1;
double C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");


double ReadDouble(string message)
{
    Console.Write(message);
    return Convert.ToDouble(Console.ReadLine());
}
