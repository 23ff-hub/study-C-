namespace homework
{
    internal class Program
    {
        static void Main()
        {

            //用户信息采集器
            Console.Write("您好：请输入您的姓名");
            string name = Console.ReadLine();

            Console.Write("您好：请输入您的年龄");
            string age = Console.ReadLine();

            Console.Write("您好：请输入您的月收入");
            string num1 = Console.ReadLine();
            decimal num2 = int.Parse(num1);

            Console.Write("您好：请输入您的月支出");
            string num3 = Console.ReadLine();
            decimal num4 = int.Parse(num3);

            Console.Title = "个人财务健康度分析器";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("═══════════════════════════════════════════════");
            Console.WriteLine("       💰 个人财务健康度分析器 v1.0");
            Console.WriteLine("═══════════════════════════════════════════════\n");
            Console.ResetColor();

            Console.WriteLine("您好：{0},年龄{1}。您的月收入【{2}】，您的月支出【{3}】", name, age, num2, num4);

            //计算财务指数
            decimal remain = num2 - num4;
            decimal years = num2 * 12;
            decimal yearsex = num4 * 12;
            decimal money = years - yearsex;
            double bfb = (double)(num4 / num2) * 100;
            Console.WriteLine($"您的月结余：{remain:F2}。您的年收入：{years}。您的年支出：{yearsex}。您的年存款：{money}。您的支出占比：{bfb}%。");

            //财富健康度
            if (remain > 0)
            {
                Console.WriteLine("✅ 财务状态：盈余。继续保持！");
            }
            else
            {
                if (remain == 0) { Console.WriteLine("⚠️ 财务状态：收支平衡。注意开源节流。"); }
                else
                { Console.WriteLine("❌ 财务状态：赤字。请检查支出！"); }
            }


        }
    }
}
