# Day4

## 一、while循环结构

### 1、语法

```C#
while(条件语句){
    条件成立重复执行的代码
}    
```

```C#
// 既然是循环，咱们需要设定几个条件，首先是从哪开始，每完成一次要进行计数，完成多少次停止。
int i = 1;
while(i <= 5)
{
    Console.WriteLine("我爱你!");
    i++; // i = i+1   
}
```

## 二、do while循环结构

do while 循环是while循环的变异体。

循环流程相似，唯一不同的地方在于do while循环会**先执行一次**，不管条件是否成立，先执行一次，后面的流程和while循环一样。

```C#
int i = 1;
do {
    Console.WriteLine(i);
    i++;
} while (i > 10);
```

```C#
int i = 1;
do
{
    Console.WriteLine(i);
    i++;
}
while (i <= 5);
```

## 三、for循环结构

1、语法和过程

```C#
for(声明变量并赋初始值; 条件表达式; 每重复一次后变量的变化规律){
    重复执行的代码块
}
# 在语法中的声明变量并赋初始值；条件表达式可以限定重复在什么时候停止（当条件不成立的时候）；通过每次重复变量的变化和条件表达式可以知道要重复多少次
```

执行的流程：

```C#
开始
  ↓
i = 1
  ↓
判断 i <= 5 ?
├─ false → 结束
└─ true  → 输出"我爱你"
             ↓
            i++
             ↓
          返回判断
```

## 四、循环中的关键字

### 1、continue

continue关键字，可以跳过当前这次的循环，进入下一次的循环。

```C#
// 循环控制 continue
for (var i = 1; i <= 5; i++)
{
    if (i == 3)
    {
        continue; // 跳过本次循环
    }
    Console.WriteLine(i);
}
```

### 2、break

break关键字，可终止循环，让整个循环结束。

```C#
 for (var i = 1; i <= 5; i++)
 {
     if (i == 3)
     {
         break; // 结束整个循环===>for的后续循环结束
     }
     Console.WriteLine(i);
 }
```

## 五、foreach循环结构

专门遍历数组、List。

语法：

```C#
foreach(元素类型 变量 in 集合)
{
    代码段;
}
```

```C#
//foreach 遍历数组
//int[] intArr = { 10, 20, 30, 40};
//foreach (int item in intArr)
//{
//    // item表示 每次循环 从intArr中拿到的数据
//    Console.WriteLine(item);
//}

// 数组数据求和
//int[] intArr = { 10, 20, 30, 40 };
//int sum = 0;
//foreach (int item in intArr)
//{
//    // item表示 每次循环 从intArr中拿到的数据
//    //Console.WriteLine(item);
//    sum += item;
//}
//Console.WriteLine(sum);


// foreach 遍历 List集合
//List<string> strList = new List<string>() { "h", "e", "l", "l", "o" };
//foreach (string a in strList) {
//    Console.WriteLine(a);
//}

// 拼接 strList集合的数据
//List<string> strList = new List<string>() { "h", "e", "l", "l", "o" };
//string res = "";
//foreach (string a in strList)
//{
//    //Console.WriteLine(a);
//    res += a;
//}
//Console.WriteLine(res);

// foreach 遍历字典
//Dictionary<string, dynamic> userInfo = new Dictionary<string, dynamic>()
//{
//    ["name"] = "Tom",
//    ["age"] = 5,
//    ["gender"] = 1,
//    ["hobby"] = "jerry",
//};
//foreach (var item in userInfo)
//{
//    // item 是每组数据
//    Console.WriteLine(item);
//}
```

## 六、循环嵌套

代码段中可以写循环代码，就会形成循环嵌套。

例：5个人，每个人都跑5圈

```C#
for (int j = 1; j <= 5; j++)
{
    //Console.WriteLine($"第{j}个人");
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine($"第{j}个人 跑第{i}圈");
    }
}
```

## 七、作业

1. 计算100以内偶数的和

2. 显示出1000-2000年中所有的闰年，并以每行四个数的形式输出

3. 输出一个倒三角形，如下![左上半三角形](https://upload-images.jianshu.io/upload_images/12363089-3df1e9ac5ab8b02c.png?imageMogr2/auto-orient/strip|imageView2/2/w/159/format/webp)

4. 用循环计算下面的结果
      1 - 1/2 + 1/3 - 1/4 + ... - 1/100

5. 求20以内所有数字的阶乘的和

6. 篮球从5米高的地方掉下来，每次弹起的高度是原来的30%，经过几次弹起，篮球的高度小于0.1米。

7. 有一个棋盘，有64个方格，在第一个方格里面放1粒芝麻重量是0.00001kg，第二个里面放2粒，第三个里面放4，棋盘上放的所有芝麻的重量

8. 某人在银行有50000元存款。银行每月都要收取服务费，存款大于5000元时每个月收取总额的5%，总额不大于5000元的时候不收服务费；假设这个人存了以后从来都不用，用循环计算银行要扣这个人的手续费能扣多少次？每次扣取后剩余多少钱？

9. 猴子摘桃，猴子摘了x个桃，每天吃一半，再多吃一个，第7天吃的时候剩下一个了，猴子摘了多少桃子？

10. 有个皮球，每次落地弹起都是高度的一半，如果从10米高的地方丢下，第十次弹起时，皮球总过经历了多少距离。
