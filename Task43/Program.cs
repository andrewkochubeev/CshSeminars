// Задача 43: Напишите программу, которая
// найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// k1*x + b1 = k2*x + b2
// (k1 - k2)*x = b2 - b1
// x = (b2 - b1) / (k1 - k2)

bool IsPointIntersect(int k1Cf, int b1Cf, int k2Cf, int b2Cf)
{
    if (k1Cf == k2Cf && b1Cf == b2Cf)
    {
        Console.WriteLine("Прямые равны!");
        return false;
    }
    else if (k1Cf == k2Cf)
    {
        Console.WriteLine("Прямые параллельны!");
        return false;
    }
    else return true;
}
double[] IntersectCoord(int k1Cf, int b1Cf, int k2Cf, int b2Cf)
{
    double[] coordArr = new double[2];
    coordArr[0] = (double)(b2Cf - b1Cf) / (k1Cf - k2Cf);
    coordArr[1] = k1Cf * coordArr[0] + b1Cf;
    return coordArr;
}
Console.WriteLine("y = k1*x + b1 и y = k2*x + b2");

Console.Write("k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());


if (IsPointIntersect(k1, b1, k2, b2)) 
{
    double[] coord = IntersectCoord(k1, b1, k2, b2);
    Console.WriteLine($"Координаты точки пересечения ({coord[0]}, {coord[1]})");
}