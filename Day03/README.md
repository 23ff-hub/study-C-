# Day3

## 一,运算符

### 1、关系运算

符号：`> >= < <= == !=`

也叫比较运算符,关系运算的结果是**布尔值

```C#
// 关系运算符,比较运算符 ===> 运算结果一定是布尔值
// > >= < <= == !=
Console.WriteLine("请输入第一个数字");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine("请输入第二个数字");
int n2 = int.Parse(Console.ReadLine());
//bool res = n1 > n2;
//bool res = n1 < n2;
//bool res = n1 >= n2;
//bool res = n1 <= n2;
//bool res = n1 == n2; // 两值相等才为true
bool res = n1 != n2;  // 不相等才为true

Console.WriteLine(res);
```

### 2、逻辑运算

符号：`&& || ! & |`

短路运算和非短路运算的区别。

`&&`表示并且，连接两个条件，表示两个条件同时成立，整体才算是成立

例：小红想做车模，车模条件年龄16~22

`||`表示或者，连接两个条件，表示两个条件只要有1个成立，整体就算成立

例：小明择偶标准：要么资产在300w以上，要么颜值大于9.5。输入小红的资产和颜值

```C#
 Console.WriteLine("请输入的年龄");
 int age = int.Parse(Console.ReadLine());
 bool res = age > 16 && age < 22;
 Console.WriteLine(res);

Console.WriteLine("请输入资产");
int money = int.Parse(Console.ReadLine());
Console.WriteLine("请输入颜值");
double yz = double.Parse(Console.ReadLine());
bool res = money > 300 || yz > 9.5;
Console.WriteLine(res);

 // !取反 
bool isMan = false;
isMan = !isMan;
Console.WriteLine(isMan);

 // &不断路
int n = 0;
int num = 1;
bool res = n > num & n < num++;
Console.WriteLine(res);
Console.WriteLine(num);

 // |不断路
int n = 0;
int num = 1;
bool res = n < num | n < num++;
Console.WriteLine(res);
Console.WriteLine(num);
 
```

### 短路与不短路

```C#
短路
只要前面的条件已经能确定最终结果，后面代码直接不执行。
比如说：bool res = false && Func();//左边false整体一定是falseFunc不执行叫做短路
bool res = false || Func();//左边false整体一定是falseFunc不执行叫做短路
不短路
不管前面结果是什么，两边表达式都会执行完再，算结果
```



## 二、分支语句

判断也会有很多种，比如：

* 考试成绩大于60，及格
* 考试成绩大于60，及格，否则，不及格
* 考试成绩如果大于60并且小于80，及格，如果大于80并且小于90，良好，如果大于90，优秀

根据上述几种情况，我们把判断分为三种，根据结果只做一个件事情的，叫**单分支**，做两件事情的，叫做**双分支**，做多件事情的，叫**多分支**

### 2、单分支

语法:

```C#
if(条件表达式){
    当条件表达式的结果为true的时候要执行的代码
}
```

### 3、双分支

```C#
if(条件表达式){
    当条件表示式的结果为true的时候要执行的代码
}else{
    当条件表达式的结果为false的时候要执行的代码   
}
```

### 四、switch分支

1、switch多路判断

语法：

```C#
switch(变量){
    case 值1:
        执行的代码块
    break;
    case 值2:
        执行的代码块
    break;
    。。。
    default:
        执行代码块
    break;
}
```

使用说明：

1. break表示当前分支执行后就结束switch的运行，后续swtich中的代码不再运行
2. default可以理解为判断语句中的else
3. case理解为if来判断这个变量是否等于某个值

### 2、switch简写

```C#
Console.WriteLine("输入成绩：");
double score = double.Parse(Console.ReadLine());
if (score >0 && score <=100) {
    string res = score switch
    {
        //表达式 => 结果,  // 表达式中变量省略
        // _ => 结果  _ 表示default
        >= 90 => "A",
        >= 80 => "B",
        >= 70 => "C",
        >= 60 => "D",
        _ => "F"
    };
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("输入有误");

}
```

### 五、三元运算

```C#
条件?条件成立时得到的结果:条件不成立时结果;
```

```C#
// 三元运算
int a = 1;
int b = 2;
int max = 0;
//if (a > b) {  max = a; } else { max = b; }
//Console.WriteLine(max);

max = a > b ? a : b;
Console.WriteLine(max);
```

## 作业：

* 账号密码验证（练习分支嵌套）：账号规定是"admin"，密码规定是"123456"。让用户输入账号和密码，判断账号和密码是否正确，账号和密码都正确就输出登入成功；账号不对，就输出账号不存在；密码不对，就输出密码错误。
* 选择菜单（add/edit/del）执行操作（练习多分支和switch）：提示用户选择菜单（add/edit/del），判断输入的是add，就输出新增成功；输入的是edit，就输出编辑成功；输入的是del，就输出删除成功。
* 会员打折满1000打9折，普通用户满2000打9.5折（练习多分支和分支嵌套）：让用户输入自己的类型（VIP/USER）和消费金额，如果是VIP，判断消费金额是否达到1000，如果达到了，就输出他应该支付的金额，如果没有达到，也输出他应该支付的金额；如果是USER，判断消费金额是否达到2000，如果达到了和没有达到，都输出他应该支付的金额。
* 通过月份判断季节（练习switch的穿透写法）：用户输入月份，判断月份如果是3、4、5月份，就输出这是春季；如果是6、7、8月份，就输出这是夏季；如果是9、10、11月份，就输出这是秋季，如果是12、1、2月份，就输出这是冬季。
* 快递运费（练习多分支）：输入快递重量，单位是Kg，如果重量小于1Kg，输出快递费10元；如果重量在1Kg~5Kg之间，就输出快递费20元；如果重量超过5Kg，就输出快递费50元。
* 会员等级优惠（练习多分支和switch）：输入会员等级，等级是3~5的整数，判断等级如果是5，输出终身免运费；等级是4，输出每月可领优惠券；等级是3，输出购物打9折，否则没有福利。
* 自动售货机选商品（练习多分支和switch）：输入商品编号整数，1就输出已购买可乐；2输出已购买雪碧；3输出已购买矿泉水；否则输出无此商品。
* 速度分级（练习多分支）：输入当前速度，如果在0~30，输出低速通过；30~60输出中速通过；60~100输出高速通过；100~120输出超速通过。
