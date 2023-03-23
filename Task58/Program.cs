// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
bool CheckMatrices(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0)) return true;
    else
    {
        Console.WriteLine("Данные матрицы умножать нельзя!");
        return false;
    }
}
int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{

    int[,] resultMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }


    return resultMatrix;
}

int m1 = Prompt("Введите количество строк 1-й матрицы: ");
int n1 = Prompt("Введите количество столбцов 1-й матрицы: ");
int[,] intMatrix1 = CreateMatrixRndInt(m1, n1, 0, 10);
PrintMatrix(intMatrix1);

int m2 = Prompt("Введите количество строк 2-й матрицы: ");
int n2 = Prompt("Введите количество столбцов 2-й матрицы: ");
int[,] intMatrix2 = CreateMatrixRndInt(m2, n2, 0, 10);
PrintMatrix(intMatrix2);
Console.WriteLine();

if (CheckMatrices(intMatrix1, intMatrix2))
{
    int[,] intMatrix3 = MultiplyMatrices(intMatrix1, intMatrix2);
    PrintMatrix(intMatrix3);
} 