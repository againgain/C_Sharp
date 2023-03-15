using System;

class Ronri
{
    public static void Main()
    {
        double a, b, c, p, q, r;

        Console.WriteLine("パラメータを入力してください。");
        Console.WriteLine(" a = ");
        a = double.Parse(Console.ReadLine());
        Console.WriteLine(" b = ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine(" c = ");
        c = double.Parse(Console.ReadLine());

        p = 3 * a - b;
        q = a * a + 3 * c;
        r = 2 * (b - c) / a;

        Console.WriteLine("p = {0}, q = {1}, r = {2}", p, q, r);
    }
}