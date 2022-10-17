// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.Clear();

Console.WriteLine("Введите число и помолитесь");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
Console.WriteLine("Ура! Молитва услышана - число делится на 7 и 23!");
else
Console.WriteLine("Увы. Молитесь лучше");
