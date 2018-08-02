using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // swapped order of named parameters
            method(par2: "Hi", par1: 5);

            int myInt = new int(); // default value
            Console.WriteLine(myInt);
            myInt = 50000;

            short myShort = (short)myInt;
            Console.WriteLine(myShort);




        }

        static void method(int par1, string par2)
        {
            Console.WriteLine(par1 + " " + par2);
        }
    }
}
