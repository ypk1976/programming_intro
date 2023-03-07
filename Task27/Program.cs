// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.WriteLine("Введите число, неравное 0");
int number = Convert.ToInt32(Console.ReadLine());

if (number != 0)
{
    if (number < 0) number = -number;
    Console.WriteLine($"Сумма цифр в числе {number} = {SumDigits(number)}");
}
else
{
    Console.WriteLine("Необходимо ввести число, неравное 0");
}

int SumDigits(int num)
{
    int result = 0;
    int temp_num = 0;
    while (num != 0)
    {
        temp_num = num % 10;
        result = result + temp_num;
        num = num / 10;
    }
    return result;
}