// Напишите программу, которая принимает на вход координаты двух точек
// и расчитывает расстояние между ними в 2D
// Корень: Math.Sqrt(5);
//Округление до 2 знаков:
// double d = 5.09296445;
// double dRound = Math.Round(d,2);
// Console.WriteLine(dRound);
Console.WriteLine("Введите значение X1");
int coordX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значени Y1");
int coordY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение X2");
int coordX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значени Y2");
int coordY2 = Convert.ToInt32(Console.ReadLine());

double ourDistance = Distance(coordX1, coordY1, coordX2, coordY2);
Console.WriteLine(ourDistance);

double Distance(int x1, int y1, int x2, int y2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    double result = Math.Round(distance, 2, MidpointRounding.ToZero);
    return result;
}