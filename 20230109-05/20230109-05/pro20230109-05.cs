using System;

/* //ここからほぼ書き写し
class Shape
{
    public double are;
    public double peri;

    public double Area()
    {
        are = 0.0;
        return are;
    }

    public double Perimeter()
    {
        peri = 0.0;
        return peri;
    }
}

class Circle : Shape
{

}

class Square : Shape
{

}

class Recatangle : Shape
{
    double width;
    double height;
    double area;
    double peri;

    public double Area(Recatangle re):shape.Area();
    {
        double area = 0.0;
        area = re.width * re.height;
        return area;
    }

    
}

class PolyMain
{
    public static void Main()
    {
        var shapes = new Shape[5];  //基本クラスであるShapeの配列を生成

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
                    shapes[i] = new Recatangle(width, height);
                    break;

                case 2://正方形の１辺の長さを入力。
                    Console.Write("１辺の長さを入力してください。");
                    var hen = double.Parse(Console.ReadLine());

                    //正方形のインスタンスを生成
                    shapes[i] = new Square(hen);
                    break;
                case 3://円の半径を入力
                    Console.Write("半径を入力してください。");
                    var r = double.Parse(Console.ReadLine());

                    //円のインスタンスを生成
                    shapes[i] = new Circle(r);
                    break;
                default://それ以外の入力の場合。
                    break;

            }

            var totalArea = 0.0;    //全ての図形の面積の合計
            var totalPeri = 0.0;    //全ての図形の周囲長の合計

            foreach (var shape in shapes)
            {
                var name = shape.GetType();     //図形のクラス名
                var area = shape.Aria();        //図形の面積
                var peri = shape.Perimeter();   //図形の周囲長

                Console.WriteLine($"{name}: area={area}, perimeter={peri}");
                totalArea += area;
                totalPeri += peri;
            }
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"total: area={totalPeri}, perimeter={totalPeri}");
        }
    }

}
*/ //ここまでほぼ書き写し
//=========================================================

//形全般
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
class RecatangleB
{
    //フィールド　継承していれば記入不要。
    protected double areaB;
    protected double perimeterB;

    //基本コンストラクタ　継承していれば記入不要。
    public RecatangleB()
    {
        areaB = 0.0;
        perimeterB = 0.0;
    }

    //幅と高さを与えられたら、面積と周囲の長さを設定する。
    public RecatangleB(double w, double h)
    {
        areaB = w * h;
        perimeterB = 2 * (w + h);
    }

    /*
    public double AreaB()
    {
        areaB = 0.0;
        return this.areaB;
    }
    */

    //面積を求めて面積を返す。
    public double AreaB(double w,double h)
    {
        areaB = w * h;
        return areaB;
    }

    /*
    public double PerimeterB()
    {
        return this.perimeterB = 0.0;
    }
    */


    //周囲の長さを求めて周囲の長さを返す。
    public double PerimeterB(double w,double h)
    {
        perimeterB = 2 * w + 2 * h;
        return perimeterB;
    }

    
}

//正方形について
class SquareB
{
    //フィールド　継承していれば記入不要。
    protected double areaB;
    protected double perimeterB;

    //基本コンストラクタ　継承していれば記入不要。
    public SquareB()
    {
        areaB = 0.0;
        perimeterB = 0.0;
    }

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
class CircleB
{
    //フィールド　継承していれば記入不要。
    protected double areaB;
    protected double perimeterB;

    //基本コンストラクタ　継承していれば記入不要。
    public CircleB()
    {
        areaB = 0.0;
        perimeterB = 0.0;
    }

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

        var ShapeB = new ShapeB();

        var CircleB = new CircleB();

        var RectangleB = new RecatangleB(1,2);

        a = CircleB.AreaB(2);

        Console.WriteLine("円の面積は{0,5:F2}",a);
        //Console.WriteLine("長方形の面積は{0}", RectangleB.AreaB);
    }
}