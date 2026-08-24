# Day2

## 数组

### 数组的定义

数组是一块固定大小、连续内存的存储区域，用于存储相同类型的元素

- Length 属性不可改变。

- 索引访问速度最快。

- 支持矩形数组和交错数组处理表格数据（如矩阵、棋盘、图像像素）或空间坐标。

```C#
//创建一个数组
int[] num = new int[2];// 长度为2，value为0；
int[] num1 = { 1, 2 };
int[] num2 = [1,2];
//查
num1[0]//1
//改
num[0] = 100;
```

### 数组的方法

```C#
//Count数组的个数
num.Count();
```

### 多维数组

```C#
//定义：int[,] matrix = new int[3, 4];3行4列二维数组
//定义：int[,,] matrix = new int[3, 4,3];x,3,y,4,z,3列三维数组
// 1. 声明并初始化（2行3列）
int[,] grid = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
int[,,] grid1 = new int[,,] { {{1,2},{3,4}}, {{5,6}，{7,8}} };
// 2. 获取总长度（所有元素个数 = 2*3=6）
int total = grid.Length;//6
int total1 = grid1.Length;//2*2*2=8
 // 3. 获取特定维度长度
 int rows = grid.GetLength(0); // 结果是 2（行数）0:维度一行x
 int cols = grid.GetLength(1); // 结果是 3（列数）1：维度二列y，2：维度三z
 Console.WriteLine(rows);
 Console.WriteLine(cols);
```

### 交错数组

```C#
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
```

## 集合

### 集合的定义

动态存储和管理一组数据的容器类，位于 System.Collections 和 System.Collections.Generic 命名空间，元素个数可自动增减。

### List

```C#
创建一个list列表
List<int> list = new List<int>();
List<int> list = []
//增
list.Add(1);//给数组末尾新增数据
list.AddRange(集合);//给数组末尾新增多个数据
list.Insert(要插入下标的位置，要插入的数据);/// 注意: 新增数据的下标 范围 0 到 集合.Count
//删
list.Remove(内容/list[1]);//将List中指定的数据删除
list.RemoveAt(2);//将List中指定下标的数据删除
list.RemoveRange(小标,个数);//删除数组中指定的多个数据
list.Clear();//清空所有数据
//改
list[0] = 数据;
//查
list.IndexOf(元素);//查找第一次匹配到的内容返回下标/-1
list.LastIndexOf(元素);//查找最后一次匹配到的内容返回下标/-1
list.Contains(元素);//查找匹配内容返回bool值
lis.GetRange(下标,个数);//返回一个list集合
```

### Dictionary

```C#
//创建一个字典
Dictionary<类型，类型> 字典名 = new Dictionary<类型,类型>();
new Dictionary<string,dynamic>()
{
    [key] = val,
    {key = val}
}
// 访问
变量名[键名]
// 修改
变量名[键名] = 值
// 新增
变量名.add()
变量名[键名] = 值
// 删除
变量名.Remove(键名)
// 获取数量
变量名.Count
// 了解
变量名.TryGetValue(键名,out dynamic val) 
// 清空
变量名.Clear()  
```

## 作业

点名器（随即下标）包含技术：list，随机数

商品信息查找 包含技术：list、字典
