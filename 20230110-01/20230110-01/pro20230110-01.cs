using System;


class Complex
{
    public double real;
    public double imag;

    public Complex()
    {
        real = 0.0;
        imag = 0.0;
    }

    public Complex(double real,double imag)
    {
        this.real = real;
        this.imag = imag;
    }

    public Complex Add(Complex a)
    {
        var r = this.real + a.real;
        var i = this.imag + a.imag;
        var c = new Complex(r, i);
        return c;
    }

    public double Abso()
    {
        double a = Math.Sqrt(real * real + imag * imag);
        return a;
    }

}

class shape2
{
    public void shapeshape()
    {
        double area = 0.0;
        double peri = 0.0;
    }
 
}

class Sample
{
    public static void Main()
    {
        //配列の宣言
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };

        foreach(int num in numbers)
        {
            //画面に出力
            Console.WriteLine("{0}", num);
        }

        double aa = 0.0;

        Complex bb = new Complex();

        var a = new Complex(1.1, 2.5);
        var b = new Complex(-3.7, 1.8);

        var c = a.Add(b);
        Console.WriteLine($"c = {c.real}+{c.imag}i ");

        var d = a.Abso();
        Console.WriteLine($"d = {d,5:F2}");


    }
}