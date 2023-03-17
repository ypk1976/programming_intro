// Напишите программу, которая будет преобразовывать обычное число в двоичное
// 3 -> 11
// 45 - 101101
Console.WriteLine("Введите число для конвертации");
int number1 = Convert.ToInt32(Console.ReadLine());
string binNum = DecimalToBinary(number1);
        Console.WriteLine("{0} => {1}", number1, binNum);

string DecimalToBinary(int num)
{
    string binaryNumber = string.Empty;
    while (num > 0)
    {
        binaryNumber = (num % 2) + binaryNumber;
        num /= 2;
    }

    return binaryNumber;
}