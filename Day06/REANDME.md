# Day6

## 上节回顾

### 数组

数组的定义

特点：固定长度，数据类型一致，元素可修可查

```C#
//标准写法
类型[] 变量名 = new 类型[长度];
类型[] 变量名 = new (){};
//简写
类型[] 变量名 = {}；
类型[] 变量名 = []；
```

### 集合

集合的定义

特地：元素支持增删改查，线程安全，扩展能力强

```C#
//线性列表
List<类型> 变量名 = new List<类型>(长度);
List<类型> 变量名 = new List<类型>{};
//简写
List<类型> 变量名 = [];
/************************************************/
字典
Dictionary<类型，类型> 变量名 = new Dictionary<类型类型>();
Dictionary<类型，类型> 变量名 = new Dictionary<类型类型>(){};
//简写
Dictionary<类型，类型> 变量名 = new (){};
```

### 方法

```c#
.add
.addRange
.insert
.indexOf/LastIndexOf
.Remove
.RemoveAll
.RemoveAt
.chear
.ContainKey
.Contain
//扩展
//会更改原数据
list.Sort()//升序
list.Sort((a,b)=>b.CompareTo(a))//降序
Array.Sort(arr)//升序
Array.Reverse(arr)//降序
//不更改原数据
list.OrderBy(x=>x).ToList();//升序
list.OrderByDescending(x=>x).ToList();//降序
list.Distinct().ToList();//去重
new HashSet<类型>(list).ToList();//去重
arr.Distinct().ToArray();//去重
new HashSet<类型>(arr).ToArray();//去重
```

## 字符的方法

字符串的定义

特定：长度不变，只读型

```C#
//读取
string str = "hello word";//长度10
Console.WriteLine(str[0]);//h
str[0] = "s";//会报错
```

### null

null定义：空的，里面可以装数组、List、字典、字符串、对象

```C#
  string str1 = "";
  string str2 = null;
  List<int> list = null;

  int? num= null;//允许为null
    string str = "hello word"
    str.length;//11
    string.IsNullOrEmpty("")//true
    string.IsNullOrEmpty(null)//true
```

### ToUpper / ToLower

```C#
  //转换大小写
  string str3 = "hello word";
  string str4 = str3.ToUpper();
  string str5 = str3.ToLower();
  Console.WriteLine(str4);//HELLO WORD
  Console.WriteLine(str5);//hello word
```

### Substring

```C#
 //截取，一部分字符
 string str6 = "hello word";
 string s6 = str6.Substring(2);
 Console.WriteLine(s6);//llo word
 string s7 = str6.Substring(0,5);
 Console.WriteLine(s7);//hello
```

### IndexOf / LastIndexOf

```C#
//查找文字、找不到返回-1
string str7 = "hello word";
int s8 = str7.IndexOf("h");
Console.WriteLine(s8);//0
int s9 = str7.LastIndexOf("h");
Console.WriteLine(s8);//0
```

### Contains / StartsWith / EndsWith

```c#
//判断包含文字，开头和结尾
string str = "hello word";
Console.WriteLine(str.Contains("hello"))//true
Console.WriteLine(str.StartsWith("hello"))//true
Console.WriteLine(str.EndsWith("hello"))//false
```

### Replace

```C#
//替换、删除
string str = "hello word";
Console.WriteLine(str.Replace("word","world"));//hello world
```

### Trim / TrimStart / TrimEnd

```c#
string str = " hello word ";
Console.WriteLine(str.Trim());//hello word
Console.WriteLine(str.TrimStart());// hello word 3
Console.WriteLine(str.TrimEnd());// hello word3
```

### Split

```C#
//分割字符串
string str = "hello,word,world";
string str = "hello word world";

string[] arr =str.Split(",");//[hello,word,world];
string[] arr = str.Split(" ");//[hello word world];
```

### Equals

```C#
拼接、对比
string str = "hello word";
string str1 = "hello words";
bool res = s1.Equals(s2);//false
bool res1 = s1.Equals(s2,StringComparison.OrdinalIgnoreCase);//true
```

### Insert(下标，内容)

在指定下标位置插入文字

### PadLeft / PadRight

```C#
//给字符串左/右边填充指定的符号填满指定的长度
string num = "123"
string res = num.PadRight(5,'0');//12300
int num1 = 123；
string res1 = num1.ToString().PadRight(5,'0');//12300
```

### string.Join / string.Concat

```C#
//将多个字符串拼接成一个大字符串
string str = "1,2";
string str1 = "3,4";
string str2 = string.Concat(str, str1);//1,2,3,4
//将数组或list转换成string并按指定符号拼接
string[] arr = {"1","2","3"};
 Console.WriteLine(string.Join(",",arr));
 List<string>  list = ["1","2","3"];
 Console.WriteLine(string.Join(",",list));
```

## 正则表达式

### 提取

```C#
//Match匹配到字符并返回匹配到的值
 string str = "aba";
 string reg = @"a";
 Console.WriteLine(Regex.Match(str,reg));//匹配到字符并返回a
 Match res = Regex.Match(str, reg);
 Console.WriteLine(res.Value);//a
```

### 验证

```C#
//isMatch匹配并返回bool值
 string str = "abc";
 string str1 = "bnm";
 Console.WriteLine(Regex.IsMatch(str,reg));//true
 Console.WriteLine(Regex.IsMatch(str1,reg));//false
```

### 替换

```C#
 //匹配并替换
 string str = "abc";
 Console.WriteLine(Regex.Replace(str,reg,"e"));//ebc
```

| 符号  | 含义    |
| --- | ----- |
| .   | 任意字符串 |

```C#
 //.
 string str = "abc";
 string s = @".";
 Console.WriteLine(Regex.Match(str,s));//a匹配任意一个字符
 Console.WriteLine(Regex.IsMatch(str,s));//true
 Match ss = Regex.Match(str,s);
 Console.WriteLine(ss.Value);//a
```

| 符号  | 含义        |
| --- | --------- |
| \d  | 任意一个数字    |
| \D  | 任意一个非数字字符 |

```C#
   //\d
   string str = "abc1";
   string s = @"\d";
   Console.WriteLine(Regex.Match(str, s));//1匹配任意一个数字
   Console.WriteLine(Regex.IsMatch(str, s));//true
   Match ss = Regex.Match(str, s);
   Console.WriteLine(ss.Value);//a
```

| 符号  | 含义               |
| --- | ---------------- |
| \w  | 任意一个字母、数字、下划线    |
| \W  | 任意一个非字母、数字、下划线字符 |

```C#
  //\w
  string str = "a_bc1";
  string s = @"\w";
  Console.WriteLine(Regex.Match(str, s));//a任意一个字母、数字、下划线
  Console.WriteLine(Regex.IsMatch(str, s));//true
  Match ss = Regex.Match(str, s);
  Console.WriteLine(ss.Value);//a
```

| 符号  | 含义        |
| --- | --------- |
| \s  | 一个空格      |
| \S  | 任意一个非空格字符 |

```C#
  //\s
  string str = "a_ bc1";
  string s = @"\s";
  Console.WriteLine(Regex.Match(str, s));//一个空格
  Console.WriteLine(Regex.IsMatch(str, s));//true
  Match ss = Regex.Match(str, s);
  Console.WriteLine(ss.Value);// 
```

| 符号    | 含义                                      |
| ----- | --------------------------------------- |
| [字符]  | 中括号中的任意一个字符 |
| [^字符] | 非中括号中的任意一个字符                            |

```C#
  string str = "a_ bc1";
  string s = @"[a-z]";
  Console.WriteLine(Regex.Match(str, s));//a中括号中的任意一个字符
  Console.WriteLine(Regex.IsMatch(str, s));//true
  Match ss = Regex.Match(str, s);
  Console.WriteLine(ss.Value);// a
```
