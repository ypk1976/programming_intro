// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
Console.WriteLine("Введите число для проверки:");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = FillArray(7, 0, 10);
Console.Write(CheckExistance(number, array) ? "Да" : "Нет");

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

bool CheckExistance(int num, int[] arr)
{
    for (int i = 0; i < arr.Length; i++) if (arr[i] == num) return true;
    return false;
}