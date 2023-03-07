﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
int[] array = new int[8];

FillArray(array);
GetArray(array);

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(0, 100);
        if (i < (arr.Length - 1))
        {
            Console.Write($"{arr[i]}, ");
        }
        else
        {
            Console.Write($"{arr[i]} -> [");
        }
    }
}

void GetArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < (arr.Length - 1))
        {
            Console.Write($"{arr[i]}, ");
        }
        else
        {
            Console.Write($"{arr[i]}]");
        }
    }
}