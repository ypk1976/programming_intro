// Задача 40. Напишите программу, которая принимает на вход 3 числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.

Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckTriangle(number1, number2, number3) ? "Yes" : "No");

bool CheckTriangle(int num1, int num2, int num3)
{
    if (num1 < (num2 + num3) && num2 < (num1 + num3) && num3 < (num1 + num2)) return true;
    else return false;
}
