using System;

class Sum
{
    public int Add(int a, int b)
    {
        int r = a + b;
        return r;
    }

    public int SumUpTo(int n)
    {
        int sum = n * (n + 1) / 2;
            /*
        Console.WriteLine("nの値は{0}",n);
        Console.WriteLine("mの値は{0}", m);
        Console.WriteLine("n*(n+1)は {0}", n*(n+1));
            */
        return sum;
    }
}



class aaaa
{
    
    public static void Main()
    {
        Sum s = new Sum();
        int n = s.Add(12, 3);
        Console.WriteLine("12+3 = {0}", n);

        /*
        SumUpTo ss = new SumUpTo();
        int u = ss.SumUpTo(1);
        Console.WriteLine("合計値 = {0}", u);
        */
        Console.Write("いくつまでの合計を出しますか?：");
        int n1=int.Parse(Console.ReadLine());

        Sum ss = new Sum();
        int n2 = ss.SumUpTo(n1);
        //Console.WriteLine("n1は：{0}", n1);
        Console.WriteLine("合計値は：{0}", n2);

    }
}
