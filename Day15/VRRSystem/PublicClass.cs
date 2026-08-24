using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRRSystem
{
    //车辆管理
    internal class PublicClass
    {
        //车辆管理信息
        public int Id { get; }
        //id
        public string CarNum { get; set; }
        //车牌号
        public string CarType { get; set; }
        //车辆类型
        public bool CarStatus { get; set; }
        //车辆状态
        public string Money { get; set; }
        //每小时的费用
        public PublicClass(int Id, string CarNum, string CarType, bool CarStatus, string Money)
        {
            this.Id = Id;
            this.CarNum = CarNum;
            this.CarType = CarType;
            this.CarStatus = CarStatus;
            this.Money = Money;
        }
    }

    //客户管理
    internal class Customer
    {
        //public DateTime RegisterTime {  get; set; }
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string IdCard { get; set; }
        public string RegisterTime { get; set; }
        public string Gender { get; set; }
        public string CellPhone { get; set; }
        public string FalseName { get; set; }
        public Customer(int Id,
            string CustomerName,
            string IdCard,
            string RegisterTime,
            string Gender,
            string CellPhone,
            string FalseName
         )
        {
            this.Id = Id;
            this.CustomerName = CustomerName;
            this.IdCard = IdCard;
            this.RegisterTime=RegisterTime;
            this.Gender=Gender;
            this.CellPhone=CellPhone;
            this.FalseName=FalseName;
        }
    }

    //租还记录管理
    internal class recordCar 
    {
        public int Id { get; }
        public int CarId { get;}
        public int CusId { get;}
        public string LeasePeriod { get; set; }
        public string ReturnDate { get; set; }
        public double PayMoney { get; set; }

        public recordCar(
            int Id ,
        int CarId ,
        int CusId ,
        string LeasePeriod
            //string ReturnDate
            //double PayMoney
        
            ) 
        {
            this.Id = Id;
            this.CarId = CarId;
            this.CusId = CusId;
            this.LeasePeriod = LeasePeriod;
            //ReturnDate = ReturnDate;
            //PayMoney = PayMoney;
            }

    }
}
