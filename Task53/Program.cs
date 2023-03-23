// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.
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
void SwapRows(int[,] matrix)
{
    int temp = 0;
    int lastRow = matrix.GetLength(0) - 1;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[0, i];
        matrix[0, i] = matrix[lastRow, i];
        matrix[lastRow, i] = temp;
    }
    
}
Console.WriteLine("Введите количество строк m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] intMatrix = CreateMatrixRndInt(m, n, 1, 10);
PrintMatrix(intMatrix);
SwapRows(intMatrix);
Console.WriteLine();
PrintMatrix(intMatrix);