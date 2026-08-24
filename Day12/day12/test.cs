using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12
{

    public class Test
    {
        //声明属性
        //访问修饰符
        //public:公开的，外部可调用
        //private:私有的，外部不可以直接调用，得通过创建一个公开函数，进行获取
        //protected:受保护的
        //internal：内部的，只在项目内使用
        public string Name { get; set; }
        protected int Age { get; set; }
        private string Ip { get; set; }
        internal string IsMan { get; set; }
        //创建一个类
        public void print()
        {
            Name = "小米";
            Age = 18;
            Ip = "江西";
            IsMan = "男";
            Console.WriteLine($"你好：{Name}");
            Console.WriteLine($"你多少岁：{Age}");
            Console.WriteLine($"你那里的：{Ip}");
            Console.WriteLine($"性别：{IsMan}");
            Console.WriteLine("hello");
        }
        //定义一个构造函数
        //public Test(string name,int age1,string Ip1,string IsMan1)
        //{
        //    Name = name;
        //    Age = age1;
        //    Ip = Ip1;
        //    IsMan = IsMan1;
        //}
    }
}
