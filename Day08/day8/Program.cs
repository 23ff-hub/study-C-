using System;
using System.Threading.Channels;

namespace day8
{
    delegate int MyFunc(int a,int b);
    internal class Program
    {
        static void Main(string[] args)
        {
            //定义函数
            //函数就是一段能重复调用、能干活的代码块，不用每次重复写一堆代码。

            //无返回值的函数
            //大白话：干活只出效果，干完不给你返回数据。
            //格式：修饰符 void 函数名(参数) { 代码 }
            //示例：打印东西、修改数据，不用拿结果
            // 只打印，不给你返回任何数字/文字
            //void PrintHello(int x)
            //{
            //    Console.WriteLine(x);
            //}

            //// 调用
            //PrintHello(2);

            ////有返回值函数（int/ string / 自定义类等）
            ////大白话：干完活必须给你吐一个结果，调用时要用变量接住。
            ////格式：修饰符 数据类型 函数名(参数){ return 结果; }
            ////必须写 return，否则报错
            //// 算加法，最后返回总和
            //int Add(int a, int b)
            //{
            //    return a + b; // 把结果交出去
            //}

            //// 调用，用变量接住返回的数字
            //int sum = Add(3, 5);
            //Console.WriteLine(sum); //8

            ////无参函数
            //void ShowTime()
            //{
            //    Console.WriteLine(DateTime.Now);
            //}
            //ShowTime(); //直接空括号调用

            ////有参函数
            //// 需要传2个数字进来计算
            //int Add(int n1, int n2)
            //{
            //    return n1 + n2;
            //}
            //Add(2, 9); //不传数字直接报错

            ////可选参数（给参数设默认值，不传也没事）
            //// b默认等于10，调用时可以只传a
            //int Calc(int a, int b = 10)
            //{
            //    return a * b;
            //}
            //Calc(2);  //等价 Calc(2,10) →20
            //Calc(2, 5);//手动覆盖默认值 →10

            //Console.WriteLine("请输入乘法表数");
            //int s = int.Parse(Console.ReadLine());
            //void biao(int n) 
            //{
            //    for (int i = 1; i <= n; i++)
            //    {
            //        for (int j = 1; j <= i; j++)
            //        {
            //            Console.Write($"{i}*{j}={i * j}" + "\t");
            //        }
            //        Console.WriteLine();
            //    }
            //}

            //biao(s);

            //匿名函数
            //（x,y）=> x+y;//报错，他是匿名函数需要被接收
            //无返回值接收
            //Action action = () => { Console.WriteLine("hello"); };
            //Action<int,int> action1 = (x,y) => { Console.WriteLine(x + y) ; };
            //action1(2, 3);

            //有返回值
            //Func<int,int,int> addFun = (x, y) => x + y;
            //addFun(1, 2);
            //Console.WriteLine(addFun);

            //delegate 返回值类型 函数类型名称(参数类型 参数名, ...); // 必须放在命名空间内或类内部，不能放在方法内部
            //MyFunc fn = (int a, int b) => {
            //    int c = a + b;
            //    return c;
            //};
            //Console.WriteLine(fn(2, 3));

            //抛出数据
            //            返回值类型 函数(参数, .., out 类型 数据名) {
            //                给out抛出的变量进行赋值即可
            //}
            //            函数(参数, ..., out 类型 变量名);

            //bool PrintCollection(string[] arr, char splitChar, out string joinStr)
            //{
            //    List<string> list = arr.ToList();
            //    joinStr = string.Join(splitChar, list);
            //    return true;
            //}
            //bool isSuccess = PrintCollection(new string[] { "aa", "bb", "cc" }, '-', out string result);
            //Console.WriteLine(result);//aa-bb-cc
            //Console.WriteLine(isSuccess);//true

            //异常处理
            //调用运行使用时错误
            //1.拦截异常，避免程序整体崩溃
            //2.打印错误信息、记录日志，方便排查问题
            //3.给用户友好提示
            //4.安全释放文件、数据库、网络等占用的资源，避免错误代码占用内存

            //int[] arr = { 11, 22, 33 };
            //Console.Write("输入数组下标：");
            //int input = int.Parse(Console.ReadLine());
            //try
            //{
            //    int index = int.Parse(input);
            //    Console.WriteLine($"数组值：{arr[index]}");
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("输入的下标格式错误" + ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("");
            //}

            //if (input > 90) 
            //{
            //    // 手动抛出异常，告知调用者错误原因
            //    throw new ArgumentException("数太大了！");
            //}


        }
    }
}
