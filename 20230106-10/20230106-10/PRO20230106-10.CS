using System;

class aaaa
{
    public static void Main()
    {
        int[][] jag = new int[5][];

        jag[0] = new int[2];
        jag[1] = new int[3];
        jag[2] = new int[1];
        jag[3] = new int[2];
        jag[4] = new int[3];

        jag[0][0] = 1;
        jag[0][1] = 2;
        jag[1][0] = 1;
        jag[1][1] = 2;
        jag[1][2] = 3;
        jag[2][0] = 1;

        jag[3][0] = 1;
        jag[3][1] = 2;
        jag[4][0] = 1;
        jag[4][1] = 2;
        jag[4][2] = 3;

        for(int i=0; i < jag.Length; i++)
        {
            for(int j=0; j < jag[i].Length; j++)
            {
                Console.Write("{0}, ", jag[i][j]);
            }
            Console.WriteLine();
        }
    }
}
