using System;

class Sin01
{
    public static void Main()
    {
        double s;
        double c;

        for(double a = 0.0; a <= Math.PI; a += Math.PI / 45.0)
        {
            s = Math.Sin(a);
            Console.Write("{0,7:F4}: ", s);
            for(int i = 1; i <= Math.Round(s*50); i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

            
        }


        for (double a = 0.0; a <= Math.PI; a += Math.PI / 45.0)
        {
            c = Math.Cos(a);
            Console.Write("{0,7:F4}: ", c);
            for (int i = 1; i <= Math.Round(c * 50); i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();


        }

        for (double a = 0.0; a <= Math.PI; a += Math.PI / 45.0)
        {
            c = Math.Cos(a);
            Console.Write("{0,7:F4}: ", c);
            for (int i = 1; i <= Math.Round(Math.Abs(c) * 50); i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();


        }


    }
}
