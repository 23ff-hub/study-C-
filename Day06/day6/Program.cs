using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string方法
            //string str = "hello word world s s d d";//长度10
            //Console.WriteLine(str[0]);//h
            ////str[0] = "s";//会报错,因为他是只读的。
            //string[] s = str.Split(" ");
            //foreach (string s2 in s) 
            //{
            //    Console.WriteLine(s2);
            //}
            ////去重
            //string res =  string.Join(" ",str.Split(" ").Distinct());
            //Console.WriteLine(res);

            ////null
            ////null定义：空的，里面可以装数组、List、字典、字符串、对象
            //string str1 = "";
            //string str2 = null;
            //List<int> list = null;

            //int? num= null;//允许为null

            //转换大小写
            //string str3 = "hello word";
            //string str4 = str3.ToUpper();
            //string str5 = str3.ToLower();
            //Console.WriteLine(str4);//HELLO WORD
            //Console.WriteLine(str5);//hello word

            //截取，一部分字符
            //string str6 = "hello word";
            //string s6 = str6.Substring(2);
            //Console.WriteLine(s6);//llo word
            //string s7 = str6.Substring(0,5);
            //Console.WriteLine(s7);//hello

            //查找文字、内容
            //string str7 = "hello word";
            //int s8 = str7.IndexOf("h");
            //Console.WriteLine(s8);//0
            //int s9 = str7.LastIndexOf("h");
            //Console.WriteLine(s8);//0

            //判断是否包含字符
            //string str8 = "hello word";
            //bool a9 = str8.Contains("word");//true
            //bool a8 = str8.StartsWith("word");//false
            //bool a7 = str8.EndsWith("word");//true

            //string str = "hello word";
            //Console.WriteLine(str.Contains("hello"));//true
            //Console.WriteLine(str.StartsWith("hello"));//true
            //Console.WriteLine(str.EndsWith("hello"));//false

            //替换文字
            //string str = "hello word";
            //Console.WriteLine(str.Replace("word", "world"));//hello world

            //去除空格
            //string str = " hello word ";
            //Console.WriteLine(str.Trim());//hello word
            //Console.WriteLine(str.TrimStart());// hello word 3
            //Console.WriteLine(str.TrimEnd());// hello word3

            ////分割字符串
            //string str = "hello,word,world";
            //string str1 = "hello--word--world";

            //string[] arr = str.Split(",");//[hello,word,world]
            //string[] arr1 = str1.Split("-",StringSplitOptions.RemoveEmptyEntries);//[hello word world];去除空字符

            //PadLeft / PadRight
            //string num = "123";
            //string res = num.PadRight(5, '0');//12300
            //int num1 = 123;
            //string res1 = num1.ToString().PadRight(5, '0');//12300

            //string.Concat：将多个字符串拼接成一个大字符串
            //string str = "1,2";
            //string str1 = "1,2,3,";
            //string str2 = string.Concat(str, str1);
            //Console.WriteLine(str2);//1,21,2,3
            ////string a = "2";
            //string c = "3";
            //string d = string.Concat(a,c);
            //Console.WriteLine(d);

            //string.Join：将数组或List中的所有元素使用指定的连接符拼接成一个字符串
            //string[] arr = {"1","2","3"};
            ////Console.WriteLine(string.Join(",",arr));
            //List<string>  list = ["1","2","3"];
            //Console.WriteLine(string.Join(",",list));

            //PadLeft：给字符串左边填充指定的符号填满指定的长度
            //PadRight：给字符串右边填充指定的符号填满指定的长度
            //string str = "1";
            //Console.WriteLine(str.PadLeft(2,'0'));//01
            //Console.WriteLine(str.PadRight(3,'0'));//100

            #endregion

            #region 正则表达式
            //

            //定义语法
            //@"字符";

            //提取
            //Match匹配到字符并返回匹配到的值
            //string str = "aba";
            //string reg = @"a";
            ////Console.WriteLine(Regex.Match(str,reg));//匹配到字符并返回a
            ////Match res = Regex.Match(str, reg);
            ////Console.WriteLine(res.Value);//a

            ////验证
            ////isMatch匹配并返回bool值
            ////string str = "abc";
            ////string str1 = "bnm";
            ////Console.WriteLine(Regex.IsMatch(str,reg));//true
            ////Console.WriteLine(Regex.IsMatch(str1,reg));//false

            ////替换
            ////匹配并替换
            //string str = "abc";
            //Console.WriteLine(Regex.Replace(str,reg,"e"));//ebc

            //.
            //string str = "abc";
            //string s = @".";
            //Console.WriteLine(Regex.Match(str,s));//a匹配任意一个字符
            //Console.WriteLine(Regex.IsMatch(str,s));//true
            //Match ss = Regex.Match(str,s);
            //Console.WriteLine(ss.Value);//a

            //\d
            //string str = "abc1";
            //string s = @"\d";
            //Console.WriteLine(Regex.Match(str, s));//1匹配任意一个数字
            //Console.WriteLine(Regex.IsMatch(str, s));//true
            //Match ss = Regex.Match(str, s);
            //Console.WriteLine(ss.Value);//a

            //\w
            //string str = "a_bc1";
            //string s = @"\w";
            //Console.WriteLine(Regex.Match(str, s));//a任意一个字母、数字、下划线
            //Console.WriteLine(Regex.IsMatch(str, s));//true
            //Match ss = Regex.Match(str, s);
            //Console.WriteLine(ss.Value);//a

            ////\s
            //string str = "a_ bc1";
            //string s = @"\s";
            //Console.WriteLine(Regex.Match(str, s));//一个空格
            //Console.WriteLine(Regex.IsMatch(str, s));//true
            //Match ss = Regex.Match(str, s);
            //Console.WriteLine(ss.Value);// 

            //string str = "a_ bc1";
            //string s = @"[a-z]";
            //Console.WriteLine(Regex.Match(str, s));//a中括号中的任意一个字符
            //Console.WriteLine(Regex.IsMatch(str, s));//true
            //Match ss = Regex.Match(str, s);
            //Console.WriteLine(ss.Value);// a

            //string reg = @"a|b";
            //MatchCollection res = Regex.Matches("abc", reg);
            //Console.WriteLine(res[0]);
            //Console.WriteLine(res[1]);
            ////Console.WriteLine(res);
            ///

            //string reg = @"a|b";
            //MatchCollection res = Regex.Matches("abc", reg);
            //Console.WriteLine(res[0]);
            //Console.WriteLine(res[1]);

            //string reg = @"(\d{4})-(\d{2})-(\d{2})";
            //Match res = Regex.Match("2026-07-22", reg);
            //Console.WriteLine(res.Value); // 2026-07-22
            //Console.WriteLine(res.Groups[0]); // 2026-07-22
            //Console.WriteLine(res.Groups[1]); // 2026
            //Console.WriteLine(res.Groups[2]); // 07
            //Console.WriteLine(res.Groups[3]); // 22
            //Console.WriteLine(res.Groups.Count); // 4

            //string reg = @"(?:\d{4})-(?:\d{2})-(?:\d{2})";
            //Match res = Regex.Match("2026-07-22", reg);
            //Console.WriteLine(res.Value); // 2026-07-22
            //Console.WriteLine(res.Groups[0]); // 2026-07-22
            //Console.WriteLine(res.Groups[1]); // 
            //Console.WriteLine(res.Groups.Count); // 1
            #endregion
        }
    }
}
