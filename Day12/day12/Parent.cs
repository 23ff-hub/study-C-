using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12
{
    public class Parent
    {
        public string Name {  get; set; }
        public virtual void Info() 
        {
            Console.WriteLine($"{Name}我是你爸爸");
            Console.WriteLine("我会踢足球");
        }
    }

    
}
