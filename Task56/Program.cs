// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

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
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }

}
int RowElementsSum(int[,] matrix, int rowIndex)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        sum += matrix[rowIndex, i];
    }
    return sum;
}
int FindMinRow(int[,] matrix)
{
    int minRowIndex = 0;
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        if (RowElementsSum(matrix, i) < RowElementsSum(matrix, minRowIndex)) minRowIndex = i;
    }
    return minRowIndex;
}

Console.WriteLine("Введите количество строк m:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов n:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] intMatrix = CreateMatrixRndInt(m, n, 1, 10);
PrintMatrix(intMatrix);
Console.WriteLine($"Индекс строки с наименьшей суммой элементов => {FindMinRow(intMatrix)}");