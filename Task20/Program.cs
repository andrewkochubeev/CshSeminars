// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты первой точки:");
Console.Write("X1 = ");
int xPoint1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 = ");
int yPoint1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.Write("X2 = ");
int xPoint2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 = ");
int yPoint2 = Convert.ToInt32(Console.ReadLine());

double dist = Distance(xPoint1, yPoint1, xPoint2, yPoint2);
Console.WriteLine(Math.Round(dist, 2, MidpointRounding.ToZero));

double Distance(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}