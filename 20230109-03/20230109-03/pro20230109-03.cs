using System;

//基本クラスMybaseの定義
class MyBase
{
    //int a = 123;    //フィールド a　の定義
    protected int a = 123;    //フィールド a　の定義

    //メソッドShowBaseの定義
    public void Showbase()
    {
        Console.WriteLine($"MyBase - field a:{a}");
    }

}

//派生クラスMyDerivedの定義
class MyDerived : MyBase
{
    int b = 456;    //フィールドbの定義

    //メソッドShowDerivedの定義
    public void ShowDerived()
    {
        Console.WriteLine($"MyDerived - field a: {a}");
        Console.WriteLine($"MyDerived - field b: {b}");
        Console.WriteLine($"a + b = : {a + b}");

    }
}

class DeriveMain
{
    public static void Main()
    {
        //派生クラスのインスタンスを生成
        var drv = new MyDerived();

        drv.Showbase();     //基本クラスのメソッド
        drv.ShowDerived();  //派生クラスのメソッド
    }
}
/*
class aaaMain
{
    public static void Main()
    {

    }
}
*/
