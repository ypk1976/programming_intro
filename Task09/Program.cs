// Написать программу, которая выводит случайное число от 10 до 99 и показывает наибольшую цифру в нем

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число от 10 до 99: {number}");
int number1 = number / 10;
int number2 = number % 10;
// 1 вариант
if (number1 > number2)
{
    Console.WriteLine($"Большая цифра: {number1}");
}
else
{
    Console.WriteLine($"Большая цифра: {number2}");
}

//2 вариант
int result = number1 > number2 ? number1 : number2;
Console.WriteLine($"Большая цифра: {result}");

//3 вариант
int maxDigit = MaxDigit(number);
Console.WriteLine($"Большая цифра: {maxDigit}");

int MaxDigit(int num)
{
    int number1 = num / 10;
    int number2 = num % 10;
    int result = number1 > number2 ? number1 : number2;
    return result;
}
