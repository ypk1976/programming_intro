// Напишите программу, которая принимает на ввод число N
// и выводит талицу квадратов значений от 1 до N
Console.WriteLine("Введите число N");
int number = Convert.ToInt32(Console.ReadLine());

CheckValidity(number);

bool CheckValidity(int num)
{
    if (num > 0)
    {
        GetSquare(number);
        return true;
    }
    else
    {
        Console.WriteLine("Необходимо ввести число больше 0");
        return false;
    }
}

void GetSquare(int num)
{
    double result = 0;
    for (int i = 1; i <= num; i++)
    {
        result = Math.Pow(i, 2);
        Console.WriteLine($"{i,4} -> {result,4}");

    }
}