﻿// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
int[] MultPairsOfNum(int[] arr)
{
    int sizeArr2 = 0;
    if (arr.Length % 2 == 0) sizeArr2 = arr.Length / 2;
    else sizeArr2 = arr.Length / 2 + 1;
    int[] resArr = new int[sizeArr2];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        resArr[i] = arr[i] * arr[arr.Length - i - 1];
    }
    if (arr.Length % 2 != 0) resArr[sizeArr2 - 1] = arr[arr.Length / 2];
    return resArr;
}
int[] array = CreateArrayRndInt(6, -15, 15);
PrintArray(array);
int[] resultArray = MultPairsOfNum(array);
PrintArray(resultArray);