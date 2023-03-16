// Задача 50. Напишите программу, которая
// на вход принимает позиции элемента в двумерном
// массиве, и возвращает значение этого элемента или же
// указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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
bool IsPositionExist(int[,] matrix, int i, int j)
{
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1)) return true;
    else
    {
        Console.WriteLine("Такого элемента в массиве нет!");
        return false;
    }
}
void PrintValueOnPosition(int[,] matrix, int i, int j)
{
    Console.WriteLine($"Значение на позиции ({i}, {j}) = {matrix[i,j]}");
}

int[,] intMatrix = CreateMatrixRndInt(4, 6, 1, 50);
PrintMatrix(intMatrix);

Console.WriteLine("Введите номер строки i:");
int iNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер столбца j:");
int jNum = Convert.ToInt32(Console.ReadLine());

if (IsPositionExist(intMatrix, iNum, jNum)) PrintValueOnPosition(intMatrix, iNum, jNum);