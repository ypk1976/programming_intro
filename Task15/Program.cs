// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите число, обозначающее день недели");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckValidity(number))
{
    CheckHoliday(number);
}

bool CheckHoliday(int num)
{
    if (num < 6)
    {
        Console.WriteLine("Нет");
        return false;
    }
    Console.WriteLine("Да");
    return true;
}

bool CheckValidity(int num)
{
    if (num < 1 || num > 7)
    {
        Console.WriteLine("Введенное число не является днем недели");
        return false;
    }
    return true;
}