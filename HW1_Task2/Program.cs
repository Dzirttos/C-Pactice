// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
Console.Clear();

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.Write("Наибольшим числом является " + number1 + ", а наименьшим является " + number2 + ".");
}
else
{
    Console.Write("Наибольшим числом является " + number2 + ", а наименьшим является " + number1 + ".");
}
