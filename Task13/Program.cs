//  Напишите программу, которая
//  выводит третью цифру заданного
//  числа или сообщает, что третьей 
//  цифры нет
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

ThirdDigit(number);

void ThirdDigit(int num)
{
    if (num > 99)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        int result = num % 10;
        Console.WriteLine(result);
    }
    else Console.WriteLine("Нет третьей цифры");
}