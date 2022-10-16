// Напишите программу, которая будут выдавать название дня недели по заданному номеру
Console.Clear(); 

Console.Write("Введите порядковый номер дня недели: ");

int day = Convert.ToInt32(Console.ReadLine()); 

if (day == 1)
{
    Console.WriteLine("Введенное число соответствует понедельнику");
}
else 
{
    if (day == 2)
    {
        Console.WriteLine("Введенное число соответствует вторнику");
    }
    else
    {
        if (day == 3)
        {
            Console.WriteLine("Введенное число соответствует среде");
        }
        else 
        {
            if (day == 4)
            {
                Console.WriteLine("Введенное число соответствует четвергу");
            }
            else
            {
                if (day == 5)
                {
                    Console.WriteLine("Введенное число соответствует пятнице");
                }
                else
                {
                    if (day == 6)
                    {
                        Console.WriteLine("Введенное число соответствует субботе");
                    }
                    else
                    {
                        if (day == 7)
                        {
                            Console.WriteLine("Введенное число соответствует воскресенью");
                        }
                        else
                        {
                            Console.WriteLine("Введено некорректное число. Число должно быть от 1 до 7");
                        }
                    }
                }
            }
        }
    }
}