// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] array = new int[8]; // 0 1 2 3 4 5 6 7

FillArray();
GetArray(array);

void FillArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
}

void GetArray(int[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
    }
}