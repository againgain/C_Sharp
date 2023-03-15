using System;

class Sosu
{
    public static void Main()
    {
        //素数判定用ここから
        /*
        Console.Write("整数を入力してください。：");
        int n = int.Parse(Console.ReadLine());
        */
        //素数判定用ここまで

        //ここからバージョン1
        /*
        for(int i = 2; i < n; i++)
        {
            if(n%i == 0)
            {
                Console.WriteLine("素数ではない。");
                break;
            }
            else if(i == n - 1)
            {
                Console.WriteLine("素数である。");
            }
        }
        */
        //ここまでバージョン1


        //ここからバージョン2
        /*
        bool divFlag = false;

        for(int i=2; i < n; i++)
        {
            if (n % i == 0)
            {
                divFlag = true;
                break;
            }
        }
        if (divFlag == false)
        {
            Console.WriteLine("素数");
        }
        else
        {
            Console.WriteLine("素数ではない。");
        }

        */
        //ここまでバージョン2

        //ここから素数の列挙
        

        for(int n=2; n < 100; n++)
        {
            bool divFlag = false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    divFlag = true;
                    break;
                    
                }
            }

            if (!divFlag)
            {
                Console.WriteLine("{0}", n);
            }
        }
        
        
        //ここまで素数の列挙
        Console.WriteLine("テスト終了");
    }
}
