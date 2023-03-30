// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите натуральное число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N, болшее М");
int n = Convert.ToInt32(Console.ReadLine());

if (ValidateEntry(m, n))
{
    int sum = SumNumbers(m, n);
    Console.WriteLine($"Сумма натуральных чисел в промежутке от {m} до {n} равна {sum}");
}
else
    Console.WriteLine("Необходимо ввести натуральные числа и N должно быть больше M");

int SumNumbers(int m, int n)
{    
    if (m == n)
        return m;

    return m + SumNumbers(m + 1, n);
}

bool ValidateEntry(int m, int n)
{
    if (m > 0 && n > m)
        return true;
    else
        return false;
}
