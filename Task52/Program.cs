// Задача 52. Задайте двумерный массив
// из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double AverageOfColumn(int[,] matrix, int columnIndex)
{
    double average = 0;
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum += matrix[i, columnIndex];
    }
    average = sum / matrix.GetLength(0);
    return Math.Round(average, 1);
}

Console.WriteLine("Введите количество строк m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] intMatrix = CreateMatrixRndInt(m, n, 1, 10);
PrintMatrix(intMatrix);

Console.Write("Среднее арифметическое каждого столбца: ");
for (int index = 0; index < intMatrix.GetLength(1); index++)
{
    double result = AverageOfColumn(intMatrix, index);
    Console.Write(index != intMatrix.GetLength(1) - 1 ? $"{result}; " : $"{result}.");    
}


