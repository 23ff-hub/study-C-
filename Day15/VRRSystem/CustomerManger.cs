using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace VRRSystem
{
    internal class CustomerManger
    {
        private string Path { get; } = "./Customer.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            // 在JSON序列化的时候中文不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };
        //添加客户
        public void CustomerAdd() 
        {
            //string IdCard,
            //string RegisterTime,
            //string Gender,
            //string CellPhone,
            //string FalseName
            Console.WriteLine("请输入要添加的客户名");
            string CustomerName = Console.ReadLine();
            Console.WriteLine("请输入要添加的客户性别");
            string Gender = Console.ReadLine();
            Console.WriteLine("请输入要添加的客户身份证号码");
            string IdCard = Console.ReadLine();
            Console.WriteLine("请输入要添加的客户手机号");
            string CellPhone = Console.ReadLine();
            Console.WriteLine("请输入要添加的客户座右铭");
            string FalseName = Console.ReadLine();
            DateTime data = DateTime.Now;
            List<Customer> Customers = new();
            if (File.Exists(Path)) 
            {
                var oldList = File.ReadAllText(Path);
                Customers = JsonSerializer.Deserialize<List<Customer>>(oldList);
            }
            Customer Cus = new(Customers.Count, CustomerName,IdCard,data.ToString(),Gender,CellPhone,FalseName);
            Customers.Add(Cus);
            var newList = JsonSerializer.Serialize<List<Customer>>(Customers,JsonOpt); 
            File.WriteAllText(Path, newList);
        }

        public void lookCustomer() 
        {
            List<Customer> Customers = new();
            if (!File.Exists(Path))
            {
                Console.WriteLine("空");
            }
            var oldList = File.ReadAllText(Path);
            Customers = JsonSerializer.Deserialize<List<Customer>>(oldList);
            foreach(var item in Customers) 
            {
                Console.WriteLine($"客户id:{item.Id} 客户姓名:{item.CustomerName} 身份证号码:{item.IdCard} 注册时间{item.RegisterTime} 性别:{item.Gender} 手机号:{item.CellPhone} 座右铭:{item.FalseName}");
            }
        }

        public void lookCustomerId() 
        {
            Console.WriteLine("请输入要添加的客户id");
            int Customerid =int.Parse(Console.ReadLine()) ;
            List<Customer> Customers = new();
            if (!File.Exists(Path)) Console.WriteLine("空");
            var oldList = File.ReadAllText(Path);
            Customers = JsonSerializer.Deserialize<List<Customer>>(oldList);
            Customer item = Customers.Find(items => items.Id == Customerid);
            //Console.WriteLine(item);
            Console.WriteLine($"客户id:{item.Id} 客户姓名:{item.CustomerName} 身份证号码:{item.IdCard} 注册时间{item.RegisterTime} 性别:{item.Gender} 手机号:{item.CellPhone} 座右铭:{item.FalseName}");
        }
    }
}
