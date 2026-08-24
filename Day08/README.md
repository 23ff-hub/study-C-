# Day8

## 一、函数

### 函数的概念

在我们开发的程序中，有时候，一段代码会多次被使用，如果这段代码能包装一个容器中，使用时就会方便很多。包装一段代码的程序就是**函数**。

例如：

​	手动洗衣服怎么洗？拿个盆，接水，放衣服，倒洗衣粉，洗，涮，拧干

​	挺费劲的，有没有简便的方法？

​	使用洗衣机，衣服放进去，倒上洗衣粉，按开关，一切就都搞定了。

再比如：

​	手工制作奶茶，要煮茶、加奶、放小料、调糖，步骤一大堆。
​	挺麻烦的，有没有简便的方法？
​	使用全自动奶茶机，选定小料、甜度，按下开关，一切就都搞定了。

大家思考一下：奶茶机内部，已经提前装好一整套制作奶茶的流程。 我们不需要知道机器里面怎么搅拌、怎么控温，只用给出要求，启动机器就行。

对应代码： 把一堆重复的步骤打包封装起来，**就是定义函数**； 启动奶茶机，**就是调用函数**； 我们选择珍珠、少糖这些设置，就是给函数传递**参数**； 最后机器送出一杯成品奶茶，就是函数的**返回值**。

### 定义函数

```C#
//函数的定义方式
//匿名函数/普通函数

//普通函数
//无返回值的函数
//大白话：干活只出效果，干完不给你返回数据。
//格式：修饰符 void 函数名(有参数/无参数) { 代码 }
//示例：打印东西、修改数据，不用拿结果
// 只打印，不给你返回任何数字/文字
  void PrintHello(int x)
  {
      Console.WriteLine(x);
  };
 PrintHello(2);
//有返回值函数/类型函数（int/ string / 自定义类等）
//大白话：干完活必须给你吐一个结果，调用时要用变量接住。
//格式：修饰符 数据类型 函数名(有参数/无参数){ return 结果; }
//必须写 return，否则报错
// 算加法，最后返回总和
int Add(int x)
{
    ConSole.WriteLine(x)
}
Add(3);

//匿名函数
//（x,y）=> x+y;//报错，他是匿名函数需要被接收
//无返回值接收
Action action = () => { Console.WriteLine("hello"); };
Action<int,int> action1 = (x,y) => { Console.WriteLine(x + y) ; };
action1(2, 3);

//有返回值
Func<int,int,int> addFun = (x, y) => x + y;
addFun(1, 2);
Console.WriteLine(addFun);

```

### 自定义函数类型

```C#
delegate 返回值类型 函数类型名称(参数类型 参数名, ...); // 必须放在命名空间内或类内部，不能放在方法内部
```

```C#
//匿名函数
(int a, int b) => 
{
  int c = a + b;
  return c;
};
//赋值
Fun<int,int,int> add = ( a, b) => 
{
  int c = a + b;
  return c;
};
//自定义函数类型
delegate int Add(int a ,int b);
Add jia = (int a,int b) =>
{
    int c = a+b;
    reture c;
}
Console.WriteLine(jia(1,2));
```

### 抛出数据

```C#
//返回值类型 函数(参数, .., out 类型 数据名) 
//{
    //给out抛出的变量进行赋值即可
//}
//函数(参数, ..., out 类型 变量名);
bool PrintCollection(string[] arr, char splitChar, out string joinStr)
{
    List<string> list = arr.ToList();
    joinStr = string.Join(splitChar, list);//joinStr == result
    return true;
}
bool isSuccess = PrintCollection(new string[] { "aa", "bb", "cc" }, '-', out string result);
Console.WriteLine(result);//aa-bb-cc
Console.WriteLine(isSuccess);//true
```

## 异常处理

### 调用后异常

```C#
     int[] arr = { 11, 22, 33 };
     Console.Write("输入数组下标：");
     int input = int.Parse(Console.ReadLine());
     try
     {
         int index = int.Parse(input);
         Console.WriteLine($"数组值：{arr[index]}");
     }
     catch (FormatException ex)
     {
         Console.WriteLine("输入的下标格式错误" + ex.Message);
     }
     finally
     {
         Console.WriteLine("");
     }
```

### 手动抛出异常

```C#
int[] arr = { 11, 22, 33 };
Console.Write("输入数组下标：");
int input = int.Parse(Console.ReadLine());
   if (input > 90) 
   {
       // 手动抛出异常，告知调用者错误原因
       throw new ArgumentException("数太大了！");
   }
```

