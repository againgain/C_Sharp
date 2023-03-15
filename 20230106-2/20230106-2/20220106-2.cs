
using System;

class Dormitory
{
    public static void Main()
    {
        Console.Write("学生番号(整数)を入力してください。： ");
        int Number = (int.Parse(Console.ReadLine()))%4;
        switch(Number)
        {
            case 1:
                Console.WriteLine("グリフィンドール");
                break;
            case 2:
                Console.WriteLine("ハッフルパフ");
                break;
            case 3:
                Console.WriteLine("レイブンクロー");
                break;
            default:
                Console.WriteLine("スリザリン");
                break;
        }
    }
}