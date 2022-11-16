using Class;

// ЛАБОРАТОРНЫЕ ЗАНЯТИЯ
// Работа 1.4. Работа с двумерными массивами

// Пример 1. Формирование и вывод двумерного массива заданных чисел. 

// Console.Clear();
// int[,] array = { { 11, 12, 13, 14, 15 }, { 21, 22, 23, 24, 25 } }; // формируем прямоугольный массив чисел из двух строк
// foreach (int x in array)    // с поомщью foreach все елементы выводятся в одну строку
// {
//     Console.Write ("{0,4}",x);
// }
// Console.WriteLine();

//  // далее выводим числа построчно в виде таблицы
//  for (int i = 0; i < 2; i++)
//  {
//     for (int j = 0; j < 5; j++)
//     {
//         Console.Write ("{0,4}", array[i,j]);   // j-я строка
//     }
//     Console.WriteLine(); // переход на следующую строку
//  }


// Пример 2. Формирование и вывод таблицы чисел.

// Console.Clear();
// Console.WriteLine("Введите количество строк (n < 9): ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов (m < 9): ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[n, m]; // объявили массив из n строк и m столбцов
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         array[i, j] = 10*i + j; // i-я строка
//     }
// }

// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//     {
//         Console.Write("{0,4}", array[i, j]);
//     }
//     Console.WriteLine();
// }

// Пример 3. Формирование и вывод ступенчатого массива.

// Console.Clear();
// // Построчно объявляем и заполняем массив из 3-х одномерных массивов
// int[][] jag = new int[3][]
// {   new int [] {3,7,9,5,12},
//     new int [] {2,4},
//     new int [] {1,3,5}};
// foreach (int[] arr in jag)
// {
//     foreach (int a in arr)
//     {
//         Console.Write("{0,4}", a);
//     }
//     Console.WriteLine();
// }

// Задача 1. Задан прямоугольный массив названий, в которых выполняются заданные действия:
// (a - автомобиль, v - велосипед, m - мотоцикл, p - поезд, s - самолёт)
// По введенному обозначению обозначению выводится его название
// Console.Clear();
// string[,] transportnames = { { "a", "v", "m", "p", "s" }, { "автомобиль", "велосипед", "мотоцикл", "поезд", "самолёт" } };
// for (int i = 0; i < 2; i++)
// {
//     for (int k = 0; k < 5; k++)
//     {
//         Console.Write($"{transportnames[i, k]} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine();
// Console.WriteLine("Enter a, v, m, p, or s: ");
// string letter = Console.ReadLine();
// for (int i = 0; i < 1; i++)
// {
//     for (int j = 0; j < 5; j++)
//     {
//         if (transportnames[i, j] == letter) Console.Write(transportnames[i+1, j]);
//         else
//         {
//             Console.ForegroundColor = ConsoleColor.DarkRed;
//             Console.WriteLine("Wrong letter entered");
//             break;
//         }
//     }

// }

// Задача 2. ФОрмируется и выводится прямоугольный массив (5 строк и 6 столбцов) целых случайных чисел от -40 до 40.
// Вычисляется и выводится: а) сумма числе в каждой строке б) среднее врифметическое чисел в каждой строке
Console.Clear();
// array.GetLenght(0) - длина первой строки двумерного массива\
int[,] doublearray = new int[5, 6];
int sum = 0;
int avg = 0;
for (int i = 0; i < doublearray.GetLength(0); i++) 
{
    for (int j = 0; j < doublearray.GetLength(1); j++)
    {
        doublearray[i, j] = new Random().Next(-40, 41);
        Console.Write("{0,4}", doublearray[i,j]);
        sum += doublearray[i, j];
        avg = sum / doublearray.GetLength(1);
    }
    Console.WriteLine();
    Console.Write($" Сумма всех элементов строки равна {sum}. ");
    Console.Write($" Ср.арефметическое всех элементов строки равно {avg}. ");
    Console.WriteLine();
}
