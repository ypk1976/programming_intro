﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] array = FillArray(123, 0, 999);
Console.Write(CheckMatch(array,10,100));

int[] FillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(min, max + 1);
        if (i < (size - 1)) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}] -> ");
    }
    return arr;
}

int CheckMatch(int[] arr, int min, int max)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++) if (arr[i] >= min && arr[i] < max) count++;
    return count;
}