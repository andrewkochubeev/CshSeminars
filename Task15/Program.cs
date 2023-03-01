// Напишите программу, которая
// принимает на вход цифру, обозначающую
// день недели, и проверяет, является
// ли этот день выходным.
Console.WriteLine("Введите номер дня недели:");
int numDay = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Weekend(numDay));

string Weekend(int day)
{
    if (day > 0 && day < 8) return day > 5 ? "Да" : "Нет";
    else return "Ошибка ввода!";
}