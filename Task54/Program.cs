﻿// Задача 54: Задайте двумерный массив.
// Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);    
        }        
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j], 5}");
        }        
        Console.WriteLine();
    }
    
}
void SortRowsMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int currentIndex = 0; currentIndex < matrix.GetLength(1) - 1; currentIndex++)
        {
            for (int j = currentIndex + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > matrix[i,currentIndex])
                {
                    int temp = matrix[i,currentIndex];
                    matrix[i,currentIndex] = matrix[i, j];
                    matrix[i, j] = temp;
                }
            }
        }
    }
}

Console.WriteLine("Введите количество строк m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] intMatrix = CreateMatrixRndInt(m, n, 1, 10);
PrintMatrix(intMatrix);
Console.WriteLine();
SortRowsMatrix(intMatrix);
PrintMatrix(intMatrix);