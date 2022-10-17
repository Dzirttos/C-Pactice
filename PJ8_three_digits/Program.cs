// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
Console.Clear();

int number = new Random().Next(100,1000);
Console.WriteLine(number);

Console.WriteLine($"{number/100}{number%10}");
