# Day1

C#简介：是一款由微软开发的面向对像、类型安全的高级编程语言。

特点：多范式，类型安全、跨平台、内存管理。

应用领域：后端、桌面应用、云原生、游戏开发。

## 1.下载与安装

官网：[地址](https://visualstudio.microsoft.com/zh-hans/)

选择community社区版本，免费开源。

开发包选择`.NET`即可。

## 2.项目创建

## 3.文件介绍

## 4.代码架构介绍

## 5.基础语法

### 注释

```C#
//单行注释
/*
    多行注释
    多行注释
*/
折叠代码
#region 注释
#endregion
```



### 打印输出

```C#
//单行输出
Console.Write("hello word");
//换行输出
Console.WriteLine("hello word");
//回车输入完
Console.ReadLine();
//输入完结束
Console.ReadKey();
//占位符
Console.WriteLine($"{数据}");
```



### 数据类型

```C#
//整数
int num = 0;
//浮点数
double f = 3.14159226;
float f1 = 0.09f;
//布尔
bool b = true;
```

### 变量

概念：程序内存储数据的容器。

```C#
// 程序告诉计算机 需要再内存中开辟一个空间 来存储数据 ===> 定义变量
// 语法: 类型 变量名;
// 语法: 类型 变量名 = 值;
// int n;
// int num = 180; 
// 定义好变量后 说明了 变量中可以存储的数据类型, 那么该变量就只能存储该类型数据,否则报错
// int num = "180"; // 报错

// 变量中存储的数据是 可变的
//int num = 180;
//Console.WriteLine(num);
//num = 200;
//Console.WriteLine(num);

/*
 * 变量的命名规则
    - 变量名由 数字字母下划线组成
    - 不可以数字开头
    - 严格区分大小写
    - 不能关键字当做变量名
        + 关键字: 语言层面已经使用了的名字
            - 比如: int, false,true .....
    变量命名规范:
        - 变量命名尽量语义化
            + 看到变量名 就大概知道 变量的数据是干嘛的
        - 多单词变量名 遵守 驼峰写法
            + 除了第一个单词后续每个单词首字母大写
 */
//int 123n; // 报错
//int n123;  
//int n = 10;
//int N = 20;
//Console.WriteLine(n);
//Console.WriteLine(N);
//int int;  // 报错

//string name = "Tom";
//int age = 18;
//// 字符串的插值输出: $"{变量}"    在{} 中可以识别变量 及简单的运算
//Console.WriteLine($"我是{name},今年{age}岁,明年{age+1}岁");

//// = 是赋值符号，作用是将右边数据放入左边容器内，执行顺序从右向左
//int num = 10;

//string userName = "jessica";
//int userAge = 18;
```



### 数学运算符

```C#
//符号：+ - * / %(求余/取模)
int num1 = 10;
int num2 = 3;
int res1 = num1 + num2;
int res2 = num1 - num2;
int res3 = num1 * num2;
int res4 = num1 / 5;
int res5 = num1 % num2;
Console.WriteLine(res1); // 13
Console.WriteLine(res2); // 7
Console.WriteLine(res3); // 30
Console.WriteLine(res4); // 2
Console.WriteLine(res5); // 1
//符号：+= -= *= /+ %= ++ --
//他加她把他们赋值给他
int num1 = 10;
int num2 = 3;
num1 += num2;
Console.WriteLine(num1); // 13

int num1 = 10;
int num2 = 3;
num1 -= num2;
Console.WriteLine(num1); // 7

int num1 = 10;
int num2 = 3;
num1 *= num2;
Console.WriteLine(num1); // 30

int num1 = 10;
num1 /= 5;
Console.WriteLine(num1); // 2

int num1 = 10;
int num2 = 3;
num1 %= num2;
Console.WriteLine(num1); // 1

int num1 = 3;
num1++;num1+1=>此时num1为3
Console.WriteLine(num1); // 4
num1--;num1-1=>此时num1为3
Console.WriteLine(num1); // 3
++num1;num1=num+1=>此时num1为4
Console.WriteLine(num1); // 4
--num1;num1=num-1=>此时num1为2
Console.WriteLine(num1); // 3
```



### 数学对象

```C#
Math.PI
Math.Abs()
Math.Pow()
Math.sqrt()
Math.Round()
Math.Floor()
Math.ceiling()   
Math.sin(弧度)
Math.cos(弧度)
Math.tan(弧度)
角度=  弧度* 180/pi
```

### 随机数

```C#
// 定义一个随机数
var r = new Random();
//Random.Next(整数类型)
Random.Next(n);
Random.Next(n,m)//n-m
Random.NextDouble()//0-1的浮点数
```




