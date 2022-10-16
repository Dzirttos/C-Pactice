// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от - N до N 
Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int negativenumber = -number;

if (number == 0)
{
    Console.WriteLine("Введён 0, интервал отсутствует");
}
if (number > 0)
{
    
    while (negativenumber <= number)
    {
    Console.Write(negativenumber + " ");
    negativenumber++;
    }
}
else
{
       while (negativenumber >= number)
    {
    Console.Write(number + " ");
    number++;
    } 
}