using System;

namespace sample
{
    //スーパークラス
    class SuperClass
    {

        private DateTime now;

        //初期化
        public SuperClass()
        {
            now = new DateTime();
        }

        //時刻を文字列で返す。
        public virtual string Message()
        {
            now = DateTime.Now;
            return now.ToString();
        }
    }

    //サブクラス１つめ
    class SubClass1 : SuperClass
    {
        //スーパークラスのMessageメソッドをオーバーライド。
        public override string Message()
        {
            return "こんばんは！";
        }
    }

    //サブクラス２つ目
    class SubClass2: SuperClass
    {
        //スーパークラスのMessageメソッドも使い、オーバーライドする。
        public override string Message()
        {
            return base.Message()+" こんにちは！！";
        }
    }

    class OverrideTest
    {
        static void Main(string[] args)
        {

            SuperClass sp = new SuperClass();
            SubClass1 sb1 = new SubClass1();
            SubClass2 sb2 = new SubClass2();

            //スーパークラスの結果
            Console.WriteLine(sp.Message());

            //サブクラス１の結果
            Console.WriteLine(sb1.Message());

            //サブクラス2の結果
            Console.WriteLine(sb2.Message());

            Console.ReadKey();
        }
    }
}
