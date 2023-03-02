// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    TableSquare(number);
}
else
{
    Console.WriteLine("Введено не натуральное число");
}

void TableSquare(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i}    {i * i}");
    }
}