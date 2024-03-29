﻿// Задача 47. Задайте двумерный массив
// размером m×n, заполненный случайными
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndDouble(int rows, int columns, int min, int max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            double num = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(num, 1);
        }

    }
    return matrix;
}
void PrintMatrixDouble(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 6}");
        }
        Console.WriteLine();
    }

}

Console.WriteLine("Введите количество строк m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов n:");
int n = Convert.ToInt32(Console.ReadLine());

double[,] doubleMatrix = CreateMatrixRndDouble(m, n, 1, 10);
PrintMatrixDouble(doubleMatrix);