using System;

class Prime
{
    public bool IsPrime(int n)
    {


        bool divFlag = false;
        bool isPrime = false;

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
            //Console.WriteLine("素数");
            isPrime = true;

        }
        else
        {
            //Console.WriteLine("素数ではない。");
            isPrime = false;
        }


        return isPrime;

    }
}

class PrimeMain
{
    public static void Main()
    {
        Prime ip = new Prime();
        for(int i = 2; i<= 100; i++)
        {
            //if(ip.IsPrime(i) == true)
            if (ip.IsPrime(i))
           {
                Console.WriteLine("{0}",i);
            }

        }
    }
}
