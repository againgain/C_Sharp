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
    public Complex(double real, double imag)
    {
        this.real = real;
        this.imag = imag;
    }

    public Complex Add(Complex a)
    {
        return new Complex(this.real + a.real, this.imag + a.imag);
    }

    public Complex Sub(Complex a)
    {
        return new Complex(this.real - a.real, this.imag - a.imag);
    }

    public Complex Mul(Complex a)
    {
        return new Complex(this.real * a.real-this.imag*a.imag, this.real * a.imag + this.imag * a.real );

    }

    public Complex Div(Complex a)
    {
        double deno;
        double numeR;
        double numeI;

        if(a.real ==0 && a.imag == 0)
        {
            Console.WriteLine("0で割ることはできません。");
            return new Complex(0.0, 0.0);
        }
        else
        {
            deno = a.real * a.real + a.imag + a.imag;
            numeR = this.real * a.real + this.imag * a.imag;
            numeI = this.imag * a.real - this.real * a.imag;

            Console.WriteLine("実部の分子={0:F3}、虚部の分子={1:F3}、分母={2:F3} ", numeR, numeI,deno);

            return new Complex(numeR/deno, numeI/deno);
        }
        
    }

    public Complex Conj(Complex a)
    {
        return new Complex(a.real, -a.imag);
    }

}

class ComplexMain
{
    public static void Main()
    {
        /*
        var a = new Complex();
        Console.WriteLine("a = {0}+{1}i", a.real, a.imag);
        */

        var a = new Complex(1.1, 2.5);
        var b = new Complex(-3.7, 1.8);

        Console.WriteLine("a = {0} + {1}i", a.real, a.imag);
        Console.WriteLine("b = {0} + {1}i", b.real, b.imag);
        Console.WriteLine();

        var c = a.Add(b);
        Console.WriteLine("c = {0:F2} + {1:F2}i", c.real, c.imag);

        var d = a.Sub(b);
        Console.WriteLine("d = {0:F2} + {1:F2}i", d.real, d.imag);

        var e = a.Mul(b);
        Console.WriteLine("e = {0:F2} + {1:F2}i", e.real, e.imag);

        var f = a.Div(b);
        Console.WriteLine("f = {0:F3} + {1:F3}i", f.real, f.imag);

        var g = a.Conj(b);
        Console.WriteLine("g = {0:F2} + {1:F2}i", g.real, g.imag);

    }
}

