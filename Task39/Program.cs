// Задача 39. Напишите программу, которая перевернет одномерный массив, т.е. первые элменты станут последними.
// [3, 6, 8, 1] -> [1, 8, 6, 3]

int[] array = FillArray(5, 0, 10);
PrintArray(array);
PrintArray(FlipArray(array));
Array.Reverse(array);
PrintArray(array);

int[] FillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++) arr[i] = rand.Next(min, max + 1);
    return arr;
}

int[] FlipArray(int[] arr) {
    int[] flipped_arr = new int[arr.Length];
    Console.Write(" -> ");
    for (int i = 0; i < arr.Length; i++) flipped_arr[i]=arr[(arr.Length - 1)-i];
    return flipped_arr;
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