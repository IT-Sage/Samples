using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Hello : IHelloable
    {

        public void HelloMethod(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        void IHelloable.HelloMethod(string name)
        {
            Console.WriteLine("Explicit Hello " + name);
        }
    }
}
