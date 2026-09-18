using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace VRRSystem
{
    internal class RecordCar
    {
        private string Path { get; } = "./RecordCar.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            // 在JSON序列化的时候中文不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };
        public void recordAdd() 
        {
            Console.WriteLine("请输入id");
            int recordid = int.Parse(Console.ReadLine());
            Console.WriteLine("要租的车辆id");
            int carId = int.Parse(Console.ReadLine());
            Console.WriteLine("要租的客户id");
            int cusId = int.Parse(Console.ReadLine());
            DateTime dateTime = DateTime.Now;
            List<recordCar> recordCars = new();
            //CustomerManger customerManger = new CustomerManger();
            List<PublicClass> publicClasses = new();
            if (File.Exists("./Customer.json"))
            {
                var oldObj = File.ReadAllText("./Customer.json");
                publicClasses = JsonSerializer.Deserialize<List<PublicClass>>(oldObj);
            }
            //PublicClass c1 = publicClasses.Find(item => item.CarStatus);
            //if (!c1.CarStatus)
            //{
            //    Console.WriteLine("无");
            //}
            PublicClass c = publicClasses.Find(item => item.Id == recordid);

            if (File.Exists(Path))
            {
                var oldList = File.ReadAllText(Path);
                recordCars = JsonSerializer.Deserialize<List<recordCar>>(oldList);
            }
            List<Customer> customers = new();
            if (File.Exists("./Customer.json")) 
            {
                var oldObj = File.ReadAllText("./Customer.json");
                customers = JsonSerializer.Deserialize<List<Customer>>(oldObj);
            }
            Customer i = customers.Find(item=>item.Id == cusId);

            //CarManger carManger = new CarManger();
         

            recordCar dic = new(i.Id,carId,c.Id,dateTime.ToString());
            recordCars.Add(dic);
            var newObj = JsonSerializer.Serialize<List<recordCar>>(recordCars, JsonOpt);
            File.WriteAllText(Path,newObj);
            Console.WriteLine("租车成功");
        }
    }
}
