// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
//int rest = number1 % number2;

int showDivider = ShowDivider( number1, number2 );

if (showDivider == 0)
{
    Console.WriteLine($"{number1} является кратным числу {number2}!");
}
else
{

    Console.WriteLine($"{number1} не является кратным {number2}, остаток {showDivider}");
}



int ShowDivider(int num1, int num2)
{
    int ostatok = num1 % num2;
    return ostatok;

}
