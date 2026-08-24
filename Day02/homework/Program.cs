namespace homework
{
    internal class Program
    {
        static void Main()
        {
            /*
            1. 计算任意两个输入数字的和
            2. 小明要到美国旅游，可是那里的温度k是以华氏度为单位记录的。他需要一个程序将华氏温度（80度）转换为摄
               氏度，并以华氏度和摄氏度为单位分别显示该温度（提示：摄氏度与芈氏度的转换公式为：摄氏度 = 5/9.0*(华
               氏度-32)保留3位小数）
            3. 通过数学运算交换两个整型变量的值
            4. 为抵抗洪水，战士连续作战89小时，编程计算共多少天零多少小时？
            */

            //1. 计算任意两个输入数字的和
            Console.WriteLine("请输入要相加的数：");
            string a = Console.ReadLine();
            Console.WriteLine("请输入要相加的数：");
            string b = Console.ReadLine();
            int c = int.Parse(a) + int.Parse(b);
            Console.WriteLine($"等于：{c}");

            //摄氏度 = 5/9.0*(华氏度 - 32)
            Console.WriteLine("输入的华氏摄氏度转换为摄氏度：");
            string hs = Console.ReadLine();
            int ssd = int.Parse(hs);
            double d = (5 / 9.0 * (ssd - 32));
            Console.WriteLine($"摄氏度为：{d:F3}度");

            //89%24
            int remain = 89 % 24;
            int day = 89 / 24;
            //int day = (int)Math.Floor(e);
            Console.WriteLine($"为抵抗洪水，战士连续作战89小时，编程计算共{day}天{remain}小时");
        }
    }
}
