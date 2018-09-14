using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "customer.dat";
            Customer c = new Customer();
            BinaryFormatter formatter = new BinaryFormatter();
            //using (Stream output = File.Create(filename))
            //{
            //    formatter.Serialize(output, c);
            //}

            //Customer c2;
            //using (Stream input = File.OpenRead(filename))
            //{                
            //    c2 = (Customer) formatter.Deserialize(input);
            //}
            int j = 0x2a;
            string s = "2a";
            int k = Convert.ToInt32(s);
            Console.WriteLine(j);
            //hexa format
            Console.WriteLine(String.Format("{0:x2}",j));
            Console.WriteLine(String.Format("{0:x4}", j));
            Console.WriteLine(String.Format("{0:x2}", k));
            Console.WriteLine(String.Format("{0:x4}", k));
        }
    }
}
