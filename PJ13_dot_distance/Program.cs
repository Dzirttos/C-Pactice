// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// d = √(xb - xa)2 + (yb - ya)2
Console.Clear();

double Distance(int x1, int y1, int x2, int y2)
{
    double dst = 0;
    dst = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
    return dst;
}

Console.WriteLine("Введите координату Х1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Х2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y2");
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Distance(x1, y1, x2, y2), 3);
Console.WriteLine($"{result}");
