// Напишите цикл, который
// принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А:");
int numA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральную степень B:");
int numB = Convert.ToInt32(Console.ReadLine());

int expon = Expon(numA, numB);
Console.WriteLine(numB > 0 ? $"{numA} в степени {numB} = {expon}" : "Ненатуральная степень");

int Expon(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++)
    {
        res = res * a;
    }
    return res;
}