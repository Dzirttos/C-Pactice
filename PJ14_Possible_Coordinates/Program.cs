// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
Console.Clear();

void PossibleCoordinates(int quarter)
{
    if (quarter == 1)
    {
        Console.WriteLine("X и Y могут быть от 0 и до плюс бесконечности");
    }

    else if (quarter == 2)
    {
        Console.WriteLine("X может быть от 0 и до минус бесконичености, Y может быть от 0 и до плюс бесконечности");
    }
    else if (quarter == 3)
    {
        Console.WriteLine("X и Y могут быть от 0 и до минус бесконечности");  
    }
    else if (quarter == 4)
    {
       Console.WriteLine("X может быть от 0 и до плюс бесконичености, Y может быть от 0 и до минус бесконечности");
    }
    else
    {
        Console.WriteLine("Некорректная четверть");
    }
}

Console.WriteLine("Введите номер четверти:");
int number = Convert.ToInt32(Console.ReadLine());

PossibleCoordinates(number);
