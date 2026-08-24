namespace console_one
{
    internal class Program
    {
        static void Main()
        {
            //换行
            Console.WriteLine("换行");

            //不换行
            Console.Write("不换行");

            //字符串
            string s = "Hello Word";

            //等待按按键输入换行
            Console.ReadLine();

            //直接按按键输入执行
            Console.ReadKey();

            //占位输出
            Console.WriteLine(s + "{0}{1}", "T", "OM");

            //整数
            int num = 0;

            //浮点数
            double f = 3.1415926;
            float a = 0.0f;

            //布尔值
            bool b = true;

            //数值间的运算
            Console.WriteLine((1+2-1)/2*2);//2
            Console.WriteLine(5%2);//余数1

            int c = 2;
            c++;
            Console.WriteLine(c);//1
            c--;
            Console.WriteLine(c);//1

            //计数圆形面积，周长
            Console.WriteLine("请输入你要计数圆的周长和面积的半径");
            string radio = Console.ReadLine();
            int r = int.Parse(radio);
            double ms = r * 3.14;
            double zc = 2 * r * 3.14;
            Console.WriteLine("周长：{0},面积:{1}",zc,ms);

            //数学对象
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Abs(-3));//3
            Console.WriteLine(Math.Pow(2,2));//4
            Console.WriteLine(Math.Sqrt(8));//算术平方根：2*4,4的根号=2,结果2根号2
            Console.WriteLine(Math.Round(3.5));//四舍五入
            Console.WriteLine(Math.Floor(3.5));//向下取整
            Console.WriteLine(Math.Ceiling(4.5));//向上取整

            /*
             总结：
                console使用
                console.write:输出文字、数值等不换行
                console.writeline:输出文字、数值等换行
                console.readline:让用户输出文字、数值等按enter结束
                console.readkey:让用户输出文字、数值等直接结束
                占位输出："{0}{1}",1,2结果1,2
                
                数据类型
                int：整数类型
                string：字符类型
                double：小数类型
                bool：布尔类型

                数学对象方法
                math.pi：π
                math.abs：绝对值
                math.pow：平方根
                math.sqrt：算数平方根
                math.round：四舍五入
                math.floor：向下取整
                math.ceiling：向上取整
                
             */

        }
    }
}
