// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB > 0)
{
    int powerOfB = PowerOfB(numberA, numberB);
    Console.WriteLine($"{numberA} в степени {numberB} = {powerOfB}");
}
else
{
    Console.WriteLine("Необходимо ввести число больше 0");
}

int PowerOfB(int num1, int num2)
{
    int result = num1;
    for (int i = 1; i < num2; i++)
    {
        checked
        {
            result = result * num1;
        }        
    }
    return result;
}
