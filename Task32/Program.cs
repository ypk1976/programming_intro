// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = FillArray(4, -9, 9);
ConvertDigits(array);
PrintArray(array);

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

void ConvertDigits(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) arr[i] = -arr[i];
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < (arr.Length - 1)) Console.Write($"{arr[i]}, ");
        else
        {
            Console.Write($"{arr[i]}]");
            Console.WriteLine();
        }
    }
}