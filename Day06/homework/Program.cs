using System.Text.RegularExpressions;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string str = "你好小米请不要抽烟喝酒";
            ////string s = str.Replace("抽烟", "0");
            ////Console.WriteLine(s);
            //string[] str1 = ["抽烟","喝酒"];
            ////string newS = "";
            //foreach (string str2 in str1) 
            //{
            //    string newStr = "";
            //    //for (int i = 0; i < str2.Length; i++) newStr += "*";
            //    str = str.Replace(str2, "**");

            //}
            //Console.WriteLine(str);
            ////Console.WriteLine(str);

            //string str3 = "you love i";
            //string str4 = "";

            //string[] arr = str3.Split(" ");

            //List<string> list = new List<string>();

            //foreach (string s in arr) list.Add(s);

            //list.Reverse();

            //foreach (string str5 in list)
            //{
            //    string l = str5.Substring(0, 1).ToUpper();
            //    string r = str5.Substring(1).ToLower();
            //    str4 += l + r;
            //}

            //Console.WriteLine(str4);


            //-手机号
            string phone = @"^1[1-9]\d{9}&";
            string num = "1234567891234";
            Console.WriteLine(Regex.Match(phone, num));
            //- qq号
            string qq = @"^[1-9]/d{4,9}&"
            string q = "1234567891"
            Console.WriteLine(Regex.Matxh(q,qq));
            //- 邮箱号
            string email = @"^[A-Za-z]\w{3,4}\@\.[A-Za-z]{3,4}$";
            string e = "tai@.com"
            Console.WriteLine(Regex.Match(e, email));
            //- 提取一句话中的所有工资
            string str = "我的工资20000，你的工资3000";
            string money = @"^\d+";
            string newstr = Regex.Replace(str, money);
            foreach (var item in newstr) Console.WriteLine(item.Value);
            //- 提取一句话中所有的中文姓名
            string name = "小明 小马 小花";
            string place = @"([\u4e00-\u9fa5]){2}";
            
            //- 替换所有多余空格
            string name = "小明 小马 小花";
            string place = @"?\s+";
            Console.WriteLine(Regex.replace(name, place));
            //- 身份证号码
            string info = "123456789123456789";
            string infos = @"^[1-9]/d{16}/[Xx0-9]";
            Console.WriteLine(Regex.Match(info,infos))
            //- 密码强度检测：强中弱（字母、数字、特殊符号）

        }
    }
}
