// Задача 62. Напишите программу,
// которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }

}
void GoRight(int[,] matrix, int x, int y, int count)
{
    int i = y;
    while (i < matrix.GetLength(1) - x)
    {
        matrix[x, i] = count;
        count++;
        i++;
    }
    if (count <= matrix.Length) GoDown(matrix, x + 1, i - 1, count);
}
void GoDown(int[,] matrix, int x, int y, int count)
{
    int i = x;
    while (i <= matrix.GetLength(0) - (matrix.GetLength(1) - y))
    {
        matrix[i, y] = count;
        count++;
        i++;
    }
    if (count<=matrix.Length) GoLeft(matrix, i - 1, y - 1, count);
}
void GoLeft(int[,] matrix, int x, int y, int count)
{
    int i = y;
    while (i >= matrix.GetLength(0) - x - 1)
    {
        matrix[x, i] = count;
        count++;
        i--;
    }
    if (count <= matrix.Length) GoUp(matrix, x - 1, i + 1, count);
}
void GoUp(int[,] matrix, int x, int y, int count)
{
    int i = x;
    while (i > y)
    {
        matrix[i, y] = count;
        count++;
        i--;
    }
    if (count <= matrix.Length) GoRight(matrix, i + 1, y + 1, count);
}

int[,] intMatrix = new int[4, 4]; //методы работают для любых размерностей
GoRight(intMatrix, 0, 0, 1);
PrintMatrix(intMatrix);
