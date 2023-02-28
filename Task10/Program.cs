// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckValidity(number))
{
    Console.Write($"Вторая цифра числа {number}: {GetSecondDigit(number)}");
}

bool CheckValidity(int num)
{
    if (number < 100 || number > 999)
    {
        Console.Write("Введено не трехзначное число!");
        return false;
    }
    return true;
}

int GetSecondDigit(int num)
{
    int result = (num / 10) % 10;
    return result;
}