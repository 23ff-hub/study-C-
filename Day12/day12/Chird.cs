using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12
{
    internal class Chird:Parent
    {
        public  void Info1() 
        {
            Info();
        }
        public override void Info() 
        {
            Name = "小米";
            Console.WriteLine($"{Name}我是你爸爸");
        }
    }
}
