using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace VRRSystem
{
    internal class ReturnCar
    {
        private string Path { get; } = "./RecordCar.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            // 在JSON序列化的时候中文不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };
        public void returnCar()
        {
            Console.WriteLine("请输入你租的车辆id");
            int recordid = int.Parse(Console.ReadLine());
            Console.WriteLine("还车成功");
            
        }
    }
}
