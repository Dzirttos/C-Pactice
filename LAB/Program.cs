// 1. Генерируется случайное число n в интервале [20 - 99]. 
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


//8. Выводится название страны и её столицы по первой введенной букве: 
// б - Беларусь, Минск, р - Россия, Москва, л -Литва, Вильнюс (switch)

// Console.Clear();
// string mes;
// Console.WriteLine("Введите первую букву страны");
// string letter = Console.ReadLine();

// switch (letter)
// {
//     case "б" : mes = "Беларусь, Минск"; break;
//     case "р" : mes = "Россия, Москва"; break;
//     case "л" : mes = "Литва, Вильнюс"; break;
//     default: mes = "Некорректный ввод!"; break;
// }
// Console.WriteLine(mes);

//9. по введенному номеру выводится название дня недели и сообщение "рабочий день" или выходной"
// Console.Clear();
// string mes;
// Console.WriteLine("Введите порядковый номер дня недели");
// string letter = Console.ReadLine();
// int L = Convert.ToInt32(letter);

// switch (letter)
// {
//     case "1": mes = "Понедельник"; break;
//     case "2": mes = "Вторинк"; break;
//     case "3": mes = "Среда"; break;
//     case "4": mes = "Четверг"; break;
//     case "5": mes = "Пятница"; break;
//     case "6": mes = "Суббота"; break;
//     case "7": mes = "Воскресенье"; break;
//     default: mes = "Некорректный ввод"; break;
// }
// Console.WriteLine(mes);
// if (L < 6)
// {
//     Console.WriteLine("Рабочий день");
// }
// else
// {
//     Console.WriteLine("Выходной");
// }

//10. Проверяет правильность введенного логина строго из 5 букв и пароля из 6  и более цифр
// Console.Clear();
// Console.WriteLine("Введите логин:");
// string log = Console.ReadLine();
// int l = log.Length;
// if (l < 5)
// {
//     Console.WriteLine("Логин слишком короткий!");
// }
// else if (l > 5)
// {
//     Console.WriteLine("Логин слишком длинный!");
// }
// else 
//    { Console.WriteLine("Введите пароль состоящий из цифр:");
//     string pass = Console.ReadLine();
//     int p = pass.Length;
//     if (p < 6)
//     {
//     Console.WriteLine("Пароль слишком короткий!");
//     }
//     else 
//     {
//     Console.WriteLine("Пароль и логин приняты!");
//     }
//    }

// Алгоритмическая конструкция цикл
//1. Вычисляется сумма всех нечетных натуральных чисел от n1 до n2 (n1 n2 вводятся с клавиатуры, цикл for)
// Console.Clear();
// Console.WriteLine("Введите первое число:");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int n2 = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// if (n1<n2)
// {


//     for (int n=n1; n<n2; n++)
//     {
//         if (n%2 != 0)
//         {
//             sum += n;    
//         }

//     }
// }
// else if (n2<n1)
// {


//     for (int n=n2; n<n1; n++)
//     {
//         if (n%2 != 0)
//         {
//             sum += n;    
//         }

//     }
// }
// else
// {
// Console.WriteLine("Введно некорректное число");
// }
// Console.WriteLine($"Сумма всех нечетных натуральных чисел равна {sum}");

//2. Вычисляется сумма квадратов n натуральных чисел, начиная с k (n и k вводятся на клавиатуре, цикл for)
// Console.Clear();
// Console.WriteLine("Введите начальное число:");
// int k = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество чисел:");
// int n = Convert.ToInt32(Console.ReadLine());
// int pro = 0;
// int p = k + n - 1;
// for (int i = k; i <= p; i++)
// {
//     pro += i*i;
// }
// Console.WriteLine($"Сумма квадратов всех натуральных чисел начиная с {k} равна {pro}");

//3. Вычисляется и выводится в таблицус шагом 10 км стоимость поездки на атомобиле в зависимости от расстояния S (10 - 90 км). С клавиатуры вводятся:
// b - расход бензина на 100 км, p - цена бензина за 1 л. (цикл for)
// Console.Clear();
// Console.WriteLine("Введите расход бензина:");
// double b = Convert.ToInt64(Console.ReadLine());
// Console.WriteLine("Введите цену бензина за 1 л:");
// double p = Convert.ToInt64(Console.ReadLine());
// double sum = 0;

// Console.WriteLine("Километраж:      Стоимость поездки: ");

// for (double S = 10; S < 91; S += 10)
// {
//     sum += (S/100*b*p);
//     Console.WriteLine($"   {S}                {sum} ");
// }

//4. В интервале [0,2] с шагом 0,1 вычисляются координаты y = V0*t-g*t*t/2 и скорости мячика V = V0 - g*t, брошенного вверх с начальной скоростью V0.
// (V0 вводится с клавиатуры, цикл for)
// Console.Clear();
// Console.WriteLine("Введите начальную скорость мячика: ");
// double V0 = Convert.ToDouble(Console.ReadLine());
// double V = 0;
// double t = 0;
// double g = 9.81;

// Console.WriteLine("Координаты:      Скорость мячика: ");

// for (double y =0 ; y <=2 ; t += 0.1)
// {
//     y = y + (V0*t - g*t*t/2);
//     V = V0 - g*t;
//     Console.WriteLine($"{Math.Round(y, 2)}         {Math.Abs(V),2} ");  
// }

//5. Повторяются вычисления и вывод площади круга по вводимому радиусу r до тех пор, пока не будет введена буква z или Z (A = pi*r*r)
Console.Clear();
double n = 0;
double A = 0;
double pi = 3.14;
string r;

while (true)
{
    Console.WriteLine("Введите значение радиуса: ");
    r = Console.ReadLine();
    if (r == "z" || r == "Z") break;
    // if (double.TryParse(r,out n))
    n = Convert.ToDouble(r);
    {
    A = n * n * pi;    
    Console.WriteLine($"Площадь круга равна: {A} ");
    }
}
