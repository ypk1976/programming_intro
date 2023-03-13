// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
//[345, 897, 568, 234] -> 2
int[] array = FillArray(10, 100, 999);
Console.Write(CountEven(array));

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

int CountEven(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++) if (arr[i] % 2 == 0) count++;
    return count;
}