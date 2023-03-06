// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.WriteLine("Введите натуральное число A");
int number = Convert.ToInt32(Console.ReadLine());


Console.WriteLine($"Сумма чисел от {number} - {SumOfNumbers(number)}");

int SumOfNumbers(int num)
{
    int result = 0;
    for (int i = 1; i <= num; i++)
    {
        result = result + i;
    }
    return result;
}
