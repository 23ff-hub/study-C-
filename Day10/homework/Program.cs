using System.Text.RegularExpressions;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //作业: 使用读写文件配合命令行窗口 模拟实现注册功能

            //要求输入用户名和密码,完成注册; (注册的用户信息记录在user.txt文件中, 一行一个用户信息 数据之间通过 === 分隔)
            //Console.WriteLine("请输入用户名");
            //string userName = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string password = Console.ReadLine();
            //Console.WriteLine("注册成功");

            //void Users(string x,string y) 
            //{
            //    File.AppendAllLines(@"./user.txt", [userName]);

            //}
            //Users(userName,password);

            //        扩展练习: 使用读写文件配合命令行窗口 模拟实现注册登录功能

            //进入就是菜单栏界面, 1注册,2登录,0退出

            //输入1 进入注册, 要求输入用户名,密码, 用户输入用户名和密码 则实现注册功能, 要求校验用户名和密码

            //输入2 进入登录, 要求输入用户名, 密码, 输入后完成登录校验功能; 登录成功提示 登录成功

            //输入0 退出程序,

            //-用户注册成功的用户信息 以文件的形式存储在user.json中(要求以json形式存储)
            //  - [{ username: "",password: "",datetime: "时间戳"}]
            //  -用户操作日志user.log: 用户每次操作都要有日志记录, 记录操作,用户名,操作方式,时间,如果有异常的,记录异常
            
            while (true) 
            {
                Console.WriteLine("输入1 进入注册");
                //var zc = Console.ReadLine();
                Console.WriteLine("输入2 进入登录");
                //var dr = Console.ReadLine();
                Console.WriteLine("输入0 退出程序");
                int i = int.Parse(Console.ReadLine());

                switch (i) 
                {
                    case 1:
                        registes();
                        break;
                    case 2:break;
                    case 0:break;
                        default: Console.WriteLine("请重输入"); break;
                }

                List<Dictionary<string,dynamic>> list = new List<Dictionary<string,dynamic>>();

                //进入注册
                void registes() 
                {
                    Console.WriteLine("输入用户名");
                    string userName =  Console.ReadLine();
                    string userName1 = @"[a-z]{10}[0-9]{5}";
                    Console.WriteLine("输入密码");
                    string password1 = @"[a-z]{10}[0-9]{5}";
                    string password = Console.ReadLine();
                    Regex r = new Regex(password1);
                    Regex name = new Regex(userName1);
                 
                    //if () 
                    //{
                    
                    //}

                }
                //进入登录
                //退出程序
            }


        }
    }
}
