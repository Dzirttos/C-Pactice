// Console.Clear();
// char letter = Convert.ToChar(Console.ReadLine());

// switch (letter)
// {
//     case 'а':
//     Console.WriteLine("гласная");
//     break;
//     case 'у':
//     Console.WriteLine("гласная");
//     break;
//     case 'е':
//     Console.WriteLine("гласная");
//     break;
//     case 'ы':
//     Console.WriteLine("гласная");
//     break;
//     case 'о':
//     Console.WriteLine("гласная");
//     break;
//     case 'э':
//     Console.WriteLine("гласная");
//     break;
//     case 'я':
//     Console.WriteLine("гласная");
//     break;
//     case 'и':
//     Console.WriteLine("гласная");
//     break;
//     case 'ю':
//     Console.WriteLine("гласная");
//     break;
//     case 'ё':
//     Console.WriteLine("гласная");
//     break;
//     default:
//     break;
// }

// Console.Clear();
// int dayNumber = Convert.ToInt32(Console.ReadLine());
// int day = dayNumber%7;
// switch (day)
// {
//     case 1:
//     Console.WriteLine("Понедельник");
//     break;
//     case 2: 
//     Console.WriteLine("Вторник");
//     break;
//     case 3: 
//     Console.WriteLine("Среда");
//     break;
//     case 4: 
//     Console.WriteLine("Четверг");
//     break;    
//     case 5: 
//     Console.WriteLine("Пятница");
//     break;
//     case 6: 
//     Console.WriteLine("Суббота");
//     break;
//     case 0: 
//     Console.WriteLine("Воскресенье");
//     break; 
//     default:
//     break;
// }

// Console.Clear();

// Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
// int operation = Convert.ToInt32(Console.ReadLine());

// switch (operation)
// {
//     case 1:
//     Console.WriteLine("Сложение");
//     break;
//     case 2:
//     Console.WriteLine("Вычитание");
//     break;
//     case 3:
//     Console.WriteLine("Умножение");
//     break;
//     default: 
//     Console.WriteLine("Неизвестная операция!");
//     break;
// }

// Console.Clear();

// Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
//     string line = Console.ReadLine();
//     string[] splitString = line.Split(' ');

//     int operation = Convert.ToInt32(splitString[0]);
//     double a = Convert.ToDouble(splitString[1]);
//     double b = Convert.ToDouble(splitString[2]);
//     double result = 0;

// switch (operation)
// {
//     case 1:
//     result = a + b;
//     Console.WriteLine($"Результат операции {result}");
//     break;
//     case 2:
//     result = a - b;
//     Console.WriteLine($"Результат операции {result}");
//     break;
//     case 3:
//     result = a * b;
//     Console.WriteLine($"Результат операции {result}");
//     break;
//     default: 
//     Console.WriteLine("Неизвестная операция!");
//     break;
// }


// Console.Clear();
//    int num = Int32.Parse(Console.ReadLine()); // Запрашиваем ввод из консоли и вытягиваем из него число

//    string answer = num % 2 == 0 ? "EVEN" : "ODD";

//    Console.WriteLine(answer);

//И вновь дядя Вася берется за измерения, но на этот раз он решил измерить свой дачный участок своей старой рулеткой 5м, пытаясь найти площадь. Участок имеет форму прямоугольника.
// Напишите программу, которая вычисляет площадь участка.
// Напоминаем, что у рулетки отломаны первые 20 см и дядя Вася об этом не знает (он напишет 1.2 м, хотя в реальности измерил 1 м). А так как длина рулетки меньше стороны участка, то дядя Вася каждый раз, когда заканчивается длина рулетки, ставит зарубку на ограде и, переставляя рулетку, продолжает измерения от зарубки.

// Console.Clear();
// Console.WriteLine("Введите два числа через пробел: длина и ширина участка");
// string line = Console.ReadLine();
// string[] splitString = line.Split(' ');

// double length = Convert.ToDouble(splitString[0]); // длина
// double width = Convert.ToDouble(splitString[1]); // ширина
// double landArea = 0;                             // переменная для площади

// //Тут будет Ваш код
// double lengthCheck = length%5;
// double widthCheck = width%5;
// switch (lengthCheck)
// {
//     case 0: 
//     length = length - length/5*0.2;
//     break;
//     default:
//     length = length - (length-lengthCheck)/5*0.2 - 0.2;
//     break;
// }
// switch (widthCheck)
// {
//     case 0: 
//     width = width - width/5*0.2;
//     break;
//     default:
//     width = width - (width - widthCheck)/5*0.2 - 0.2;
//     break;
// }
// landArea = length * width;

// Console.WriteLine($"Площадь участка: {Math.Round(landArea,2)}"); 


// Console.Clear();
// int num = int.Parse(Console.ReadLine());

// for (int i = 0; i < num; i++)
// {
// //     Console.WriteLine("Hello, NoobCoder's!");
// }

// В консоль пользователем вводится целое положительно число. Используя цикл while, напишите программу, которая выводит на экран через пробел числа от нуля до введенного пользователем числа включительно.
// Console.Clear();
// int num = int.Parse(Console.ReadLine());
// int i = 0;

// while (i<=num)
// {
//     Console.Write($"{i} ");
//     i++;
// }

//Немного доработаем предыдущую программу. Теперь пользователь вводит целое положительное число, но от вас требуется вывести на экран все числа от нуля столбиком, чтобы при этом сумма всех чисел в столбце была строго меньше введенного пользователем числа.
// Console.Clear();
// int num = int.Parse(Console.ReadLine());
// int i = 0;
// int sum = 0;
// while (num > sum)
// {
//     Console.WriteLine($"{i}");
//     i++;
//     sum += i;
// }


// Факториалом натурального числа n называют произведение всех натуральных чисел от 1 до n включительно. Напишите программу для вычисления факториала введенного пользователем числа.
// Console.Clear();
// int num = int.Parse(Console.ReadLine());
// int i = 1;
// int n = 1;
// while (i <= num)
// {
//     n *= i;
//     i++;
// }
// Console.WriteLine($"{n}");

// Напишите программу, которая считает сумму всех простых чисел в определенном диапазоне. Простое число - целое положительное число, имеющее ровно два различных натуральных делителя - единицу и самого себя. Число 1 не является ни простым, ни составным числом, так как у него только один делитель - 1.
// Console.Clear();

// int startValue = int.Parse(Console.ReadLine());
// int endValue = int.Parse(Console.ReadLine());
// int sum = 0;

// if (startValue < 0)
// startValue = 2;
// for (int i=startValue; i<endValue; i++) 
//         for ( int j=2; j<i; j++)
//         {
//             if (i % j != 0) 
//                 sum += startValue;
//             Console.WriteLine($"{i}");
//         }

// Console.WriteLine($"Сумма простых чисел = {sum}");

// int S = int.Parse(Console.ReadLine());
// int N = int.Parse(Console.ReadLine());

// int sum = 0;
// // bool result = true;
// L1: 
// for (int j = S; j < N; j++)
// {
//     for (int i = 2; i < j; i++)
//     {
//         if (j % i == 0) continue;
//     }
//     Console.WriteLine($"{j}");
//     sum += j;

// }
// Console.WriteLine($"{sum}");


// Это творческое задание. Необходимо написать программу, которая рисует в консоли ёлочку из звездочек, высота ёлочки вводится пользователем в консоль. 
// Обратите внимание, что первый символ в основании ёлочки это первый символ данной строки, а ее вершина находится на первой строке. Для выполнения этого задания достаточно тех знаний, которые вы уже приобрели в рамках этого курса, но если у вас возникнут трудности, то не стесняйтесь искать идеи в интернете. Основной навык программиста - это умение находить информацию. 
// Console.Clear();

// Console.WriteLine("Введите высоту ёлочки:");
// int height = int.Parse(Console.ReadLine());
// Console.Write("\n");
// int h = height;
// int s
// for (int i = 0; i < h*2; i++)
// {
//       for (int k = 0; k < i; k++)
//       {
//         Console.Write(" ");
//         for (int j = 0; j <= k; j++)
//         {
//             Console.Write("*");
//         }
//       }
//     Console.Write("\n");
// }

// В консоль вводятся два числа. В обоих числах есть одна общая цифра. 
// Выведите в консоль цифру, которая есть в обоих числах через пробел столько раз, сколько раз она встречается в первом числе.
// Console.Clear();
// int firstNumber = int.Parse(Console.ReadLine());
// int secondNumber = int.Parse(Console.ReadLine());

// int o1 = 0;
// int o2 = 0;

// while (secondNumber > 0)
// {
//     o2 = secondNumber % 10;

//     while (firstNumber > 0)
//     {
//         o1 = firstNumber % 10;
//         Console.WriteLine(o1);
//         if (o1 == o2)
//         {
//             Console.Write($"{o1} ");
//         }
//         firstNumber = firstNumber / 10;
//     }
//     secondNumber = secondNumber / 10;
// }

// while (firstNumber > 0)
// {
    
//     o1 = firstNumber % 10;
//     while (secondNumber > 0)
//     {
//         o2 = secondNumber % 10;
//         if (o2 == o1)
//         {
//             Console.Write($"{o2} ");
//         }
//         firstNumber = firstNumber / 10;
//         secondNumber = secondNumber / 10;
//     }
//     firstNumber = firstNumber / 10;
// }


// Проверка правильности записи массивов
// var array7 = {'a', 'b', 'c', 'd', 'e'};
// string array5[ ] = new string[ ]{"Вики", "Кристина", "Барселона"};
// double[ ] array4 = {1.5, 2.5, 4.5, 3.5};
// int[ ] array3 = new int[3]{1, 2, 3};
// char[ ] array2 = { abcdefg };
// var array1 = new[ ]{1, 2, 3, 4, 5};


// Напишите программу, которая берет введенный пользователем текст и отображает его вертикально.
// Console.Clear();
// string line = Console.ReadLine();
// char [] array = line.ToCharArray();
// foreach (char i in array) Console.WriteLine(i);

// Дано два целых числа одинаковой длины. Учитывая, что метод Console.ReadLine( ) всегда возвращает строку, а строка - это массив символов, напишите программу, 
// которая должна пройти по всем элементам этих чисел и сравнить их. Первый элемент первого числа сравнивается с первым элементом второго, и т.д. 
// В консоль должен быть выведен ответ :
// "Совпадение n элементов", где n - количество совпавших элементов.
// Пример:
// 13456 
// 23550
// У этих чисел одинаковые 2ой и 4ый элемент, следовательно ответ:
// "Совпадение 2 элементов"

Console.Clear();
string num1 = Console.ReadLine();
string num2 = Console.ReadLine();

int count = 0;
for (int i = 0; i < num1.Length; i++)
{
    if (num1[i] == num2[i])
    count ++;
}
Console.WriteLine($"Совпадение {count} элементов");

