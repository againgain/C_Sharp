using System;

/*
class aaa
{
    public static void Main()
    {
        int[] a = new int[5];

        a[0] = 26;
        a[1] = 170;
        a[2] = a[0] + a[1];

        int n = 3;
        a[n] = n;
        n++;
        a[n] = a[0] * 3;

        for(int i=0; i<5; i++)
        {
            Console.WriteLine("a[{0}] = {1}", i, a[i]);
        }
    }


}
*/

class Array06
{
    public static void Main()
    {
        int[] a = { 26, 170, 309, 310, 371 };
        int[] b = { 1, 2, 3, 4, 5 };
        int[] c = new int[5];

        for (int i = 0; i < a.Length; i++)
        {
            c[i] = a[i] * b[i];
            Console.WriteLine("c[{0}] = {1}", i, c[i]);
        }
    }
}