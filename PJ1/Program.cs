// asdasd

Console.Clear();

Console.Write("Enter the number: ");

int number = Convert.ToInt32(Console.ReadLine());


int sqr = number * number;
// или number *= number;
// или int sqr1 Convert.ToInt32(Math.Pow(number, 2));

Console.WriteLine("The new number: " + sqr); 
