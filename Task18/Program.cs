// Напишите программу, которая по номеру введенной четверти
// показывает диапозон возможных координат Х и Y в этой четверти
Console.WriteLine("Введите номер четверти в системе координат");
int quarter = Convert.ToInt32(Console.ReadLine());

string checkQuarter = CheckQuarter(quarter);
string Result = quarter < 5 && quarter > 0
                        ? $"В указанной четверти {checkQuarter}"
                        : "Введен неверный номер четверти";
Console.WriteLine(Result);

string CheckQuarter(int getQuarter)
{
    string errorMessage = "Введен неверный номер четверти!";
    if (getQuarter == 1) return "X > 0, Y > 0";
    if (getQuarter == 2) return "X < 0, Y > 0";
    if (getQuarter == 3) return "X < 0, Y < 0";
    if (getQuarter == 4) return "X > 0, Y < 0";
    return errorMessage;
}