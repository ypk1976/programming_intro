// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Введите натуральное число N");
int n = Convert.ToInt32(Console.ReadLine());

if (ValidateEntry(n))
    PrintNumbers(n);
else
    Console.WriteLine("Вы ввели неверное число");

static void PrintNumbers(int n)
{
    if (n == 0)
    {
        return;
    }

    Console.WriteLine(n + "");

    PrintNumbers(n - 1);
}

bool ValidateEntry(int n)
{
    if (n > 0)
        return true;
    else
        return false;
}