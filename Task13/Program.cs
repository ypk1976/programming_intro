﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckValidity(number))
{
    Console.WriteLine($"Третья цифра цисла {number}: {GetThirdDigit(number)}");
}

bool CheckValidity(int num)
{
    if (num < 100)
    {
        Console.WriteLine($"В числе {num} нет 3-й цифры");
        return false;
    }
    return true;
}

int GetThirdDigit(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    int result = num % 10;
    return result;
}