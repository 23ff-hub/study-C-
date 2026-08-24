namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //装修房间：参数1，圆的半径，计算圆的面积，每平方米收费200元，返回装修总价。计算这个半径的圆装修一半需要多少钱？
            //double mj = 0;
            //double money = 0;
            //Console.WriteLine("请输入半径");
            //int x = int.Parse(Console.ReadLine());
            //double sort(int x)
            //{
            //    mj = x * x * 2 * Math.PI;
            //    money = mj * 200 / 2;
            //    return money;
            //}
            //Console.WriteLine($"{sort(x):F2}元");

            //计算字符在字符串中出现的次数：参数1字符串，参数2某个字符，函数统计次数，并返回。
            //string str = "413121";
            //char s = '1';
            int count = 0;
            //foreach (char str2 in str) 
            //{
            //    if(str2 == s) 
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            //int statistics( string str,char s ,int count) 
            //{
            //    foreach (char str2 in str)
            //    {
            //        if (str2 == s)
            //        {
            //            count++;
            //        }
            //    }
            //    return count;
            //}
            //Console.WriteLine(statistics("413121",'1',0));

            //计算一个整型数组中，最小值第一次出现的下标。
            int[] arr = [2, 3, 1];
            int arr1 = arr.Min();
            int index = 0;
            int index1 = Array.indexOf(arr1, index1);
            foreach (int i in arr)
            {
                if (arr1 == i)
                {
                    index = arr[i];
                }
            }
            Console.WriteLine(index);

            int arr3(int[] arr, int arr1, int index)
            {
                foreach (int i in arr)
                {
                    if (arr1 == i)
                    {
                        
                        index = index1;
                    }
                }
                return index;
            }

            Console.WriteLine(arr3(arr, arr1, index));

        }
    }
}
