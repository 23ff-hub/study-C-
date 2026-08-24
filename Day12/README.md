# Day12

## 一、回调函数

定义：让函数能够灵活变动数据结果，可以通过函数里调用函数

```C#
 //我们要如何去让我们的判断的值可以灵活更改呢，那么我们可以把我们的条件封装成一个函数
 List<int> add(int num, Func<int, bool> p)
 {
     List<int> list = new List<int>();
     if (p(num))
     {
         list.Add(num);
     }
     return list;
 }

 Console.WriteLine("请输入要添加的数");
 int add1 = int.Parse(Console.ReadLine());
 add(add1, p => p > 5);
```



## 二、面向对象

### 1、概念

面向、对象编程，简称OOP（Object-Oriented Programming），他具有3大特性：封装性、继承性、多态。

我们之前的编程习惯，属于面向过程编程，简称POP（Procedure-Oriented Programming），每实现一个功能，我们更加注重其中实现的过程。

面向对象编程，让我们从宏观上思考整个项目，不再局限于实现每个功能。是一种编程思想的升华，是一种超脱的、高级的编程思想。

例：

面向过程思想：

下班回家，我们需要吃饭，想吃土豆丝，我们就去菜店买土豆，然后先削皮，用菜刀切成片，再切成丝，然后用水洗一洗，洗到没有淀粉，然后烧过起油，放入佐料葱姜蒜，撒点十三香，佐料爆出香味，倒入土豆丝，翻炒到所有土豆丝发热后，撒盐，翻炒到干锅，倒入酱油，继续翻炒到土豆丝软化，撒入少许白糖，翻炒到有些粘性了，撒些鸡精，翻炒到鸡精消融，出锅。开吃。

总结：要吃到美味的土豆丝，需要自己亲力亲为，重点把握做菜的每个细节。

面向对象思想：

下班回家，我们需要吃饭，想吃土豆丝，告诉保姆，我要吃土豆丝。等保姆做好以后，开吃。

总结：要吃到美味的土豆丝，不用亲力亲为，重点找好保姆即可。

通过对比，我们发现，面向对象确实要比面向对象更加高级，类似于一个屌丝跟富豪的区别。所以说面向对象是更加高级的编程思想。

我们之前的编程思想：当做一个案例的时候，需要根据结果，分析实现效果的每个步骤，重点关注每个步骤的实现过程以及其中的逻辑。

面向对象编程思想：当做一个案例的时候，找到对应的对象，使用其中的数据，调用其中的方法即可。

### 2、类的创建

学习面向对象编程，首先需要认识类。类是一种数据结构，他可以包含数据成员和函数成员。数据成员包括各种类型的数据；函数成员包括函数、运算符、方法、属性等。这就体现了面向对象编程的封装性。

类是一种数据类型，代表现实生活中的种类，类是对一群具有相同特性或者行为的事物的一个统称，是抽象的，不能直接使用，他里面的特征叫属性，行为叫方法。类相当于一个事物的的模板，负责创建整个对象。

```C#
public class 类名{
    
}
```

类中声明属性：

```C#
public class 类名
    public 类型 名称{get; set;}//get获取、set设置随机
 	public 类型 名称{get;}//只读
}
```

### 3、实例化

类和对象是两个不同的概念，类决定了对象的类型和模板，但不是对象本身。我们可以将对象看作是基于类创建的实体，所以对象也称为类的实例。

使用new关键字进行实例化，一个类可以实例化多个对象，对象可以访问类中定义的属性和方法。

```C#
Animal Bird = new Animal();//new实例化Bird、他是非静态属性，要通过实例化来调用里面的方法和属性等
Console.WriteLine(Bird.Name); // 初始没有值
Bird.Name = "鸟";
Console.WriteLine(Bird.Name); // 鸟
Bird.Run(); // 鸟在跑，描述：

Animal Cat = new Animal();
Console.WriteLine(Cat.Name); // 初始没有值
Cat.Name = "猫";
Console.WriteLine(Cat.Name); // 猫
Cat.Run(); // 猫在跑，描述：
```

## 三、访问修饰符

非静态

- public：公共的，类内部外部都能访问

  调用要通过实例化对象进行调用，只属于上级类进行管理

- protected：受保护的，当前类里面能访问

  调用要通过实例化对象进行调用只能在本级类里使用，只属于上级类进行管理，如果要在外部类里访问只有通过在本级类里定义函数以参数的形式，在外部访问函数进行使用或改写

- private：私有的，当前类内部能访问

  同protected

- internal：内部的，只有当前项目能访问

  静态

  static：静态的，可以配合上面几个修饰符使用，静态的属性和方法不能使用实例对象调用，只能由类名调用

## 四、构造函数

每个类，都有构造函数，我们不写，这个构造函数就是隐形的，我们也可以自己定义。

我们在实例化对象的时候，系统会自动调用构造函数。

我们可以在创建类的时候，给类添加构造函数，给属性进行初始化赋值。

构造函数的名称跟类名相同，没有返回值

- 用处：初始化对象or数据

- 特点：默认是有一个无参数的构造方法

- 构造方法就是“打包好的套餐”。你要什么，一次性说清楚，拿到手就是完整的、直接能用的，不用自己再动手组装。

  ### 构造方法的定义

```C#
Class Program
{
    static void Main()
    {
       CtorMethod ctr = new CtroMethod(); 
    }
    //构造方法
    Class CtroMethod
    {
        public CtroMethod()
        {
            //无参数的构造方法
            testCtorMrthod();
        }
        
        public void testCtorMrthod()
        {
            Console.WriteLine("构造方法")
        }
        
    }

}
```

### 构造方法的使用

```C#
// 1. 定义一个"手机"类
class Phone
{
    public string Brand;   // 品牌
    public int Price;      // 价格

    // 2. 写构造方法
    public Phone(string brand, int price)
    {
        Brand = brand;     // 把你传进来的品牌存起来
        Price = price;     // 把你传进来的价格存起来
    }

    public void ShowInfo()
    {
        Console.WriteLine($"品牌：{Brand}，价格：{Price}元");
    }
}

// 3. 在别的地方创建对象并使用
class Program
{
    static void Main()
    {
        // 创建对象时，直接传参数
        Phone myPhone = new Phone("华为", 5999);

        // 直接用，不用再单独赋值了
        myPhone.ShowInfo();  // 输出：品牌：华为，价格：5999元
    }
}
```

### 析构方法/继承

#### 虚方法virtual

- 虚方法就是父类给子类留的一个“钩子”：父类自己有一套默认做法，但允许子类按自己的需要“改写”这套做法。
- 父类的做法（虚方法）：先放油 → 炒鸡蛋 → 放西红柿 → 放盐。
  你的做法（重写）**：先放油 → 炒鸡蛋 → 放西红柿 → 放盐 → **再加一点糖**（你改写了最后一步）。

```C#
class Animal
{
    // 虚方法：父类有默认实现，子类可以改
    public virtual void Speak()
    {
        Console.WriteLine("动物叫");
    }
}

class Dog : Animal
{
    // 重写：把父类的"动物叫"改成"汪汪"
    public override void Speak()
    {
        Console.WriteLine("汪汪");
    }
}

class Cat : Animal
{
    // 重写：改成"喵喵"
    public override void Speak()
    {
        Console.WriteLine("喵喵");
    }
}

// 使用：
Animal a1 = new Dog();
a1.Speak();  // 输出：汪汪（虽然是Animal类型，但实际是Dog，执行Dog的版本）

Animal a2 = new Cat();
a2.Speak();  // 输出：喵喵
```

### 抽象方法/多态

- 抽象方法就是父类只定“规矩”（方法名和参数），但不干活（没有方法体），强制子类必须自己把活干了。

- 想象公司老板（父类）定了个规定：

  > **“每个员工都必须会‘干活’（Work），但具体怎么干，我不管，你们自己看着办。”**

  - **老板的抽象方法**：只写了 `void Work();`（必须有个干活的方法），但里面是空的，啥都没写。
  - **程序员子类**：必须实现 `Work()`，里面写“写代码”。
  - **会计子类**：必须实现 `Work()`，里面写“做账”。

  谁不实现就编译报错，**强制你必须干**。

```C#
// 抽象类（父类）
abstract class Animal
{
    // 抽象方法：没有方法体，以分号结尾，强制子类重写
    public abstract void Speak();
}

// 子类：狗
class Dog : Animal
{
    // 必须重写 Speak，不然编译报错
    public override void Speak()
    {
        Console.WriteLine("汪汪");
    }
}

// 子类：猫
class Cat : Animal
{
    // 必须重写 Speak，不然编译报错
    public override void Speak()
    {
        Console.WriteLine("喵喵");
    }
}

// 使用：
Animal a1 = new Dog();
a1.Speak();  // 输出：汪汪

Animal a2 = new Cat();
a2.Speak();  // 输出：喵喵
```

