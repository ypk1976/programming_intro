// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int[] array = FillArray(9, 0, 10);
int[] new_array = MultiplyElements(array);
PrintArray(new_array);


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

int[] MultiplyElements(int[] arr)
{
    int size = 0;
    if (arr.Length % 2 == 0) size = arr.Length / 2;
    else size = (arr.Length / 2) + 1;
    int[] new_arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        if (i < ((arr.Length - 1) - i)) new_arr[i] = arr[i] * arr[(arr.Length - 1) - i];
        else new_arr[i] = arr[i];
    }
    return new_arr;
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
