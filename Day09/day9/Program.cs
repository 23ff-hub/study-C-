using System;
using System.Threading.Channels;

namespace day9
{
    internal class Program
    {
        //定义委托
        delegate int Num(int num);
        static void Main(string[] args)
        {
            #region 委托

            //他是一个函数的容器
            //其他变量存int，string等，委托变量存方法
            //委托变量存函数，可以被赋值、当做参数传给其他方法，也可以放到list里面
            //定义要存进去的方法
            //普通变量只能存一个值，但委托可以存多个方法函数。用 `+` 号连起来，一调用，全执行
            //int age(int age1) { return age1;};
            //int day(int day1) { return day1;};

            ////使用
            //Num n = age;
            //Console.WriteLine(n(18));
            //n += day;
            //Console.WriteLine(n(7));
            ////多播
            //n = age;
            //n += day;
            //Console.WriteLine(n(7));
            #endregion

            #region 函数参数
            //可变数量参数
            //params` 可变参数：允许调用方法时，传入任意个数同类型参数，编译器自动把这些参数打包成数组。
            //定义函数 可以实现任意个数字的求和
            //var getSum = (params int[] args) =>
            //{
            //    int sum = 0;
            //    foreach (var item in args) sum += item;
            //    return sum;
            //};

            //Console.WriteLine(getSum(1));
            //Console.WriteLine(getSum(1, 2));
            //Console.WriteLine(getSum(1, 2, 3));
            //Console.WriteLine(getSum(1, 2, 3, 4));
            //var fn = (int n1, int n2, params int[] args) =>
            //{
            //    //Console.WriteLine(n1 + n2);
            //    foreach (var item in args) Console.Write(item + " ");
            //    Console.WriteLine();
            //};

            //fn(10, 20);
            //fn(10, 20, 30);
            //fn(10, 20, 30, 40);

            //ref 和 out
            //C# 默认方法参数是**按值传递**，传递的是数据副本，方法内修改副本，不会影响外部原始变量。
            //在参数前添加 `ref`，代表** 按引用传递**：
            //方法接收外部变量的内存地址，参数 `x` 和外部变量 `num` 指向** 同一块内存**，方法内修改参数，直接改动外部原始变量。
            //void DoubleIt(ref int x)
            //{
            //    x = x * 2;
            //}
            //int num = 5;
            //DoubleIt(ref num);//带类型传参
            //Console.WriteLine(num);//10

            //参数是用来向外输出数据，**方法内部必须给out参数赋值 * *。
            //void GetNameAndAge(out string name, out int age)
            //{
            //    name = "小明";
            //    age = 20;
            //}

            //string n;
            //int a;
            ////GetNameAndAge(out n, out a);
            //Console.WriteLine($"{n} 的年龄是 {a}");

            //总结
            //out和ref都是让外部能对值进行操作，不用return，不用抛出
            #endregion

            #region 元组
            //它是** 轻量级、高性能** 的数据结构

            //作用：**把多个不同 / 相同类型的值打包成一个复合对象 * *。
            //优势：不需要专门定义 class / struct，书写简洁，可读性强。

            //// 打包4个不同类型数据
            //var a = (1, true, 3.14, "C#");

            ////// 使用 Item序号 访问成员
            //Console.WriteLine(a.Item1); // 1
            //Console.WriteLine(a.Item4); // C#

            //////元组是可变的（可修改）
            //a.Item1 = 99;
            //Console.WriteLine(a.Item1); // 99

            //var person = (Id: 101, Name: "李逵", Age: 33);
            //Console.WriteLine(person.Id);
            //Console.WriteLine(person.Name);
            //Console.WriteLine(person.Age);
            #endregion

            #region List高级方法
            //Find：找第一个满足条件的元素
            //Find(方法)
            List<int> list = [1,3,4,5,7];
            //int num = list.Find(i => { return i > 5; });
            //Console.WriteLine(num);//7

            //FindLast：找最后一个满足条件的元素
            //int lastNum = list.FindLast(i=>{ return i >1; });
            //Console.WriteLine(lastNum);//7

            //FindAll：找所有满足条件的元素
            //List<int> allNum = list.FindAll(i => { return i > 2; });
            //Console.WriteLine(string.Join(",",allNum));//3,4,5,7

            //FindIndex：找第一个满足条件的元素下标
            //int index = list.FindIndex(i => { return i == 3; });
            //Console.WriteLine(index);//1

            //FindLastIndex：找最后一个满足条件的下标
            //int lastIndex = list.FindLastIndex(i => {  return i % 2 == 0; });
            //Console.WriteLine(lastIndex);//2

            //Exists：判断是否有满足条件的元素
            //bool res = list.Exists(i => {  return i == 1; });
            //Console.WriteLine(res);//true

            //TrueForAll：判断是否所有元素都满足条件
            //bool res = list.TrueForAll(i => { return i == 1; });
            //Console.WriteLine(res);//false

            //ForEach：遍历
            //list.ForEach(n => Console.WriteLine(n));

            //ConvertAll：将List中每个元素都返回新元素组成新List
            //List<int> newList = list.ConvertAll(item =>
            //{
            //    //Console.WriteLine(item);
            //    return item / 2;
            //});
            //Console.WriteLine(string.Join(",", newList));

            //RemoveAll：删除所有满足条件的元素，返回删掉的个数, 删除原list

            //int newList = list.RemoveAll(x => x == 1);
            //Console.WriteLine(newList);//1

            //Sort：排序
            //list.Sort((a, b) => b-a);
            //list.ForEach(n => Console.WriteLine(n));//降序
            //list.Sort((a, b) => a-b);
            //list.ForEach(n => Console.WriteLine(n));//升序
            #endregion
        }
    }
}
