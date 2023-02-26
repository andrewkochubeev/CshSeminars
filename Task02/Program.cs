// Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число
// большее, а какое меньшее.
Console.WriteLine("Введите число a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) Console.WriteLine($"Число {a} - большее, {b} - меньшее");
else if (b > a) Console.WriteLine($"Число {b} - большее, {a} - меньшее");
else Console.WriteLine("Числа равны!");