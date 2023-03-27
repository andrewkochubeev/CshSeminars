﻿// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите натуральное число M");
int numM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N");
int numN = Convert.ToInt32(Console.ReadLine());

int resultSum = numN;
SumNaturalNumbers(numM, numN, resultSum);

void SumNaturalNumbers(int m, int n, int sum)
{
    if (m > n)
    {
        sum += m;
        SumNaturalNumbers(m - 1, n, sum);
    }
    else if (m < n)
    {
        sum += m;
        SumNaturalNumbers(m + 1, n, sum);
    }
    else Console.WriteLine($"Сумма элементов равна {sum}");
}