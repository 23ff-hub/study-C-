namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //计算100以内偶数的和
            //int sum = 0;
            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine("100以内偶数的和为: " + sum);

            //显示出1000 - 2000年中所有的闰年，并以每行四个数的形式输出
            //int count = 0;
            //for (int year = 1000; year <= 2000; year++)
            //{
            //    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            //    {
            //        Console.Write(year + " ");
            //        count++;
            //        if (count % 4 == 0)
            //        {
            //            Console.WriteLine();
            //        }
            //    }
            //}

            //输出一个倒三角形
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 5; j > i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //1 - 1 / 2 + 1 / 3 - 1 / 4 + ... -1 / 100

            //double sum = 0;
            //for(int i = 1; i <= 100; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum -= 1.0 / i;
            //    }
            //    else
            //    {
            //        sum += 1.0 / i;
            //    }
            //}
            //Console.WriteLine("1 - 1/2 + 1/3 - 1/4 + ... - 1/100 = " + sum);

            //求20以内所有数字的阶乘的和
            //int sum = 0;
            //for (int i = 1; i <= 20; i++)
            //{
            //    int factorial = 1;
            //    for (int j = 1; j <= i; j++)
            //    {
            //        factorial *= j;
            //    }
            //    sum += factorial;
            //}
            //Console.WriteLine("20以内所有数字的阶乘的和为: " + sum);

            //篮球从5米高的地方掉下来，每次弹起的高度是原来的30 %，
            //    经过几次弹起，篮球的高度小于0.1米。

            //for (int i = 0; i > 0; i++)
            //{
            //    double height = 5;
            //    height -= height * 0.3;
            //    if (height < 0.1)
            //    {
            //        Console.WriteLine("经过" + i + "次弹起，篮球的高度小于0.1米。");
            //        break;
            //    }
            //}

            //有一个棋盘，有64个方格，
            //    在第一个方格里面放1粒芝麻重量是0.00001kg，
            //    第二个里面放2粒，第三个里面放4，棋盘上放的所有芝麻的重量
            //double totalWeight = 0;
            //for (int i = 0; i < 64; i++)
            //{
            //    double weight = 0.00001 * Math.Pow(2, i);
            //    totalWeight += weight; 
            //}
            //Console.WriteLine(totalWeight);
        }
    }
}
