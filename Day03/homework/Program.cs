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

            ////1. 计算任意两个输入数字的和
            //Console.WriteLine("请输入要相加的数：");
            //string a = Console.ReadLine();
            //Console.WriteLine("请输入要相加的数：");
            //string b = Console.ReadLine();
            //int c = int.Parse(a) + int.Parse(b);
            //Console.WriteLine($"等于：{c}");

            ////摄氏度 = 5/9.0*(华氏度 - 32)
            //Console.WriteLine("输入的华氏摄氏度转换为摄氏度：");
            //string hs = Console.ReadLine();
            //int ssd = int.Parse(hs);
            //double d = (5 / 9.0 * (ssd - 32));
            //Console.WriteLine($"摄氏度为：{d:F3}度");

            ////89%24
            //int remain = 89 % 24;
            //int day = 89 / 24;
            ////int day = (int)Math.Floor(e);
            //Console.WriteLine($"为抵抗洪水，战士连续作战89小时，编程计算共{day}天{remain}小时");


            //账号密码验证（练习分支嵌套）：
            //账号规定是"admin"，密码规定是"123456"。
            //让用户输入账号和密码，判断账号和密码是否正确，账号和密码都正确就输出登入成功
            //；账号不对，就输出账号不存在；密码不对，就输出密码错误。
            //Console.WriteLine("请输入账号：");
            //string str = Console.ReadLine();
            //Console.WriteLine("请输入密码：");
            //string password = Console.ReadLine();
            //if(str == "admin" & password == "123456") 
            //{
            //    Console.WriteLine("登入成功");
            //}
            //else if(str != "admin")
            //{
            //    Console.WriteLine("账号不存在");
            //}
            //else
            //{
            //    Console.WriteLine("密码错误");
            //}、

            //选择菜单（add / edit / del）执行操作（练习多分支和switch）：
            //提示用户选择菜单（add / edit / del），
            //判断输入的是add，就输出新增成功；输入的是edit，
            //就输出编辑成功；输入的是del，就输出删除成功。
            //Console.WriteLine("请选择操作（1.add / 2.edit / 3.del）：");
            //string str = Console.ReadLine();
            //switch(str)
            //{
            //    case "add":
            //        Console.WriteLine("新增成功");
            //        break;
            //    case "edit":
            //        Console.WriteLine("编辑成功");
            //        break;
            //    case "del":
            //        Console.WriteLine("删除成功");
            //        break;
            //    default:
            //        Console.WriteLine("输入错误");
            //        break;
            //}

            //会员打折满1000打9折，普通用户满2000打9.5折（练习多分支和分支嵌套）：
            //    让用户输入自己的类型（VIP / USER）和消费金额，如果是VIP，
            //    判断消费金额是否达到1000，如果达到了，就输出他应该支付的金额，如果没有达到，
            //    也输出他应该支付的金额；如果是USER，
            //    判断消费金额是否达到2000，如果达到了和没有达到，都输出他应该支付的金额。
            //Console.WriteLine("输入自己的类型（VIP / USER)");
            //string str = Console.ReadLine();
            //Console.WriteLine("输入自己的消费金额");
            //int str2 = int.Parse(Console.ReadLine());
            //if(str == "VIP" && str2 >= 1000)
            //{
            //    Console.WriteLine(str2 * 0.9);
            //}else if(str == "USER" && str2>=2000)
            //{
            //    Console.WriteLine(str2 * 0.95);
            //}

            //通过月份判断季节（练习switch的穿透写法）：
            //    用户输入月份，判断月份如果是3、4、5月份，
            //    就输出这是春季；如果是6、7、8月份，就输出这是夏季；如果是9、10、11月份，
            //    就输出这是秋季，如果是12、1、2月份，就输出这是冬季。

            //Console.WriteLine("请输入月份：");
            //int month = int.Parse(Console.ReadLine());
            //switch (month)
            //{
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("这是春季");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("这是夏季");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("这是秋季");
            //        break;
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("这是冬季");
            //        break;
            //    default:
            //        Console.WriteLine("输入错误");
            //        break;
            //}

            //快递运费（练习多分支）：输入快递重量，单位是Kg，
            //    如果重量小于1Kg，输出快递费10元；
            //    如果重量在1Kg~5Kg之间，就输出快递费20元；
            //    如果重量超过5Kg，就输出快递费50元。

            //Console.WriteLine("请输入快递重量（Kg）：");
            //double weight = double.Parse(Console.ReadLine());
            //if (weight < 1)
            //{
            //    Console.WriteLine("快递费：10元");
            //}
            //else if (weight <= 5)
            //{
            //    Console.WriteLine("快递费：20元");
            //}
            //else
            //{
            //    Console.WriteLine("快递费：50元");
            //}   

            //会员等级优惠（练习多分支和switch）
            //    输入会员等级，等级是3~5的整数，判断等级如果是5，
            //    输出终身免运费；
            //    等级是4，输出每月可领优惠券；等级是3，
            //    输出购物打9折，否则没有福利。

            //Console.WriteLine("请输入会员等级（3~5）：");
            //int level = int.Parse(Console.ReadLine());
            //switch (level)
            //{
            //    case 5:
            //        Console.WriteLine("终身免运费");
            //        break;
            //    case 4:
            //        Console.WriteLine("每月可领优惠券");
            //        break;
            //    case 3:
            //        Console.WriteLine("购物打9折");
            //        break;
            //    default:
            //        Console.WriteLine("没有福利");
            //        break;
            //}
        }
    }
}
