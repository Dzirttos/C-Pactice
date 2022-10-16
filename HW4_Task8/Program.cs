// Напишите программу, которая принимает на вход число (N), а на выходе выдает все четные числа от 1 до N
Console.Clear();

Console.Write("Пожалуйста, введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;

if (number <= 1)
{
    Console.Write("Ошибка! Невозможно построить интервал от 1: введено некорректное число");
}

while (count <= number)
{
    if (count%2 == 0)
    {
       Console.Write(count + "  "); 
       count +=2;
    }
}