namespace day7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //int num = 12;
            //double db = (double)num;
            //Console.WriteLine( db);
            //// 转浮点数的时候等同于向下取整，不能转字符串
            //double db1 = 12.3;
            //int num1 = (int)db1;
            //Console.WriteLine(num1);
            //string str = "hello";
            //bool num2 = int.TryParse(str, out int result);//只能将字符串转换为int类型，返回的值为bool

            //数据加密
            string text = "清风漫过湖畔，午间薄雾缓缓消散，夜色悄然而至，河水静静流淌，渡船缓缓靠岸，渡口游人往来，相逢知己相交，互换见闻感受，留心世间风情，记录山河晚报。";
            string salt = "7-16-30-38-49-52-63-70";
            //string str1 = "";
            ////第一步拿到索引
            //string[]arr = salt.Split("-");//字符串类型的数组
            ////通过索引拿到字符
            //foreach(string s in arr) 
            //{
            //    //将字符类型转换成整数类型
            //    int arr1 = int.Parse(s);
            //    //遍历到新的字符串
            //    str1 += text[arr1];
            //}
            //Console.WriteLine(str1);

            //通过文字找出密码
            //第一步定义一个存放密码的容器
            //string password = "";
            //List<int> password1 = [];
            //string word = "午夜渡口交换情报";
            ////第二步通过每一个字符去匹配text里相同文字的下标
            ////这里匹配我们可以用到indexof返回他的一个下标
            //foreach(char s in word) 
            //{
            //    int index = text.IndexOf(s);
            //    password1.Add(index);
            //}
            //password = string.Join("-", password1);
            //Console.WriteLine(password);

            //三、数字转汉字

            string[] arr = ["零", "壹", "贰", "叁", "肆", "伍", "陆", "柒", "捌", "玖"];
            // 创建单位数组
            string[] units = ["", "拾", "佰", "仟", "萬", "拾", "佰", "仟", "亿"];
            string result = "";

            Console.WriteLine("请输入你要转换的数字");
            string money  = Console.ReadLine();
            //Console.WriteLine(money.GetType);
            //Console.WriteLine(money[0]);

            //通过输入的数字，转换成int类型，当做成下标索引来取到我们要的值

            //int index = int.Parse(money);
            for (int i = 0; i < money.Length; i++) 
            {
                int indexs = int.Parse(money);
                List<int> arr1 = [];
                arr1.Add(indexs);
                //Console.WriteLine(index[0]);
                result += arr[arr1[i]];
            }
            Console.WriteLine(result);

        }
    }
}