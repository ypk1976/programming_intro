// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.WriteLine("Введите число M");
int number1 = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(number1);
PrintArray(array);
Console.Write($" -> {CountNumbers(array)}");

int[] CreateArray(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите {i + 1}-е число:");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int CountNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++) if (arr[i] > 0) count++;
    return count;
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