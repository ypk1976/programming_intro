﻿// Задача 44. Не используя рекурсию выведете первые N
// чисел Фибоначчи. Первые 2 числа: 0 и 1.
// Если N=5 -> 0, 1, 1, 2, 3
// Если N=3 -> 0, 1, 1
// Если N=7 -> 0, 1, 1, 2, 3, 5, 8
Console.WriteLine("Введите число N");
int number1 = Convert.ToInt32(Console.ReadLine());

PrintArray(Fibonacci(number1));

int[] Fibonacci(int num)
{
    int[] arr = new int[num];
    arr[0] = 0;
    arr[1] = 1;
    for (int i = 2; i < num; i++) arr[i] = arr[i - 1] + arr[i - 2];
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < (arr.Length - 1)) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}