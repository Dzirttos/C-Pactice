﻿// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.Clear();

void Square(int N)
{
    int result = 0;
    int i = 1;
    while (i <= N)
    {
        if (i < N)
        {
            Console.Write($"{Math.Pow(i, 2)}, ");
        }
        if (i == N)
        {
            Console.Write($"{Math.Pow(i, 2)}.");
        }
        i++;
    }
}

Console.WriteLine("Введите чиcло");
int number = Convert.ToInt32(Console.ReadLine());

Square(number);
