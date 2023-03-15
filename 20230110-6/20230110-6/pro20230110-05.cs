using System;

class BubbleSort
{
    public static void Sort(int[] a)
    {
        for(int i = 0; i < a.Length - 1; i++)
        {
            for (int j = a.Length-1; j > i; j--)
            {
                if (a[j] < a[j - 1])
                {
                    (a[j], a[j - 1]) = (a[j - 1], a[j]);
                }
            }
        }
        
    }
    /*
    public BubbleSort Sort()
    {
        return BubbleSort;
    }
    */
}

class SortMain
{

    public static void Main()
    {
        var data = new int[20];
        var rand = new Random();

        Console.WriteLine("ソート前");
        for(int i=0;i < data.Length; i++)
        {
            data[i] = rand.Next(100);
            Console.Write($"{data[i]} ");
        }
        Console.WriteLine();

        BubbleSort.Sort(data);

        Console.WriteLine("ソート後");
        for(int i = 0; i<data.Length; i++)
        {
            Console.Write($"{data[i]} ");
        }
        Console.WriteLine();

    }
}
