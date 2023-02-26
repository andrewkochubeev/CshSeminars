// Напишите программу, которая
// на вход принимает число (N), а на
// выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите целое число:");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= num)
{
    Console.Write(count + " ");
    count += 2;
}