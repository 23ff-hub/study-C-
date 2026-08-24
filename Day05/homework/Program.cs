using System.Diagnostics;
using System.Threading.Channels;

namespace ConsoleApp2
{
    public   shoping
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 通过id找歌曲作业
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

            //找id
            int singid = 0;
            foreach (Dictionary<string, dynamic> item in singerList)
            {
                if (item["singerName"] == singer)
                {
                    singid = item["singerId"];
                }
            }

            //通过id找歌曲
            List<dynamic> list1 = new List<dynamic>();
            foreach (Dictionary<string, dynamic> item in songList)
            {
                if (item["singerId"] == singid)
                {
                    list1.Add(item["songName"]);

                }
            }

            foreach (var item in list1) Console.WriteLine(item);
            #endregion

        }
    }
}
