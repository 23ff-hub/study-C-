namespace homeword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, dynamic>> list = new() {
    new Dictionary<string, dynamic>(){
        ["name"] = "zs",
        ["age"] = 29,
        ["isMan"] = true,
        ["isSingle"] = true,
        ["salary"] = 4200
    },
    new Dictionary<string, dynamic>(){
        ["name"] = "ls",
        ["age"] = 20,
        ["isMan"] = false,
        ["isSingle"] = true,
        ["salary"] = 3400
    },
    new Dictionary<string, dynamic>(){
        ["name"] = "ww",
        ["age"] = 19,
        ["isMan"] = true,
        ["isSingle"] = false,
        ["salary"] = 6000
    },
    new Dictionary<string, dynamic>(){
        ["name"] = "zl",
        ["age"] = 14,
        ["isMan"] = false,
        ["isSingle"] = true,
        ["salary"] = 2000
    },
    new Dictionary<string, dynamic>(){
        ["name"] = "sq",
        ["age"] = 35,
        ["isMan"] = true,
        ["isSingle"] = false,
        ["salary"] = 7000
    },
    new Dictionary<string, dynamic>(){
        ["name"] = "zb",
        ["age"] = 27,
        ["isMan"] = false,
        ["isSingle"] = true,
        ["salary"] = 2900
    },
};

            // 作业1
            // Find: 要求查找年龄小于20的

            dynamic age = list.Find(i => { return i["age"] < 20; });


            //Console.WriteLine(list[0]["age"]);

            // FindLast: 要求查找年龄大于25的

            dynamic age1 = list.FindLast(i => { return i["age"] > 20; });

            // FindAll: 找出性别男的

            dynamic isMan = list.Find(i => { return i["isMan"] == true; });

            // FindIndex: 找出薪水大于5000

            dynamic salary = list.Find(i => { return i["salary"] > 5000; });

            // FindLastIndex: 找出薪水小于3000

            dynamic salary1 = list.FindLastIndex(i => { return i["salary"] < 3000; });

            // Exists: 判断是否有薪水大于5000

            dynamic salary2 = list.Exists(i => { return i["salary"] > 5000; });

        // ForEach: 输出每个的 名字-年龄-薪水

        //dynamic info = list.ForEach(n => { Console.WriteLine($"{n["name"]}-{n["name"]}-{n["name"]}"); });

        // ConvertAll: 映射得到一个所以薪水的list

        //TrueForAll: 判断是否都成年

        // IndexOf

        // LastIndexOf

        //作业2: 封装一个函数 接收一个字符串; 返回一个字典,键是字符串的每个字符,键值是这个字符在字符串中出现的次数
        //string str(string str3 , Dictionary<string, int> dict2) 
        //    {
        //        Dictionary<string, int> dict1 = new Dictionary<string, int>()
        //        {
        //            [$"{str3[0]}"] = str3.Length
        //        };

        //        return dict2;
        //    }

        //    Dictionary<string, int> dict6 = new Dictionary<string, int>();
        //    string str2 = "hello";
        //    str(str2, dict6);
            //Console.WriteLine(str2[0]);
        }
    }
}
