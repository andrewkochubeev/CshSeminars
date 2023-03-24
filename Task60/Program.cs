// Задача 60. Сформируйте трёхмерный массив
// из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя
// индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int Prompt(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
int[] FillArrayUniqRnd(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    array[0] = rnd.Next(10, 100);
    for (int i = 1; i < size; i++)
    {

        for (int j = 0; j < i; j++) //проходим по заполненным значениям
        {
            bool uniqueValue = false;
            while (!uniqueValue)
            {
                if (array[j] == array[i] || array[i] == 0)
                {
                    array[i] = rnd.Next(10, 100);
                    j = 0;                          //обнуляем счетчик, чтобы снова начать проверку с начала массива
                }
                else uniqueValue = true;
            }
        }
    }
    return array;
}
void Fill3dArrayFrom1d(int[] array, int[,,] array3d)
{
    int index = 0;
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                array3d[i, j, k] = array[index];
                index++;
            }
        }
    }
}
void Print3dArray(int[,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i++)
    {
        for (int j = 0; j < array3d.GetLength(1); j++)
        {
            for (int k = 0; k < array3d.GetLength(2); k++)
            {
                Console.Write($"{array3d[i,j,k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}

int l = Prompt("Введите длину массива: ");
int h = Prompt("Введите высоту массива: ");
int d = Prompt("Введите глубину массива: ");

int[,,] arr3d = new int[l, h, d];
if (arr3d.Length <= (99 - 10)) 
{
    int[] arr = FillArrayUniqRnd(arr3d.Length);
    Fill3dArrayFrom1d(arr, arr3d);
    Print3dArray(arr3d);
}
else Console.WriteLine("Не хватает двузначных чисел для заполнения массива");