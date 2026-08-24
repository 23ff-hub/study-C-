namespace day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //一、while循环结构
            //while (条件语句)
            //{
            //    条件成立重复执行的代码
            //}
            // 既然是循环，咱们需要设定几个条件，首先是从哪开始，每完成一次要进行计数，完成多少次停止。
            //int i = 1;
            //while (i <= 5)
            //{
            //    Console.WriteLine("我爱你!");
            //    i++; // i = i+1   
            //}

            //do while循环结构
            //do while 循环是while循环的变异体。
            //    循环流程相似，唯一不同的地方在于
            //    do while循环会**先执行一次 * *，不管条件是否成立，先执行一次，
            //    后面的流程和while循环一样。
            //int i = 1;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i > 10);

            //for循环结构
            //for (声明变量并赋初始值; 条件表达式; 每重复一次后变量的变化规律)
            //{
            //    重复执行的代码块
            //    }
            //# 在语法中的声明变量并赋初始值；
            //条件表达式可以限定重复在什么时候停止（当条件不成立的时候）；
            //通过每次重复变量的变化和条件表达式可以知道要重复多少次

            //continue关键字，可以跳过当前这次的循环，进入下一次的循环。
            // 循环控制 continue
            //for (var i = 1; i <= 5; i++)
            //{
            //    if (i == 3)
            //    {
            //        continue; // 跳过本次循环
            //    }
            //    Console.WriteLine(i);
            //}

            //break关键字，可终止循环，让整个循环结束。
            //for (var i = 1; i <= 5; i++)
            //{
            //    if (i == 3)
            //    {
            //        break; // 结束整个循环===>for的后续循环结束
            //    }
            //    Console.WriteLine(i);
            //}

            //专门遍历数组、List，foreach循环结构
            //foreach (元素类型 变量 in 集合)
            //{
            //    代码段;
            //}
            //foreach 遍历数组
            //int[] intArr = { 10, 20, 30, 40};
            //foreach (int item in intArr)
            //{
            //    // item表示 每次循环 从intArr中拿到的数据
            //    Console.WriteLine(item);
            //}

            // 数组数据求和
            //int[] intArr = { 10, 20, 30, 40 };
            //int sum = 0;
            //foreach (int item in intArr)
            //{
            //    // item表示 每次循环 从intArr中拿到的数据
            //    //Console.WriteLine(item);
            //    sum += item;
            //}
            //Console.WriteLine(sum);


            // foreach 遍历 List集合
            //List<string> strList = new List<string>() { "h", "e", "l", "l", "o" };
            //foreach (string a in strList) {
            //    Console.WriteLine(a);
            //}

            // 拼接 strList集合的数据
            //List<string> strList = new List<string>() { "h", "e", "l", "l", "o" };
            //string res = "";
            //foreach (string a in strList)
            //{
            //    //Console.WriteLine(a);
            //    res += a;
            //}
            //Console.WriteLine(res);

            // foreach 遍历字典
            //Dictionary<string, dynamic> userInfo = new Dictionary<string, dynamic>()
            //{
            //    ["name"] = "Tom",
            //    ["age"] = 5,
            //    ["gender"] = 1,
            //    ["hobby"] = "jerry",
            //};
            //foreach (var item in userInfo)
            //{
            //    // item 是每组数据
            //    Console.WriteLine(item);
            //}
        }
    }
}
