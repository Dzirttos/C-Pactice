// 17. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();
int GetQuarterFromCoordinate(int userX, int userY)
{
    int quarter = 0;
    if (userX > 0 && userY > 0)
    {
        quarter = 1;
    }
    else if (userX < 0 && userY > 0)
    {
        quarter = 2;
    }
    else if (userX < 0 && userY < 0)
    {
        quarter = 3;
    }
    else if (userX > 0 && userY < 0)
    {
        quarter = 4;
    }
    return quarter;
}

Console.WriteLine("Введите координату Х");
int userX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int userY = Convert.ToInt32(Console.ReadLine());


int quarter = GetQuarterFromCoordinate(userX, userY);
if (quarter != 0)
{
    Console.WriteLine($"Точка с координатами: [{userX} : {userY}] находится в {quarter} четверти.");
}
else
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine($"Точка с координатами: [{userX} : {userY}] находится на оси.");
    Console.ResetColor();
}



