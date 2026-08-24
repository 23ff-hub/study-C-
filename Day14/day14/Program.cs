namespace day14
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // 创建请求对象
            HttpClient hc = new HttpClient();
            //发送请求
            var response = await hc.GetAsync("https://uapis.cn/api/v1/saying");
            //读取响应内容
            string resStr = await response.Content.ReadAsStringAsync();
        }
    }
}
