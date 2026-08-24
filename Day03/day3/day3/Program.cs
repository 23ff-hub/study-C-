using System.Diagnostics;

namespace day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 运算符
            #endregion

            //### 1、关系运算
            //符号：> >= < <= == !
            //也叫比较运算符,关系运算的结果是 布尔值

            //Console.WriteLine("请输入第一个数字");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int n2 = int.Parse(Console.ReadLine());
            ////bool res = n1 > n2;
            ////bool res = n1 < n2;
            ////bool res = n1 >= n2;
            ////bool res = n1 <= n2;
            ////bool res = n1 == n2; // 两值相等才为true
            //bool res = n1 != n2;  // 不相等才为true

            //Console.WriteLine(res);

            //2、逻辑运算

            //符号：`&& || !& |`

            //短路运算和非短路运算的区别。

            //`&&`表示并且，连接两个条件，表示两个条件同时成立，整体才算是成立

            //例：小红想做车模，车模条件年龄16~22

            //`||`表示或者，连接两个条件，表示两个条件只要有1个成立，整体就算成立

            //例：小明择偶标准：要么资产在300w以上，要么颜值大于9.5。输入小红的资产和颜值
            //Console.WriteLine("请输入的年龄");
            //int age = int.Parse(Console.ReadLine());
            //bool res = age > 16 && age < 22;
            //Console.WriteLine(res);

            //Console.WriteLine("请输入资产");
            //int money = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入颜值");
            //double yz = double.Parse(Console.ReadLine());
            //bool res = money > 300 || yz > 9.5;
            //Console.WriteLine(res);

            //// !取反 
            //bool isMan = false;
            //isMan = !isMan;
            //Console.WriteLine(isMan);

            //// &不断路
            //int n = 0;
            //int num = 1;
            //bool res = n > num & n < num++;
            //Console.WriteLine(res);
            //Console.WriteLine(num);

            //// |不断路
            //int n = 0;
            //int num = 1;
            //bool res = n < num | n < num++;
            //Console.WriteLine(res);
            //Console.WriteLine(num);

            //二、分支语句
            //if (条件表达式)
            //{
            //    当条件表达式的结果为true的时候要执行的代码
            // }
            //if (条件表达式)
            //{
            //    当条件表示式的结果为true的时候要执行的代码
            //   }
            //else
            //{
            //    当条件表达式的结果为false的时候要执行的代码
            //   }

            //1、switch多路判断
            //switch (变量)
            //{
            //    case 值1:
            //        执行的代码块
            //        break;
            //    case 值2:
            //        执行的代码块
            //    break;
            //    。。。
            //    default:
            //        执行代码块
            //    break;
            //}

            //switch简写
            //    Console.WriteLine("输入成绩：");
            //double score = double.Parse(Console.ReadLine());
            //if (score > 0 && score <= 100)
            //{
            //    string res = score switch
            //    {
            //        //表达式 => 结果,  // 表达式中变量省略
            //        // _ => 结果  _ 表示default
            //        >= 90 => "A",
            //        >= 80 => "B",
            //        >= 70 => "C",
            //        >= 60 => "D",
            //        _ => "F"
            //    };
            //    Console.WriteLine(res);
            //}
            //else
            //{
            //    Console.WriteLine("输入有误");
            //}

            //三元运算
            //条件?条件成立时得到的结果: 条件不成立时结果;
            //int a = 1;
            //int b = 2;
            //int max = 0;
            ////if (a > b) {  max = a; } else { max = b; }
            ////Console.WriteLine(max);

            //max = a > b ? a : b;
            //Console.WriteLine(max);
        }
    }
}

