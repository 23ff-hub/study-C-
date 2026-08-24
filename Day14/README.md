# Day14

## 一、命名空间

命名空间是C#里的一种逻辑分组机制

用途：1、组织代码

​	    2、解决命名冲突问题

大白话讲就是：命名空间=文件夹，里面存放子文件

在一个项目中可以有多个命名空间，我们可以使用using进行导入命名空间

```C#
using y
using z
namespace x
{
    static void Main()
    {
    	new y();  
        new QQ.WW.CC();
    }    
}
namespace QQ
{

    namespace WW
    {
        class CC
        {

        }
    }
}
namespace y{}
```

## 二、结构体

结构体跟类很像，不同的地方在于结构体是值类型，类是引用类型；结构体不能继承别的类，也不能被别的类继承。

```	C#
// 坐标结构体
struct Point
{
    // 字段
    public int X;
    public int Y;

    // 普通方法
    public void Move(int offsetX, int offsetY)
    {
        X += offsetX;
        Y += offsetY;
    }

    // 返回数据的方法
    public double GetDistance()
    {
        return Math.Sqrt(X * X + Y * Y);
    }
}
```

## 三、异步代码

### 使用

```C#
//如果要执行异步操作
async Task
函数类型 async Task 函数(){}
Task ：定义一个异步任务
await ：等待任务执行完成，代码再执行
Task A = B();
await A;
Task A = B();
Task C = D();
await Task.WhenAll(A,B);
```

## 四、网络请求

```C#
// 创建请求对象
HttpClient hc = new HttpClient();
```

