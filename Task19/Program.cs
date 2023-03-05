// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите натуральное пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

bool checkPalindrome = CheckPalindrome(number);
Console.WriteLine(checkPalindrome ? "Да" : "Нет");

bool CheckPalindrome(int num)
{
    if (num > 9999 && num < 100000)
    {
        return num == Swap(num);
    }
    else
    {
        Console.WriteLine("Введенное значение не является натуральным пятизначным числом");
        return false;
    }
}

int Swap(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result * 10 + num % 10;
        num /= 10;
    }
    Console.WriteLine($"Перевернутое число = {result}");
    return result;

}