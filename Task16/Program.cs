// Напишите программу, которая принимает на вход два числа и определяет, является ли одно число квадратом второго
// 5, 25 -> да
// 34, 2 -> нет
// -4, 16 -> да
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

bool isSquare = IsSquare(number1,number2);
Console.WriteLine(isSquare ? "Да" : "Нет");

bool IsSquare(int num1, int num2)
{
    return num1 == num2 * num2 || num2 == num1 * num1;
}
