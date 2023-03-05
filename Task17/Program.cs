// Напишите программу, которая принимает на вход координаты точки X и Y, неравные 0. 
// Необходимо указать номер четверти, в которой находится точка
Console.WriteLine("Введите значение X");
int coordX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значени Y");
int coordY = Convert.ToInt32(Console.ReadLine());
string errorMessage = "Введенное значение равно 0";

//Method 1
int chooseQuarter = ChooseQuarter(coordX,coordY);
string Result = chooseQuarter > 0 
                        ? $"Введенная координата находится в четверти {chooseQuarter}"
                        : "Введена неверная координата";
Console.WriteLine(Result);
int ChooseQuarter(int x1, int y1)
{
    if (x1 > 0 && y1 > 0) return 1;
    if (x1 > 0 && y1 < 0) return 2;
    if (x1 < 0 && y1 < 0) return 3;
    if (x1 < 0 && y1 > 0) return 4;
    return 0;

}

//Method 2
CheckValidity(coordX, coordY);
bool CheckValidity(int numX, int numY)
{
    if (numX != 0 && numY != 0)
    {
        ProcessParameters(numX, numY);
        return true;
    }
    else
    {
        Console.WriteLine(errorMessage);
        return false;
    }
}

int ProcessParameters(int x, int y)
{
    int result = 0;
    if (x > 0)
    {
        if (y > 0)
        {
            result = 1;
        }
        else
        {
            result = 4;
        }
    }
    else
    {
        if (y > 0)
        {
            result = 2;
        }
        else
        {
            result = 3;
        }
    }
    Console.WriteLine(result);
    return result;
}