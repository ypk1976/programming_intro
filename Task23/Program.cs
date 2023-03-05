// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

ProcessNumber(number);

bool ProcessNumber(int num)
{
    if (num > 0)
    {
        GetCube(number);
        return true;
    }
    else
    {
        Console.WriteLine("Необходимо ввести число больше 0");
        return false;
    }
}

void GetCube(int num)
{
    double result = 0;
    for (int i = 1; i <= num; i++)
    {
        result = Math.Pow(i, 3);
        Console.WriteLine($"{i,4} -> {result,4}");

    }
}