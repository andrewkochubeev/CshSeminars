// Напишите программу, которая
// принимает на вход пятизначное
// число и проверяет, является ли
// оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000 || number < -9999 && number > -100000)
{
    Console.WriteLine(IsPalindrome(number) ? "Да" : "Нет");
}
else Console.WriteLine("Число не пятизначное");

int DigitOfNumber(int num, int numDigit)
{

    for (int i = 0; i < 5 - numDigit; i++)
    {
        num = num / 10;
    }
    return num % 10;

}

bool IsPalindrome(int num)
{
    return DigitOfNumber(num, 1) == DigitOfNumber(num, 5) && DigitOfNumber(num, 2) == DigitOfNumber(num, 4);
}