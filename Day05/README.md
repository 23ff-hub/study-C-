# Day5

## 一、List去重

List中的数据是可以重复的，去重就是将重复的数据删掉，让List中保留唯一的数据。

`List<int> ints = [1, 3, 3, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];`

思路1：遍历每个元素，让这个元素跟他后面的每一个元素都做比较，相等就删掉

```C#
for (int i = 0; i < ints.Count; i++)
{
    // ints[i]
    // 从 i + 1 开始循环
    for (int j = i + 1; j < ints.Count; j++)
    {
        // 判断 ints[i] 和ints[j] 如果相同则删除
        if (ints[i] == ints[j])
        {
            ints.RemoveAt(j);
            j--; // 解决删除后 索引塌陷问题
        }
    }
}
// 验证去重效果
foreach (int n in ints) Console.WriteLine(n);
```

## 二、冒泡排序

概念：让每相邻的两个元素比较大小，如果不满足顺序，就交换他俩的位置

```C#
List<int> ints = [5, 3, 4, 6, 7, 8, 9, 1, 2];
for (int j = 0; j < ints.Count - 1; j++)
{
    for (int i = 0; i < ints.Count - 1 - j; i++)
    {
        if (ints[i] > ints[i + 1])
        {
            int tmp = ints[i];
            ints[i] = ints[i + 1];
            ints[i + 1] = tmp;
        }
    }
}

foreach (int n in ints) Console.WriteLine(n);
```

## 作业

1、通过歌手查找歌曲集合

```C#
List<Dictionary<string, dynamic>> singerList = new List<Dictionary<string, dynamic>>
{
    new Dictionary<string, dynamic>
    {
        {"singerId", 1001},
        {"singerName", "周杰伦"},
        {"genre", "流行"}
    },
    new Dictionary<string, dynamic>
    {
        {"singerId", 1002},
        {"singerName", "林俊杰"},
        {"genre", "华语流行"}
    },
    new Dictionary<string, dynamic>
    {
        {"singerId", 1003},
        {"singerName", "邓紫棋"},
        {"genre", "流行、摇滚"}
    },
    new Dictionary<string, dynamic>
    {
        {"singerId", 1004},
        {"singerName", "薛之谦"},
        {"genre", "抒情流行"}
    },
    new Dictionary<string, dynamic>
    {
        {"singerId", 1005},
        {"singerName", "毛不易"},
        {"genre", "民谣流行"}
    }
};

List<Dictionary<string, dynamic>> songList = new List<Dictionary<string, dynamic>>
{
    new Dictionary<string, dynamic>
    {
        {"songId", 10001},
        {"singerId", 1001},
        {"songName", "青花瓷"},
        {"duration", 239}
    },
    new Dictionary<string, dynamic>
    {
        {"songId", 10002},
        {"singerId", 1001},
        {"songName", "发如雪"},
        {"duration", 253}
    },
    new Dictionary<string, dynamic>
    {
        {"songId", 10003},
        {"singerId", 1001},
        {"songName", "东风破"},
        {"duration", 215}
    },
    new Dictionary<string, dynamic>
    {
        {"songId", 1004},
        {"singerId", 3002},
        {"songName", "不为谁而作的歌"},
        {"duration", 296}
    },
    new Dictionary<string, dynamic>
    {
        {"songId", 1005},
        {"singerId", 1002},
        {"songName", "背对背拥抱"},
        {"duration", 262}
    }
};
 // 用户输入歌手姓名：周杰伦/林俊杰 ==> 通过这个姓名将这个人唱的所有歌曲都找出来
 Console.WriteLine("请输入歌手姓名：");
 string singer = Console.ReadLine(); // 周杰伦
 // 先根据歌手名字 找到对应的 字典
 int singerId = 0; // 歌手ID

 // 遍历歌手集合  根据歌手名字 获取歌手ID
 foreach (Dictionary<string, dynamic> item in singerList)
 {
     // item 就是循环中 歌手列表的 数据字典
     if (item["singerName"] == singer) singerId = item["singerId"];
 }

 // 遍历歌曲集合  根据拿到的歌手id 去判断获取对应的歌曲字典并 存储到新list中
 var singerSongs = new List<Dictionary<string, dynamic>>();
 foreach (Dictionary<string, dynamic> item in songList)
 {
     if (item["singerId"] == singerId) singerSongs.Add(item);
 }

 // 遍历歌手的歌曲
 foreach (dynamic item in singerSongs) {
     Console.WriteLine(item["songName"]);
 }
```


