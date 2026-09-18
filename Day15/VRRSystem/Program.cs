namespace VRRSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            Tip();// 提示界面
            CarManger CM = new CarManger();
            CustomerManger CMS = new CustomerManger();
            RecordCar RC = new RecordCar();
            ReturnCar returnCar = new ReturnCar();
            while (str != "0") 
            {
                str = Console.ReadLine();
                switch (str) 
                {
                    case "1":
                        string CMStr = CM.CarAdd();
                        Console.WriteLine(CMStr);
                        break;
                    case "2":
                        CM.lookCarAll();
                        break;
                    case "3":
                        CM.lookOneCar();
                        break;
                    case "4":
                        CM.lookNullCar();
                        break;
                    case "5":
                        CMS.CustomerAdd();
                        break;
                    case "6":
                        CMS.lookCustomer();
                        break;
                    case "7":
                       CMS.lookCustomerId();
                        break;
                    case "8":
                        RC.recordAdd();
                        break;
                    case "9":
                        returnCar.returnCar();
                        break;
                    case "0":
                        Console.WriteLine("退出成功");
                        break;
                    default:
                        Console.WriteLine("输入操作编号有误！");
                        break;
                }
            }
        }

        static void Tip() 
        {
            Console.WriteLine("==欢迎来到饿了么租车系统==");
            Console.WriteLine("请选择操作编号：");
            Console.WriteLine("1：新增车辆");
            Console.WriteLine("2：查看所有车辆信息");
            Console.WriteLine("3：查看某辆车");
            Console.WriteLine("4：查看所有空闲车辆");
            Console.WriteLine("5：新增客户");
            Console.WriteLine("6：查看所有客户");
            Console.WriteLine("7：查看某个客户");
            Console.WriteLine("8：租车");
            Console.WriteLine("9：还车");
            Console.WriteLine("0：退出系统");
        }       

    }
}
