using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace homework
{
    internal class BookFunction
    {
        //public double Id { get; set; }
        //public int Count { get; set; }
        //public int Idx { get; set; }
        public JsonSerializerOptions Options { get; set; }
        public string Path { get; set; }
        public List<Dictionary<string, dynamic>> List { get; set; }

        public BookFunction(string path, JsonSerializerOptions jsonOption)
        {
            //初始化属性
            //List索引
            //Count = 0;
            //库存计数
            //Idx = 0;
            Path = path;
            Options = jsonOption;
            List = new List<Dictionary<string, dynamic>>();
        }

        #region 添加书籍功能
        public string add()
        {


            Console.WriteLine("要添加的书籍名称");
            string BookName = Console.ReadLine();
            Console.WriteLine("作者");
            string author = Console.ReadLine();
            Console.WriteLine("请输入书籍类型");
            string mark = Console.ReadLine();
            Console.WriteLine("请输入书籍价格");
            double money = double.Parse(Console.ReadLine());
            //bool isRepeal = List.Any(dict => dict != null && dict.ContainsKey("name") && dict["name"] == BookName);
            //List<Dictionary<string, dynamic>> newList = new List<Dictionary<string, dynamic>>();

            if (File.Exists(Path))
            {
                var oldList = File.ReadAllText(Path);
                List = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(oldList);
            }
            Random random = new Random();
            Dictionary<string, dynamic> dic = new Dictionary<string, dynamic>()
            {
                ["mark"] = mark,
                ["price"] = money,
                ["id"] = random.NextDouble(),
                ["isBorrow"] = true,
                ["name"] = BookName,
                ["author"] = author,

            };

            List.Add(dic);
            string json = JsonSerializer.Serialize(List, Options);
            File.WriteAllText(Path, json);
          

            return "添加成功";
        }
        #endregion

        #region 查询所有书籍
        public void LookBook()
        {
            
            if (File.Exists(Path))
            {

                var LookList = File.ReadAllText(Path);
                List = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(LookList);
            }
            foreach (var dict in List)
            {
                Console.WriteLine($"书名{dict["name"]}==作者{dict["author"]}==类型{dict["mark"]}==id{dict["id"]:F2}==价格{dict["price"]}");
            }
        }
        #endregion

        #region 删除书籍
        public string delBook()
        {
            //输入书名根据书名删除
            Console.WriteLine("请输入要删除的书名");
            string delName = Console.ReadLine();

            if (!File.Exists(Path))
            {
                return "目前没有图书可删";
            }

            var oldList = File.ReadAllText(Path);
            //Console.WriteLine(oldList);
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(oldList);
            int index = list.FindIndex(item => item["name"].ToString() == delName);
            if (index == -1) return "要删除的书籍不存在，请先添加";
            list.RemoveAt(index);
            List = list;
            string json = JsonSerializer.Serialize(List, Options);
            File.WriteAllText(Path, json);

            return "删除成功";
        }
        #endregion

        #region 编辑书籍
        public string editBook()
        {
            Console.WriteLine("请输入要编辑的书名的内容");
            string editName = Console.ReadLine();
            Console.WriteLine("1.修改作者名");
            Console.WriteLine("2.修改价格");
            string n = Console.ReadLine();
            if (!File.Exists(Path)) return "没有该书籍";
            var oldList = File.ReadAllText(Path);
            List<Dictionary<string, dynamic>> list = JsonSerializer.Deserialize<List<Dictionary<string, dynamic>>>(oldList);
            switch (n)
            {
                case "1":
                    Console.WriteLine("请输入要改的名字");
                    string str = Console.ReadLine();
                    int i = list.FindIndex(item => item["name"].ToString() == editName);
                    list[i]["author"] = str;
                    break;
                case "2":
                    Console.WriteLine("请输入要改的价格");
                    double b = double.Parse(Console.ReadLine());
                    int s = list.FindIndex(item => item["name"].ToString() == editName);
                    list[s]["price"] = b;
                    break;
            }

            List = list;
            string json = JsonSerializer.Serialize(List, Options);
            File.WriteAllText(Path, json);

            return "编辑成功";
        }
        #endregion




    }
}
