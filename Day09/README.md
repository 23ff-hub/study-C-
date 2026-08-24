# Day9

## 委托

### 委托的定义

他是一个函数的容器
其他变量存int，string等，委托变量存方法
委托变量存函数，可以被赋值、当做参数传给其他方法，也可以放到list里面

```C#
      //定义要存进去的方法
      int age(int age1) { return age1;};
      int day(int day1) { return day1;};

      //使用
      myAge age2 = age;
      Console.WriteLine(age(18)); 
       age2 = day;
      Console.WriteLine(day(7));
```

## 函数参数

### 可变数量参数

params 可变参数/集合：允许调用方法时，传入任意个数同类型参数，编译器自动把这些参数打包成数组

```C#
  定义函数 可以实现任意个数字的求和
  var getSum = (params int[] args) =>
  {
      int sum = 0;
      foreach (var item in args) sum += item;
      return sum;
  };

  Console.WriteLine(getSum(1));
  Console.WriteLine(getSum(1, 2));
  Console.WriteLine(getSum(1, 2, 3));
  Console.WriteLine(getSum(1, 2, 3, 4));
  var fn = (int n1, int n2, params int[] args) =>
  {
      //Console.WriteLine(n1 + n2);
      foreach (var item in args) Console.Write(item + " ");
      Console.WriteLine();
  };

  fn(10, 20);
  fn(10, 20, 30);
  fn(10, 20, 30, 40);
```

### ref 和out

out和ref都是让外部能对值进行操作，不用return，不用抛出

```C#
//不返回值，但我又要改变里面的值，且改变的值
void DoubleIt(ref int x)
 {
     x = x * 2;
 }
 int num = 5;
 DoubleIt(ref num);//带类型传参
 Console.WriteLine(num);//10

  void GetNameAndAge(out string name, out int age)
  {
      name = "小明";
      age = 20;
  }

  string n;
  int a;
  GetNameAndAge(out n, out a);
  Console.WriteLine($"{n} 的年龄是 {a}");
```

### 元组

```C#
    //它是** 轻量级、高性能** 的数据结构

    //作用：**把多个不同 / 相同类型的值打包成一个复合对象 * *。
    //优势：不需要专门定义 class / struct，书写简洁，可读性强。

    // 打包4个不同类型数据
    var a = (1, true, 3.14, "C#");

    //// 使用 Item序号 访问成员
    Console.WriteLine(a.Item1); // 1
    Console.WriteLine(a.Item4); // C#

    ////元组是可变的（可修改）
    a.Item1 = 99;
    Console.WriteLine(a.Item1); // 99

    var person = (Id: 101, Name: "李逵", Age: 33);
    Console.WriteLine(person.Id);
    Console.WriteLine(person.Name);
    Console.WriteLine(person.Age);
```

