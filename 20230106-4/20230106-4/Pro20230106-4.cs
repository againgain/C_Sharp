using System;

class KazuAte
{
    public static void Main()
    {
        Random rand = new Random();
        int x = rand.Next(100);
        int i = 0;

        Console.WriteLine("チャンスは10回まで");
        Console.WriteLine("1~100の数字のうちどれかを当ててみてください。");

        for (i = 1; i <= 10; i++)
        {
            Console.Write("予想する数は：");
            int n = int.Parse(Console.ReadLine());

            if( n == x)
            {
                Console.WriteLine("正解");
                break;
            }
            else if(n > x)
            {
                Console.WriteLine("もっと小さい数");
            }
            else if( n < x)
            {
                Console.WriteLine("もっと大きい数");
            }

        }

        //Console.WriteLine(i);

        if( i > 10)
        {
            Console.WriteLine("正解は：{0}",x);
        }

    }

}
