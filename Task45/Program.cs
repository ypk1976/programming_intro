// Задача 45. Напишите программу, которая будет копировать заданный массив 
// с помощью поэлементного копирования.
int[] array = FillArray(5, 0, 10);
PrintArray(array);
int[] newArray = CopyArray(array);
PrintArray(newArray);

int[] FillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++) arr[i] = rand.Next(min, max + 1);
    return arr;
}

int[] CopyArray(int[] arr)
{
    int[] new_arr = new int[arr.Length];
    Console.Write(" -> ");
    for (int i = 0; i < arr.Length; i++) new_arr[i] = arr[i];
    return new_arr;
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