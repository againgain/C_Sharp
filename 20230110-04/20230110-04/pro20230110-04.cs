using System;

class Sieve
{
    //private bool[] primeFlags;  //素数判定フラグの配列(trueなら素数)
    protected bool[] primeFlags;  //素数判定フラグの配列(trueなら素数)


    //コンストラクタ
    public Sieve(int max)
    {
        primeFlags = new bool[max + 1];

        for(int i=0; i<=max; i++)
        {
            primeFlags[i] = true;
        }

        //テスト
        //Console.WriteLine("true入れ完了");

    }

    //古いのアルゴリズムを用いて、素数判定を行うメソッド
    public void DoSieve()
    {
        primeFlags[1] = false;

        //Lengthまでとは、やるな！
        for(int i=2; i < primeFlags.Length; i++)
        {
            //本当は上限の平方根まで調べれば良いらし。
            if (primeFlags[i])
            {
                for(int j = i*2;j<primeFlags.Length; j+= i) //!? jをiずつ増やす！？
                {
                    primeFlags[j] = false;  //素数の倍数を除外
                }
            }
        }
        //テスト
        //Console.WriteLine("倍数除外完了");
    }

    public void ShowPrimes()
    {
        var count = 0;
        for(int i=1; i < primeFlags.Length;i++)
        {
            if (primeFlags[i])
            {
                count++;
                Console.Write($"{i},");
            }
        }
        Console.WriteLine($" 以上{count}個です。");
    }
}

class TwinPrime : Sieve
{
    public TwinPrime(int max) : base(max)
    {

    }

    public void ShowTwinPrimes()
    {
        var count = 0;
        for(var i=1; i<primeFlags.Length-2; i++)
        {
            if (primeFlags[i] && primeFlags[i + 2])
            {
                count++;
                Console.Write($"({i}, {i + 2}), ");
            }
        }
        Console.WriteLine($" 以上{count}組です。");
    }
}

class SieveMain
{
    public static void Main()
    {
        Console.Write("入力した数以下の素数を列挙します。> ");
        var max = int.Parse(Console.ReadLine());
        var sieve = new Sieve(max);
        sieve.DoSieve();
        sieve.ShowPrimes();

        //双子そすう
        Console.Write("入力した数以下の双子素数を列挙します。> ");
        var max2 = int.Parse(Console.ReadLine());
        var sieve2 = new TwinPrime(max2);
        sieve2.DoSieve();
        sieve2.ShowTwinPrimes();
    }
}
