using System.Text.Json;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //作业：

            //定义一个类，用于处理图书管理系统的数据。

            //属性：

            //-数据文件路径
            //- JSON序列化配置项

            //方法：

            //-新增数据：强制要求 ==> 将list写入文件中
            //- 编辑数据
            //- 删除数据
            //- 查询所有数据
            //- 根据图书名称查询当前图书数据：强制要求

            //图书数据：
            //            List<Dictionary<string, dynamic>> data = new List<Dictionary<string, dynamic>>(){
            //    new Dictionary<string, dynamic>(){
            //        ["name"] = "三国演义",
            //        ["author"] = "罗贯中",
            //        ["isBorrow"] = true/false, // false表示还在书库中，true表示外借
            //        ["id"] = 0~1之间的随机小数,
            //        ["mark"] = "言情、武侠",
            //        ["price"] = 56.09 // 价格
            //    },
            //    。。。
            //};
            BookFunction addBook = new BookFunction("./book.json",

                new JsonSerializerOptions
                {
                    WriteIndented = true,// JSON序列化时候美化
                    AllowTrailingCommas = true, // JSON反序列化时候允许 最后出现逗号
                }

                );           

            string str = "";
            while (true) 
            {

                Console.WriteLine("=============图书管理系统==============");
                Console.WriteLine("1.新增书籍");
                Console.WriteLine("2.编辑书籍");
                Console.WriteLine("3.删除书籍");
                Console.WriteLine("4.查询所有书籍");
                Console.WriteLine("0.退出");
                 str = Console.ReadLine();
                switch(str) 
                {
                    case "1":
                        addBook.add();
                        //addBook.Count++;
                        break;
                    case "2":
                        addBook.editBook();
                        break;
                    case "3":
                        addBook.delBook();
                        break;
                    case "4":
                        addBook.LookBook();
                        break;
                    case "0":break;
                    default: Console.WriteLine("输入有误请重新输入"); break;
                }
            }
        }
    }
}
