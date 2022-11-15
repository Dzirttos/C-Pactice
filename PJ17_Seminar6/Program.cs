using Class;
//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

// Console.Clear();
// Console.Write("Введите элементы массива через пробел: ");
// string elements = Console.ReadLine();
// int[] baseArray = GetArrayFromString(elements);

// Console.WriteLine(String.Join(" ", ResultArray(baseArray)));

// int[] GetArrayFromString(string stringArray)
// {
//     string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
//     int[] res = new int[nums.Length];

//     for (int i = 0; i < nums.Length; i++)
//     {
//         res[i] = int.Parse(nums[i]);
//     }
//     return res;
// }

// int[] ResultArray(int[] array)
// {
//     int size = array.Length / 2;
//     if (array.Length % 2 == 1) size++;
//     int[] result = new int[size];
//     for (int i = 0; i < array.Length / 2; i++)
//     {

//         result[i] = array[i] * array[array.Length - 1 - i];
//     }
//     if (array.Length % 2 == 1) result[size-1] = array[array.Length / 2];
//     return result;
// }

// //Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
// Console.Clear();

// int[] array = GetArray(10, 0, 10);
// Console.WriteLine(String.Join(" ", array));

// int[] reversArray = ReversArray2(array);
// Console.WriteLine(String.Join(" ", reversArray));

// ReversArray1(array);
// Console.WriteLine(String.Join(" ", array));


// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }
// void ReversArray1(int[] inArray)
// {
//     for (int i = 0; i < inArray.Length / 2; i++)
//     {
//         int k = inArray[i];
//         inArray[i] = inArray[inArray.Length - i - 1];
//         inArray[inArray.Length - i - 1] = k;
//     }
// }

// int[] ReversArray2(int[] inArray)
// {
//     int[] result = new int[inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length - 1 - i];

//     }
//     return result;
// }

// Console.Clear();
// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }
// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(5, 1, 11);
// ShowArray(myArray);

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// Console.Clear();

// int[] array = func.CreateRandomArray(3, 1, 10);
// func.ShowArray(array);

// if (array[1] < array[0] + array[2] && array[2] < array[0] + array[1] && array[0] < array[1] + array[2])
//     {
//     Console.ForegroundColor = ConsoleColor.Cyan;
//     Console.WriteLine($"Triangle with sides {array[0]}, {array[1]} and {array[2]} exists.");
//     }
// else
//     {
//     Console.ForegroundColor = ConsoleColor.Red;
//     Console.WriteLine($"Triangle with sides {array[0]}, {array[1]} and {array[2]} can not exist.");
//     }


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
// Console.Clear();
// string TenToBin (int num)
// {
//     string result = String.Empty;
//     string temp = String.Empty;
//     while (num > 0)
//     {
//         temp = Convert.ToString(num % 2);
//         result = temp + result;
//         num /= 2;
//     }
//     return result;
// }
// Console.WriteLine("Please enter number:");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(TenToBin(num));


// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
// Console.Clear();
// Console.WriteLine("Please enter number:");
// int size = Convert.ToInt32(Console.ReadLine());

// int [] array = new int [size];

// for (int i = 1; i < 2; i++)
// {
//     array[i] = i;
//     }

// for (int i = 2; i < size; i++)
// {
//     array[i] = array [i-1] + array[i-2];
// }
// func.ShowArray(array);
// Console.WriteLine($"Первые {size} чисел Фибоначчи: [ {String.Join(", ", array)} ]");


// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
// Console.Clear();
// Console.WriteLine("Please enter number:");
// int size = Convert.ToInt32(Console.ReadLine());
// int [] array = func.CreateRandomArray(size, -100, 100);
// int [] reversarray = new int [size];

// for (int i = 0; i < size; i++)
// {
//     reversarray[i] = array[i];
// }
// Console.WriteLine($"First array: [ {String.Join(", ", array)} ]");
// Console.WriteLine($"Copied array: [ {String.Join(", ", reversarray)} ]");

// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
Console.Clear();
Console.WriteLine("Please enter elements of array via space (press spaebar):");
string elements = Console.ReadLine();
int [] array = GetArrayFromString(elements);

Console.WriteLine(String.Join(" ", ResultArray(array)));

int [] GetArrayFromString (string stringArray)
{
    string [] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int [] res = new int [nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = Convert.ToInt32(nums[i]);
    }
    return res;
}

int [] ResultArray (int [] array)
{
    int size = array.Length/2;
    if (array.Length%2 ==1) size ++;
    int [] result = new int [size];
    for (int i = 0; i < array.Length/2; i++)
    {
        result [i] = array[i] * array[array.Length - 1 - i];

    }
    if (array.Length%2 ==1) result [size-1] = array[array.Length/2];
    return result;
}





// Console.Clear();
// double b1 = Convert.ToDouble(Console.ReadLine());
// double k1 = Convert.ToDouble(Console.ReadLine());
// double b2 = Convert.ToDouble(Console.ReadLine());
// double k2 = Convert.ToDouble(Console.ReadLine());

// double x = Convert.ToDouble((b2-b1)/(k1-k2));
// double y = Convert.ToDouble(k1*x+b1);

// Console.WriteLine($"({x},{y})");

