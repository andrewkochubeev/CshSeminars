﻿// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}
void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
double DiffMinMax(double min, double max)
{
    double diff = max - min;
    diff = Math.Round(diff, 1);
    return diff;
}
double MinNum(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}
double MaxNum(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

Console.WriteLine("Введите размер массива:");
int sizeArr = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArrayRndDouble(sizeArr, -50, 50);
PrintArrayDouble(array);
double diffMinMax = DiffMinMax(MinNum(array), MaxNum(array));
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {diffMinMax}");