// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.WriteLine("Введите натуральное число M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N");
int n = Convert.ToInt32(Console.ReadLine());

if (ValidateEntry(m, n))
{
    int result = Ackermann(m, n);
    Console.WriteLine($"Результат функции Аккермана для m={m} и n={n} равен {result}");
}
else
    Console.WriteLine("Необходимо ввести натуральные числа, т.е. больше 0");


static int Ackermann(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0)
        return Ackermann(m - 1, 1);
    else
        return Ackermann(m - 1, Ackermann(m, n - 1));
}

bool ValidateEntry(int m, int n)
{
    if (m > 0 && n > 0)
        return true;
    else
        return false;
}
