using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace day12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 回调函数
            //
            //List<int> add(int num) 
            //{
            //    List<int> list = new List<int>();
            //    if (num > 5) 
            //    {
            //        list.Add(num);
            //    }
            //    return list;
            //}

            //Console.WriteLine("请输入要添加的数");
            //int add1 = int.Parse(Console.ReadLine());
            //add(add1);

            //我们要如何去让我们的判断的值可以灵活更改呢，那么我们可以把我们的条件封装成一个函数
            //List<int> add(int num, Func<int, bool> p)
            //{
            //    List<int> list = new List<int>();
            //    if (p(num))
            //    {
            //        list.Add(num);
            //    }
            //    return list;
            //}

            //Console.WriteLine("请输入要添加的数");
            //int add1 = int.Parse(Console.ReadLine());
            //add(add1, p => p > 5);
            #endregion

            //调用类里的函数
            Test test = new Test();
            test.print();
            //test.Age = 18;//protected报错
            //test.Name = "Test";
            //test.Ip = "江西";//private
            //test.IsMan = "男";
            Chird chird = new Chird();
            chird.Info();
        }
       
    }
}
