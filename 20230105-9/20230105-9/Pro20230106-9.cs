using System;

class aaaa
{
    public static void Main()
    {
        int[,] score = new int[4, 3];

        score[0, 0] = 73;
        score[0, 1] = 82;
        score[0, 2] = 65;
        score[1, 0] = 90;
        score[1, 1] = 75;
        score[1, 2] = 83;
        score[2, 0] = 69;
        score[2, 1] = 77;
        score[2, 2] = 74;
        score[3, 0] = 79;
        score[3, 1] = 65;
        score[3, 2] = 83;

        int iSum = 0;
        int[] total = new int[4];

        for(int i = 0; i < 4; i++)
        {
            total[i] = 0;
            for(int j = 0; j < 3; j++)
            {
                Console.Write("score[{0}, {1}] = {2}  ", i, j, score[i, j]);
                iSum += score[i, j];
                total[i] += score[i, j];
            }
            Console.WriteLine("合計は {0}   {1}", iSum, total[i]);
            Console.WriteLine();
            iSum = 0;
        }
    }
}
