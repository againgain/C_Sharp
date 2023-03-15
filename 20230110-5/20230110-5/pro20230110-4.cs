using System;

class Shape
{
    public virtual double Area()
    {
        return 0.0;
    }

    public virtual double Perimeter()
    {
        return 0.0;
    }

}

class Rectangle: Shape
{
    double width, height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double Area()
    {
        return width * height;
    }

    public override double Perimeter()
    {
        return 2 * (width + height);
    }
}

class Square : Shape
{
    double length;

    public Square(double length)
    {
        this.length = length;
    }

    public override double Area()
    {
        return length * length;
    }
    public override double Perimeter()
    {
        return 4 * length;
    }
}

class Circle : Shape
{
    double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return radius * radius * Math.PI;
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}


class PolyMain
{
    public static void Main()
    {
        var shapes = new Shape[3];  //基本クラスであるShapeの配列を生成(簡易版)


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
                    shapes[i] = new Rectangle(width, height);
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



        }



        var totalArea = 0.0;    //全ての図形の面積の合計
        var totalPeri = 0.0;    //全ての図形の周囲長の合計


        foreach (var shape in shapes)
        {
            var name = shape.GetType();     //図形のクラス名

            var area = shape.Area();     //図形の面積

            var peri = shape.Perimeter();   //図形の周囲長


            Console.WriteLine($"{name}: area={area}, perimeter={peri}");
            totalArea += area;
            totalPeri += peri;
        }
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"total: area={totalArea}, perimeter={totalPeri}");
    }

}
