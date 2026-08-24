using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace VRRSystem
{
    internal class CarManger
    {
        private string Path { get;} = "./Car.json";
        private JsonSerializerOptions JsonOpt { get; } = new JsonSerializerOptions
        {
            WriteIndented = true,
            AllowTrailingCommas = true,
            // 在JSON序列化的时候中文不变
            Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        };
       
        #region 添加车辆信息
        public String CarAdd() 
        {
            Console.WriteLine("请输入要添加的车牌号");
            string CarNum = Console.ReadLine();
            Console.WriteLine("请输入要添加的车辆类型（轿车、卡车、摩托车）");
            string CarType = Console.ReadLine();
            Console.WriteLine("请输入要添加的每小时的费用");
            string Money = Console.ReadLine();
            //初始化状态和id
            bool CarStatus = true;
            int Id = 0;
            //实例化公共属性
            List<PublicClass> CarList = new();
            //判断文件是否存在，做添加操作
            //存在
            if (File.Exists(this.Path))
            {
                var oldObj = File.ReadAllText(this.Path);
                CarList = JsonSerializer.Deserialize<List<PublicClass>>(oldObj);
            }
            //不存在
            
            PublicClass CarInfo = new(CarList.Count+1,CarNum,CarType,CarStatus,Money);
            CarList.Add(CarInfo);
            var newObj = JsonSerializer.Serialize(CarList,this.JsonOpt);
            File.WriteAllText(this.Path,newObj);
            return "添加成功";
        }
        #endregion

        #region 查看所有车辆信息
        public void lookCarAll() 
        {
            //判断车库是否存在
            if (!File.Exists(this.Path))Console.WriteLine("空");
            
            var oldObj = File.ReadAllText(this.Path);
            List<PublicClass> newCarList = JsonSerializer.Deserialize<List<PublicClass>>(oldObj);
            PublicClass statusStrs = newCarList.Find(item => item.CarStatus == true);
            string statusStr = statusStrs.CarStatus ? "空闲" : "已出租";
            newCarList.ForEach(item => Console.WriteLine($"ID:{item.Id}==车牌号:{item.CarNum}==车辆类型:{item.CarType}==小时费:{item.Money}==车辆状态:{statusStr}"));

        }
        #endregion

        #region 根据id查看一辆车的信息
        public void lookOneCar() 
        {
            if (!File.Exists(this.Path)) Console.WriteLine("空");

            var oldObj = File.ReadAllText(this.Path);
            List<PublicClass> newCarList = JsonSerializer.Deserialize<List<PublicClass>>(oldObj);
            Console.WriteLine("请输入要查找的id");
            int index = int.Parse(Console.ReadLine());
            PublicClass carObj = newCarList.Find(item => item.Id == index);
            if (carObj == null)
            {
                Console.WriteLine("没有车辆信息，请先添加");
                return;
            }
            string statusStr = carObj.CarStatus? "空闲" : "已出租";
            Console.WriteLine($"id:{carObj.Id} 车牌: {carObj.CarNum} 类型:{carObj.CarType} 状态:{statusStr} 时租费:{carObj.Money} ");
            
        }
        #endregion

        //查看所有空闲车辆
        public void lookNullCar() 
        {
            if (!File.Exists(this.Path)) Console.WriteLine("空");

            var oldObj = File.ReadAllText(this.Path);
            List<PublicClass> newCarList = JsonSerializer.Deserialize<List<PublicClass>>(oldObj);

            List<PublicClass> freeCar = newCarList.FindAll(item => item.CarStatus);
            if (freeCar.Count == 0)
            {
                Console.WriteLine("没有空闲车辆信息，请先添加");
                return;
            }

            foreach (PublicClass item in freeCar)
            {
                Console.WriteLine($"id : {item.Id}车牌 : {item.CarNum}类型 : {item.CarType}时租费 : {item.Money} ");
            }
            
        }
    }
}
