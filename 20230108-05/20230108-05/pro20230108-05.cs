using System;

/*
class Complex
{
    public double real;
    public double imag;

    public Complex()
    {
        real = 0.0;
        imag = 0.0;
    }
}

class ComplexMain
{
public static void Main()
    {
        var a = new Complex();
        Console.WriteLine("a = {0}+{1}i", a.real, a.imag);
    }
}
*/

class Methods
{
    int x = 0;

    public void Show()  //引数なし
    {
        Console.WriteLine("private field x: {0}", x);
    }

    public int Show(int a)    //引数　int １つ、戻り値 int
    {
        Console.WriteLine("argment a; {0}", a);
        return a;
    }

    public int Show(int a, int b)
    {
        Console.WriteLine("argment a: {0}, b: {1}", a, b);
        return a + b;
    }

    public double Show(double d)    //引数 double １つ、戻り値 double
    {
        Console.WriteLine("argument d; {0}", d);
        return d;
    }
}

class MethodsMain
{
    public static void Main()
    {
        var m = new Methods();

        //４種類のメソッドを呼び出す。
        m.Show();
        int x = m.Show(5);
        double y = m.Show(1.4142);
        int z = m.Show(3, -1);
    }
}
