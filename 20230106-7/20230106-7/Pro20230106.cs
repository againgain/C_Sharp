using System;

class oooo
{
    public static void Main()
    {
        int tmp = 0;
        Console.WriteLine("最大公約数を求めます。\n数を２つ入力してください。");
        Console.Write("1つ目> ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("２つ目> ");
        int n = int.Parse(Console.ReadLine());

        


        while (n>0)
        {
            Console.WriteLine("{0}, {1}",m,n);
            if (n > m)
            {
                (m, n) = (n, m);
            }


            /*
            if (n == 0)
            {
                
                break;
            }
            */

            tmp = m % n;
            m = n;
            n = tmp;

            //Console.WriteLine("2：{0}, {1}", m, n);
        }
        Console.WriteLine("最大公約数は {0} です。", m);

    }
}
