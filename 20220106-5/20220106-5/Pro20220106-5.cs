using System;

class Nezumi
{
    public static void Main()
    {
        Console.Write("ねずみ算の計算をします。\n整数を入力してください。> ");
        int x = int.Parse(Console.ReadLine());
        int sum = 2;
        int month = 0;

        do
        {
            sum *= 7;
            month += 1;
        } while (sum <= x);

        Console.WriteLine("ネズミの数が{0}を超えるのは{1}か月目、{2}匹です。",x,month,sum);

    }
}
