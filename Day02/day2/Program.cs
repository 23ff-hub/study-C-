using System.Collections.Generic;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //数组
            //数组是一块固定大小、连续内存的存储区域，用于存储相同类型的元素
            //Length 属性不可改变。
            //索引访问速度最快。
            //支持矩形数组和交错数组处理表格数据（如矩阵、棋盘、图像像素）或空间坐标。
            int[] num = new int[2];// 长度为2，value为0；
            int[] num1 ={ 1, 2 };// 长度为2；
            int[] num2 = [1,2];// 长度为2；

            //查询，打印
            Console.WriteLine(num[1]);//0

            //修改，打印
            num1[1] = 200;
            Console.WriteLine(num1[1]);//200

            //Count数组的个数
            Console.WriteLine(num1.Count()); 

            //矩形数组
            //定义：int[,] matrix = new int[3, 4];3行4列二维数组
            //定义：int[,,] matrix = new int[3, 4,3];x,3,y,4,z,3列三维数组
            // 1. 声明并初始化（2行3列）
            int[,] grid = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            // 2. 获取总长度（所有元素个数 = 2*3=6）
            int total = grid.Length;

            // 3. 获取特定维度长度
            int rows = grid.GetLength(0); // 结果是 2（行数）0:维度一行x
            int cols = grid.GetLength(1); // 结果是 3（列数）1：维度二列y，2：维度三z
            Console.WriteLine(rows);
            Console.WriteLine(cols);

            // 4. 修改和访问（使用逗号分隔索引）
            grid[0, 1] = 99;    // 改：第一行第二列设为 99
            int val = grid[1, 2]; // 查：第二行第三列，值是 6

            // 5. 遍历（嵌套 for 循环）
            for (int i = 0; i < grid.GetLength(0); i++) // 行
            {
                for (int j = 0; j < grid.GetLength(1); j++) // 列
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
            // 输出：
            // 1 99 3
            // 4 5 6

            //交错数组
            //定义：int[][] jagged = new int[3][];
            // 1. 声明（先定义行数，再分别给每行初始化列数）
            int[][] jagged = new int[3][];
            jagged[0] = new int[2] { 1, 2 };      // 第1行有2列
            jagged[1] = new int[4] { 3, 4, 5, 6 };// 第2行有4列
            jagged[2] = new int[1] { 7 };         // 第3行有1列

            // 2. 访问（先取行，再取列）
            jagged[0][1] = 99;    // 改：第一行第二列改为 99
            int val1 = jagged[1][2]; // 查：第二行第三列，值是 5

            // 3. 遍历（注意：每行长度不同，用 Length 取当前行列数）
            for (int i = 0; i < jagged.Length; i++) // 行数
            {
                for (int j = 0; j < jagged[i].Length; j++) // 当前行的列数
                {
                    Console.Write(jagged[i][j] + " ");
                }
                Console.WriteLine();
            }
            // 输出：
            // 1 99
            // 3 4 5 6
            // 7


            //------------------------------------------------------------------------------


            //集合
            //动态存储和管理一组数据的容器类，位于 System.Collections 和 System.Collections.Generic 命名空间。
            //元素个数可自动增减

            //线性集合（有序列表）
            //元素按插入顺序存储，可通过索引访问
            List<string> names = new List<string> { "Alice", "Bob" };
            //List<string> names1 = [ "Alice", "Bob" ];
            names.Add("Charlie");          // 尾部添加
            names.Insert(1, "David");      // 索引1插入
            names.Remove("Bob");           // 按值删除
            string first = names[0];       // 索引访问
            Console.WriteLine(first);

            //键值对集合（字典）
            //通过 Key（键） 快速查找 Value（值），适合根据 ID、用户名等唯一标识查找数据。
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1001, "Alice");    // 添加
            students[1002] = "Bob";         // 或直接赋值
            string name = students[1001];   // 通过键查找

            // 安全查找（避免 KeyNotFoundException）
            if (students.TryGetValue(1003, out string? result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("未找到该学号");
            }

            //集合运算（去重 / 交集 / 并集）
            //元素唯一（自动去重），支持数学集合运算。

            HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 3, 3 }; // 自动去重 -> {1,2,3}
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

            set1.UnionWith(set2);   // 并集 -> {1,2,3,4,5}
            set1.IntersectWith(set2); // 交集 -> {3}

            bool exists = set1.Contains(2); // 快速判断是否存在

            /*
             你的数据需要怎么用？
                │
                ├─ 通过索引（位置）访问？
                │  ├─ 频繁在中间插入/删除 → LinkedList<T>
                │  └─ 否则 → List<T>（首选）
                │
                ├─ 通过键（Key）快速查找值？
                │  ├─ 需要按键排序输出 → SortedDictionary<TKey, TValue>
                │  └─ 否则 → Dictionary<TKey, TValue>（首选）
                    eg:商铺，里的商品管理利用list和dictionary
                    List<Dictionary> goods = new List<Listtionary>
                        {
                            new Dictionary<striong,dynamic>()
                             {
                                          }
                        }
                │
                ├─ 需要去重或集合运算（交集/并集）？
                │  ├─ 需要自动排序 → SortedSet<T>
                │  └─ 否则 → HashSet<T>（首选）
                │
                └─ 特殊访问顺序？
                   ├─ 后进先出（LIFO）→ Stack<T>
                   └─ 先进先出（FIFO）→ Queue<T>
             */

            List<int> numbers = new List<int> { 5, 2, 8, 1, 9 };

            // 筛选 + 排序 + 投影
            var result1 = numbers.Where(n => n > 3)      // 筛选大于3
                                .OrderBy(n => n)         // 排序
                                .Select(n => n * 2);     // 每个乘2
                                                         // 结果：{ 10, 16, 18 }

            //int[] arr = list.ToArray();        // 集合 → 数组
            //List<int> list2 = arr.ToList();    // 数组 → 集合

            //总结
            /*
             *  存固定数据 → 数组

                存动态列表 → List<T>

                键值对查找 → Dictionary<TKey, TValue>

                去重 / 集合运算 → HashSet<T>

                特殊顺序 → Stack<T> 或 Queue<T>
            */


        }
    }
}
