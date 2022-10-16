// Напишите программу, которая принимает на вход число и выдаёт, является ли оно чётным (делится ли оно на два без остатка)
Console.Clear();

Console.Write("Пожалуйста, введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0)
{
    Console.Write("Введенное число чётное!");
}
else
{
    Console.Write("Введенное число ни разу не чётное"); 
}