using System;

class Quadra
{
    public static void Main()
    {
        int a = 0, b = 0, c = 0, x1 = 0, x2 = 0;
        Console.WriteLine("2次方程式 ax^2 + bX + c = 0　の数値解を求めます。");

        Console.Write("aを入力してください。: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("bを入力してください。: ");
        b = int.Parse(Console.ReadLine());

        Console.Write("cを入力してください。: ");
        c = int.Parse(Console.ReadLine());

        if(b*b-4*a*c == 0)
        {
            Console.WriteLine("解は１つ存在し、x = {0,10:F3} です。", -b/(2.0*a));
        }
        else if(b*b-4*a*c > 0)
        {
            Console.WriteLine("解は２つ存在し、x = {0,10:F3} , {1,10:F3} です。", (-b+Math.Sqrt(b*b-4.0*a*c))/(2.0*a) , (-b - Math.Sqrt(b * b - 4.0 * a * c)) / (2.0 * a));
        }
        else
        {
            Console.WriteLine("実数解はありません。");
        }

        /*
        Console.WriteLine("\n");
        Console.WriteLine("b^2-4ac の値は {0}", b * b - 4 * a * c);
        Console.WriteLine("root(b^2-4ac) の値は {0}", Math.Sqrt(b * b - 4 * a * c));
        Console.WriteLine("root(b^2-4.0ac) の値は {0}", Math.Sqrt(b * b - 4.0 * a * c));
        Console.WriteLine("-b+root(b^2-4.0ac) の値は {0}", -b + Math.Sqrt(b * b - 4.0 * a * c));
        Console.WriteLine("-b-root(b^2-4.0ac) の値は {0}", -b - Math.Sqrt(b * b - 4.0 * a * c));
        */

    }

}
