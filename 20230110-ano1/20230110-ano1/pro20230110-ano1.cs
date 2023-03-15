
using System;
//形全般 基本クラス
class ShapeB
{
    //フィールド(変数)
    protected double areaB;
    protected double perimeterB;
    protected double kijunAtai;

    //基本コンストラクタ
    public ShapeB()
    {
        areaB = 0.0;
        perimeterB = 0.0;
        kijunAtai = 0.0;
    }

    //基準の値を取得
    public double GetKijunAtai()
    {
        return kijunAtai;
    }


    //面積を求める？shapeではいらない？いや、共通事項として必要らしい
    public virtual double AreaB()
    {
        //Console.WriteLine("●ノーマル　形　面積");
        //areaB = 0.0;
        return areaB;
    }



    //周囲の長さを求める？shapeではいらない？いや、共通事項として必要らしい。
    public virtual double PerimeterB()
    {
        perimeterB = 0.0;
        return perimeterB;
    }

}

//長方形について
class RecatangleB : ShapeB
{
    double width;
    double height;


    //通常のコンストラクタ
    public RecatangleB()
    {
        //Console.WriteLine("●通常の長方形コンストラクタ");
        width = 0.0;
        height = 0.0;
        kijunAtai = width;

        areaB = width * height;
        perimeterB = 2 * (width + height);
    }

    //幅と高さを与えられたら、面積と周囲の長さを設定する。
    public RecatangleB(double w, double h)
    {
        //Console.WriteLine("●値あり長方形コンストラクタ");
        width = w;
        height = h;
        kijunAtai = width;


        areaB = width * height;
        perimeterB = 2 * (width + height);

    }




    public override double AreaB()
    {
        return areaB;
    }


    //周囲の長さを求めて周囲の長さを返す。
    public override double PerimeterB()
    {
        //perimeterB = 2 * width + 2 * height;
        return perimeterB;
    }



}

//正方形について
class SquareB : ShapeB
{
    double hen;

    //値なしコンストラクタ
    public SquareB()
    {
        areaB = hen * hen;
        perimeterB = 4.0 * hen;
        kijunAtai = hen;
    }


    //値つきコンストラクタ
    public SquareB(double h)
    {
        //Console.WriteLine("値つき正方形のコンストラクタ");
        hen = h;
        areaB = hen * hen;
        perimeterB = 4.0 * hen;
        kijunAtai = hen;
    }



    //面積を返す。(値無し)
    public override double AreaB()
    {
        return areaB;
    }


    //周囲の長さを返す。
    public override double PerimeterB()
    {
        //return perimeterB = 4.0 * hen;
        return perimeterB;
    }


}

//円について
class CircleB : ShapeB
{
    double rr;

    //値無しコンストラクタ
    public CircleB()
    {
        areaB = rr * rr * Math.PI;
        perimeterB = 2 * Math.PI * rr;
        kijunAtai = rr;
    }
    //値つきコンストラクタ
    public CircleB(double r)
    {
        rr = r;
        areaB = rr * rr * Math.PI;
        perimeterB = 2 * Math.PI * rr;
        kijunAtai = rr;
    }


    //面積を返す
    public override double AreaB()
    {
        //return areaB = rr * rr * Math.PI;
        return areaB;
    }
    //周囲の長さを返す。
    public override double PerimeterB()
    {
        return perimeterB;
    }



}


class PolyMain
{
    public static void Main()
    {
        var shapes = new ShapeB[3];  //基本クラスであるShapeの配列を生成(簡易版)

        var dtest = 0.0;

        //図形を選択してから、その図形のサイズ(辺の長さ、半径など)を入力する。

        for (var i = 0; i < shapes.Length; i++)
        {
            Console.WriteLine("図形を選んでください。(1：長方形 2：正方形 3：円)　;");
            var t = int.Parse(Console.ReadLine());

            switch (t)
            {
                case 1://長方形の幅・高さを入力
                    Console.Write("幅を入力してください。");
                    var width = double.Parse(Console.ReadLine());
                    Console.Write("高さを入力してください。");
                    var height = double.Parse(Console.ReadLine());

                    //長方形のインスタンスを生成
                    shapes[i] = new RecatangleB(width, height);
                    break;

                case 2://正方形の１辺の長さを入力。
                    Console.Write("１辺の長さを入力してください。");
                    var hen = double.Parse(Console.ReadLine());

                    //正方形のインスタンスを生成
                    shapes[i] = new SquareB(hen);
                    break;
                case 3://円の半径を入力
                    Console.Write("半径を入力してください。");
                    var r = double.Parse(Console.ReadLine());

                    //円のインスタンスを生成
                    shapes[i] = new CircleB(r);
                    break;
                default://それ以外の入力の場合。
                    break;

            }



        }

        var totalArea = 0.0;    //全ての図形の面積の合計
        var totalPeri = 0.0;    //全ての図形の周囲長の合計

        foreach (var shape in shapes)
        {
            var name = shape.GetType();     //図形のクラス名
            var area = shape.AreaB();     //図形の面積
            var peri = shape.PerimeterB();   //図形の周囲長

            Console.WriteLine($"{name}: area={area}, perimeter={peri}");
            totalArea += area;
            totalPeri += peri;
        }
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"total: area={totalArea}, perimeter={totalPeri}");
    }

}
