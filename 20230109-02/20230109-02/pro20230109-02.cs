using System;

//素数判定

class Sieve
{
    //public int imax;
    //private bool[] check;
    //private int[] prime;

    /*
    public Sieve()
    {
        imax = 0;
    }
    */

    public void Sosu(int max)
    {
        

        bool[] check = new bool[max + 1];

        for (int i = 2; i <= max; i++)
        {
            check[i] = true;
        }

        check[0] = false;
        check[1] = false;

        //ここから倍数を素数ではない判定のループ
        for (int i = 2; i <= max; i++)
        {
            if (check[i] == false)
            {
                //素数でない
            }
            else
            {
                //素数である可能性がある。
                //倍数にfalseを入れていく。
                for (int j = 2; j <= max; j++)
                {
                    //配列の添え字の最大数から、倍数がはみ出さないか判定。
                    if (i * j <= max)
                    {
                        //倍数は素数じゃない。
                        check[i * j] = false;
                    }
                    else
                    {
                        //倍数が素数ではないチェックから抜ける。
                        break;
                    }


                }
            }
        }

        Console.WriteLine("素数を書き出します。");

        for (int i = 0; i <= max; i++)
        {
            if (check[i])
            {
                Console.Write("{0}, ", i);
            }
        }
        Console.WriteLine();
    }

    

    
}




class SieveMain
{
    public static void Main()
    {
        Console.Write("整数を入力してください。：");
        int max = int.Parse(Console.ReadLine());

        var a = new Sieve();

        a.Sosu(max);

        
    }
}