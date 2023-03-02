// Напишите программу, которая
// принимает на вход число (N) и
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    TableCube(number);
}
else
{
    Console.WriteLine("Введено не натуральное число");
}

void TableCube(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i, 5}    {i * i * i, 5}");
    }
}