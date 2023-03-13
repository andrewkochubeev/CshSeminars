// Задача 41: Пользователь вводит с
// клавиатуры M чисел. Посчитайте, сколько
// чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] EnterArray(int size)
{
    int[] arr = new int[size];
    Console.WriteLine("Вводите числа");
    for (int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}
int CountPosArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите число М:");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = EnterArray(m);
Console.WriteLine($"Количество положительных чисел = {CountPosArray(array)}");