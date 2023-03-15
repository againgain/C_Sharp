using System;
//形全般 基本クラス
class ShapeB
{
    //フィールド(変数)
    protected double areaB;
    protected double perimeterB;

    //基本コンストラクタ
    public ShapeB()
    {
        areaB = 0.0;
        perimeterB = 0.0;
    }

    //面積を求める？shapeではいらない？いや、共通事項として必要らしい。
    public double AreaB()
    {
        areaB = 0.0;
        return areaB;
    }

    //周囲の長さを求める？shapeではいらない？いや、共通事項として必要らしい。
    public double PerimeterB()
    {
        perimeterB = 0.0;
        return perimeterB;
    }


}

//長方形について
class RecatangleB:ShapeB
{
    /*
    //フィールド　継承していれば記入不要。
    protected double areaB;
    protected double perimeterB;

    //基本コンストラクタ　継承していれば記入不要。
    public RecatangleB()
    {
        areaB = 0.0;
        perimeterB = 0.0;
    }
    */

    //幅と高さを与えられたら、面積と周囲の長さを設定する。
    public RecatangleB(double w, double h)
    {
        areaB = w * h;
        perimeterB = 2 * (w + h);
    }


    //面積を求めて面積を返す。
    public double AreaB(double w, double h)
    {
        areaB = w * h;
        return areaB;
    }


    //周囲の長さを求めて周囲の長さを返す。
    public double PerimeterB(double w, double h)
    {
        perimeterB = 2 * w + 2 * h;
        return perimeterB;
    }


}

//正方形について
class SquareB:ShapeB
{
    /*
    //フィールド　継承していれば記入不要。
    protected double areaB;
    protected double perimeterB;

    //基本コンストラクタ　継承していれば記入不要。
    public SquareB()
    {
        areaB = 0.0;
        perimeterB = 0.0;
    }
    */

    //値つきコンストラクタ
    public SquareB(double hen)
    {
        areaB = hen * hen;
        perimeterB = 4.0 * hen;
    }

    //面積を返す。
    public double AreaB(double hen)
    {
        return areaB = hen * hen;
    }

    //周囲の長さを返す。
    public double PerimeterB(double hen)
    {
        return perimeterB = 4.0 * hen;
    }

}

//円について
class CircleB:ShapeB
{
    /*
    //フィールド　継承していれば記入不要。
    protected double areaB;
    protected double perimeterB;

    //基本コンストラクタ　継承していれば記入不要。
    public CircleB()
    {
        areaB = 0.0;
        perimeterB = 0.0;
    }
    */

    //値つきコンストラクタ
    public CircleB(double r)
    {
        areaB = r * r * Math.PI;
        perimeterB = 2 * Math.PI * r;
    }

    //面積を返す
    public double AreaB(double r)
    {
        return areaB = r * r * Math.PI;
    }
    //周囲の長さを返す。
    public double PerimeterB(double r)
    {
        return perimeterB = 2 * Math.PI * r;
    }


}

class ShapeShape
{
    public static void Main()
    {
        double a = 0.0;
        double b = 0.0;
        double c = 0.0;

        
        //var ShapeB = new ShapeB();

        
        var CircleB = new CircleB(1);

        var squareB = new SquareB(1);

        var RectangleB = new RecatangleB(1, 2);
        

        a = CircleB.AreaB(3);
        b = RectangleB.AreaB(3, 4);
        //c = squareB.areaB;    //値はprotectedで守られている。
        c = squareB.AreaB(10);

        Console.WriteLine("円の面積は{0,5:F2}", a);
        Console.WriteLine("長方形の面積は{0,5:F2}", b);
        Console.WriteLine("正方形の面積は{0,5:F2}", c);
    }
}