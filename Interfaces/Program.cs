using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IHelloable h = new Hello();
            Hello h2 = new Hello();
            h2.HelloMethod("John");
            h.HelloMethod("Jack");
        }
    }
}
