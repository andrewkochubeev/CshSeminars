// Напишите программу, которая
// принимает на вход координаты
// двух точек и находит расстояние
// между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки:");
Console.Write("X1 = ");
int xPoint1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1 = ");
int yPoint1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1 = ");
int zPoint1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.Write("X2 = ");
int xPoint2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2 = ");
int yPoint2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2 = ");
int zPoint2 = Convert.ToInt32(Console.ReadLine());

double dist = Distance(xPoint1, yPoint1, zPoint1, xPoint2, yPoint2, zPoint2);
Console.WriteLine(Math.Round(dist, 2, MidpointRounding.ToZero));

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}