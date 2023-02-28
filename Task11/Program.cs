// Сгенерировать случайное трехзначное число и вывести первую и последнюю цифры в виде двузначного числа

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число от 100 до 990: {number}");
int number1 = number / 100;
int number2 = number % 10;
// Console.WriteLine($"Первое число: {number1}, второе число: {number2}");
// int result = number1 * 10 + number2;
// Console.WriteLine($"Результат: {result}");

int show13 = Show13(number);
Console.WriteLine($"Большая цифра: {show13}");

int Show13(int num)
{
    int number1 = number / 100;
    int number2 = number % 10;
    int result = number1 * 10 + number2;
    return result;
}
