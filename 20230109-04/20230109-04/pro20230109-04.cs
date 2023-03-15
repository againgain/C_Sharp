using System;

//動物クラス
class Animal
{
    //クラスの説明を表示する。
    public virtual void Describe()
    {
        Console.WriteLine("これは動物です。");
    }
}

//魚類クラス(動物クラスを継承)

class Fish:Animal
{
    //親クラスのDescribeをオーバーライド
    public override void Describe()
    {
        Console.WriteLine("これは魚類です。");
    }
}

//メダカクラス(魚類クラスを継承)
class KillyFish: Fish
{
    //親クラスのDescribeをオーバーライド
    public override void Describe()
    {
        Console.WriteLine("これはメダカです。");
    }
}
class OverrideMain
{
    public static void Main()
    {
        //各クラスのインスタンスを生成
        var a = new Animal();
        var f = new Fish();
        var k = new KillyFish();

        //それぞれのクラスの説明を表示
        a.Describe();
        f.Describe();
        k.Describe();
    }

}