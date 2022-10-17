// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.Clear();

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2*number2)
Console.Write("Первое число - это квадрат второго");
else if (number2 == number1*number1)
Console.Write("Второе число - это квадрат первого");
else
Console.Write("Ни первое, ни второе число не явяляются квадраиами друг друга");