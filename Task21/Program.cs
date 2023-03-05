// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите значение X1");
int coordX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значени Y1");
int coordY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значени Z1");
int coordZ1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение X2");
int coordX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значени Y2");
int coordY2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значени Z2");
int coordZ2 = Convert.ToInt32(Console.ReadLine());

double ourDistance = Distance(coordX1, coordY1, coordZ1, coordX2, coordY2, coordZ2);
Console.WriteLine(ourDistance);

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2) );
    double result = Math.Round(distance, 2, MidpointRounding.ToZero);
    return result;
}