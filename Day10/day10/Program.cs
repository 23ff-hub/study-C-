using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IO文件操作
            //void readNote()
            //{

            //文件的操作，读和写
            //写
            //AppendAllText：再次创建内容不会被覆盖,每次运行都会追加一次内容
            //File.AppendAllText(@"./text.txt","hello");
            //File.AppendAllLines(@"./text.txt", ["第一行","第二行","第三行"]);

            ////WriteAllText：再次创建内容会被覆盖
            //File.WriteAllText(@"./log.txt", "hello");
            //File.WriteAllLines(@"./log.txt", ["第一行", "第二行", "第三行"]);

            //读
            //读取所有文本，返回字符串
            //string text = File.ReadAllText(@"./text.txt");
            //Console.WriteLine(text);
            //string[] str1 = File.ReadAllLines(@"./log.txt");
            //Console.WriteLine(string.Join(",",str1));

            //对文件进行基础操作
            //File.Exists(@"./text.txt");//判断文件是否存在
            //File.Delete(@"./text.txt");//删除文件
            //File.Copy("text.txt", "log.txt");//复制文件
            //File.Move("text.txt", @"./...");//剪切文件

            //对文件夹的基本操作
            //Directory.CreateDirectory(@"./text");//创建文件夹
            //bool b = Directory.Exists(@"./text");//查看./是否有文件夹
            //Console.WriteLine(b);//true

            //Directory.Delete(@"./text");//删除空文件夹
            //Directory.GetFiles(@"./text");//获取文件夹下所有文件的路径返回的是一个数组
            //Directory.GetDirectories(@"./text");获取文件夹下的子文件夹

            //// 匹配所有文件夹
            //GetDirectories(path, "*", ...);

            //// 匹配名字以book开头的文件夹，例如 book01、bookdata
            //GetDirectories(path, "book*", ...);

            //// 匹配名称一共4位，前两位是log，后面任意2字符：log01、logaabb
            //GetDirectories(path, "log??", ...);

            //// 例：
            //// 文件夹筛选
            //Directory.GetDirectories(path, "data*", SearchOption.TopDirectoryOnly);
            //// 文件筛选
            //Directory.GetFiles(path, "*.json", SearchOption.TopDirectoryOnly);

            // 拼接路径（自动适配Windows斜杠，不要自己手写 \ /）
            //string fullPath = Path.Combine(folder, "book.json");

            //// 获取文件名
            //Path.GetFileName(@"D:\a\book.json"); // book.json

            //// 获取后缀
            //Path.GetExtension("book.json"); // .json

            //// 获取文件夹目录
            //Path.GetDirectoryName(@"D:\a\book.json");
            //}
            //readNote();
            #endregion


            #region Linp
            //Linq的定义：给集合数组做筛选、过滤、排序、分组、转换数据
            //集合(筛选、过滤、排序、分组、转换数据)
            //定义集合
            //List<int> num = [1, 2, 4, 5, 6, 7, 9, 2, 3];
            //int[] num1 = [1, 2, 4, 5, 6, 7, 9, 2, 3];
            //筛选
            //Console.ReadLine();
            //var res = num.Where(n => n > 5);//6,7,9
            //Console.WriteLine(res);
            //排序
            //var res = num.Order(n =>n);
            //Console.WriteLine(res);//升序
            //var res = num.OrderByDescending(n =>n);
            //Console.WriteLine(res);//降序

            //对元素进行操作
            //var res = num.Select(x => x * 2);
            //var res = num1.Select(x => x * 2);

            //first/firstordefault
            //int s = num.First(1);//拿到第一条；找不到，抛出异常
            //Console.WriteLine(s);
            //num.FirstOrDefault(2)//找不到返回0

            //count计数
            //num.Count(x => x > 3);

            ////去重
            //num.Distinct()

            // //判断是否存在
            // num.Any(x => x > 2);//只要有满足就返回true
            #endregion

            #region 聚合函数
            //Count总数量，Sum求和，Average平均数，Max最大值，Min最小值
            //int count = list.Count();
            //Console.WriteLine(count); // 6

            //int sum = list.Sum(item => item["salary"]);

            #endregion

        }
    }
}
