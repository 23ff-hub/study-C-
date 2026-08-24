# Day7

## 一、类型转换

语法：

```C#
(int)value // 转浮点数的时候等同于向下取整，不能转字符串
(double)value // 只能转整数
int.TryParse(str, out int result); // 字符串安全转int，得到成功与否的布尔值，结果为result
ToString() // 转字符串，可用于格式化数字和日期，不能转null，会报错 ==> Convert.ToString(value) 安全的转字符串
ToArray() // List/集合转数组
ToList() // 数组/序列转List
```

## 二、数字转汉字

