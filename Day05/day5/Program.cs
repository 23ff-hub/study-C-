namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 排序与冒泡
            //List<int> list = new List<int>() {1,2,3,3,3,4,5,5};

            ////第一层循环得到list的每个元素
            //for (int i = 0; i<list.Count; i++) 
            //{
            //    //第二层循环在提前查找到下一个元素
            //    for (int j = i+1; j<list.Count; j++) 
            //    {
            //        //判定条件第一层循环与第二层循环元素对比
            //        if (list[i] == list[j])
            //        {
            //            //如果相同则移除，后一个相同的元素
            //            list.RemoveAt(j);
            //            //j=i+1，长度不够会造成塌陷
            //            j--;
            //        }
            //    }
            //}


            //foreach(int i in list) Console.WriteLine( i );

            //int a = list.LastIndexOf(8);
            //Console.WriteLine(a);

            ////第一层循环得到list的每个元素
            //for (int i = 0; i < list.Count; i++)
            //{
            //重后往前找如果有多个相同的数后面的数的索引不等于前面的索引
            //    int index = list.LastIndexOf(list[i]);
            //
            //    if (list.LastIndexOf(list[i]) != i) 
            //    {
            //        list.RemoveAt(index);
            //    }
            //}
            //foreach (int i in list) Console.WriteLine(i);


            //List<int> list = new List<int>() { 5, 4, 3, 2, 1 };

            //for (int j = 0; j < list.Count - 1; j++)
            //{
            //    //将第一个抓取到的元素比较结束
            //    for (int i = 0; i < list.Count - 1-j; i++)
            //    {
            //        //交换一次
            //        if (list[i] > list[i + 1])
            //        {
            //            int temp = list[i];
            //            list[i] = list[i + 1];
            //            list[i + 1] = temp;
            //        }
            //    }
            //}
            //foreach (int i in list) Console.Write(i);

            #endregion

            
        }
    }
}
