// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

Console.WriteLine($"Количество цифр в числе {number} = {CountDigits(number)}");

int CountDigits(int num)
{
    while (num != 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

