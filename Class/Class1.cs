namespace Class;
public class func
{
   // создает целочисленный массив длинной size с числами от start до end
    public static int[] CreateRandomArray(int N, int start, int end)
    {

    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
    }

// выводит массив на экран через пробел
    public static void ShowArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

}
