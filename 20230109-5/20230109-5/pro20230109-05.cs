using System;

//基本クラスMybaseの定義
class MyBase
{
    protected int a;    //フィールド a　の定義


    //MyjBaseコンストラクタ
    /*
    public MyBase()
    {
        a = 123;
        Console.WriteLine("MyBase Constructor");
        Console.WriteLine($"a = {a}");
    }
    */

    public MyBase(int n)
    {
        a = n;
        Console.WriteLine("MyBase Constructor");
        Console.WriteLine($"a = {a}");
    }



    /*
    //メソッドShowBaseの定義
    public void Showbase()
    {
        Console.WriteLine($"MyBase - field a:{a}");
    }
    */

}

//派生クラスMyDerivedの定義
class MyDerived : MyBase
{
    //int b = 456;    //フィールドbの定義

    protected int b;    //フィールドbの定義

    //MyDerivedコンストラクタ
    /*
    public MyDerived()
    {
        b = a * 2;
        Console.WriteLine("MyDerived Constructor");
        Console.WriteLine($"a = {a}, b = {b}");
    }
    */

    //MyDerivedコンストラクタ
    public MyDerived(int n) : base(n / 2)
    {
        b = n;
        Console.WriteLine("MyDerived Constructor");
        Console.WriteLine($"a = {a}, b = {b}");
    }

    
        
    

    /*
    //メソッドShowDerivedの定義
    public void ShowDerived()
    {
        Console.WriteLine($"MyDerived - field a: {a}");
        Console.WriteLine($"MyDerived - field b: {b}");
        Console.WriteLine($"a + b = : {a + b}");

    }
    */
}

class DeriveMain
{
    public static void Main()
    {
        
        //派生クラスのインスタンスを生成
        //var drv = new MyDerived();
        var drv = new MyDerived(222);


        /*
        drv.Showbase();     //基本クラスのメソッド
        drv.ShowDerived();  //派生クラスのメソッド
        */
    }
}
