﻿// 1. Генерируется случайное число n в интервале [20 - 99]. 
// Проверяется делится ли оно на  введенное с клавиатуры целое число d (используйте тернарный оператор)
// Console.Clear();

// Console.Write("Enter number: ");
// int d = Convert.ToInt32(Console.ReadLine());

// int n = new Random().Next(20, 100);
// int eq = n % d;
// Console.WriteLine(n);
// Console.WriteLine(d);
// Console.WriteLine(eq == 0 ? "Делится" : "не делится");

// 2. Генерируется два случайных числа a и b и интервале [10 - 30]. Если a>b, выводится их разность, если a<b, то выводится сумма, 
// если a==b выводится собщение "числа равны".

// Console.Clear();

// int a = new Random().Next(10, 31);
// int b = new Random().Next(10, 31);

// if (a > b)
// {
//     Console.WriteLine($"{a} минуc {b} = {a - b}");
// }
// else if (a == b)
// {
//     Console.WriteLine($"{a} равно {b}");
// }
// else
//     Console.WriteLine($"{a} плюс {b} = {a + b}");

// 3. Генерируется два случайных числа c и d в интервале [- 20 - 99]. 
// Если оба чётные, выводится их частное, если оба нечётные - сумма, ели одно четное, одно нет, вывводится их произведение.

// Console.Clear();

// double c = new Random().Next(-10, 100);
// double d = new Random().Next(-10, 100);

// if (c%2==0 && d%2==0)
// {
//     Console.WriteLine($"{c} деленное на {d} = {c/d}");
// }
// else if (c%2!=0 && d%2!=0)
// {
//     Console.WriteLine($"{c} плюс {d} = {c+d}");
// }
// else
// {
//     Console.WriteLine($"{c} умножить на {d} = {c*d}");
// }


//4. По введенному номеру месяца выводит название поры года (зима, весна, лето, осень) и сообщение "сессия, каникулы, 1 семестр, 2 семестр"
// Console.Clear();

// string mes;
// Console.WriteLine("Введите номер месяца: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12:");
// string month = Console.ReadLine();

// switch (month)
// {
//     case "1": mes = "Зима. Сессия"; break;
//     case "2": mes = "Зима. 2 Семестр"; break;
//     case "3": mes = "Весна. 2 Семестр"; break;
//     case "4": mes = "Весна. 2 Семестр"; break;
//     case "5": mes = "Весна. 2 Семестр"; break;
//     case "6": mes = "Лето. Сессия"; break;
//     case "7": mes = "Лето. Каникулы"; break;
//     case "8": mes = "Лето. Каникулы"; break;
//     case "9": mes = "Осень. 1 Семестр"; break;
//     case "10": mes = "Осень. 1 Семестр"; break;
//     case "11": mes = "Осень. 1 Семестр"; break;
//     case "12": mes = "Зима. 1 Семестр"; break;
//     default: mes = "Номер месяца введен некорректно"; break;
// }
// Console.WriteLine(mes);

//5. Проверяется соответствие веса и роста (ввод рост и вес; вывод сообщения "Норма", "Нужно похудеть", "Нужно поправиться").
// Нормальный вес (в кг) = (рос (в см) - 100) +/-10%

// Console.Clear();
// Console.WriteLine("Введите свой вес в кг: ");
// int w = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите свой рост в см: ");
// int h = Convert.ToInt32(Console.ReadLine());

// if (w>=(h-100)*0.9 && w<=(h-100)*1.1)
// {
//     Console.WriteLine("Норма");
// }
// else if (w<=(h-100)*0.9)
// {
//     Console.WriteLine("Нужно поправиться");
// }
// else

//  Console.WriteLine("Нужно похудеть");

//6. Введенная цифра (от 0 до 5) выводится прописью (оператор switch)
// Console.Clear();

// string mes;
// Console.WriteLine("Введите число от 0 до 5: ");
// string number = Console.ReadLine();
// int number = Convert.ToInt32(Console.ReadLine()); // для альтернативного способа

// switch (number)
// {
//     case "0" : mes = "Zero"; break; 
//     case "1" : mes = "One"; break;
//     case "2" : mes = "Two"; break;
//     case "3" : mes = "Three"; break;
//     case "4" : mes = "Four"; break;
//     case "5" : mes = "Five"; break;
//     default: mes = "Некорректное число"; break;
// }
// Console.WriteLine(mes);
// Console.ReadKey();

// Альтернативный способ
// switch (number)
// {
//     case 0: 
//     Console.WriteLine("Zero");
//     break;
//     case 1: 
//     Console.WriteLine("One");
//     break;
//     case 2: 
//     Console.WriteLine("Two");
//     break;
//     case 3: 
//     Console.WriteLine("Three");
//     break;
//     case 4: 
//     Console.WriteLine("Four");
//     break;
//     case 5: 
//     Console.WriteLine("Five");
//     break;
//     default:
//     Console.WriteLine("Введено некорректное число. Число должно быть от 0 до 5");
//     break;
// }

//7. Выводится название предмета по введенной первой букве: ф - физика, м - математика, и - история, г - география, б - биология

// Console.Clear();
// string mes;
// Console.WriteLine("Введите первую букву изучаемого предмета");
// string letter = Console.ReadLine();

// switch (letter)
// {
//     case "ф" : mes = "физика"; break;
//     case "г" : mes = "география"; break;
//     case "и" : mes = "история"; break;
//     case "м" : mes = "математика"; break;
//     case "б" : mes = "биология"; break;
//     default: mes = "Таких предметов в этой школе не изучают!"; break;
// }
// Console.WriteLine(mes);


//7. Выводится название предмета по введенной первой букве: ф - физика, м - математика, и - история, г - география, б - биология

Console.Clear();