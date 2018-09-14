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

            MicrosoftCertification.ServiceReference1.ServiceDataClient client = new MicrosoftCertification.ServiceReference1.ServiceDataClient();
            Console.WriteLine(client.GetData(25));

            Console.WriteLine(FindInList("1"));            
                        
        }

        static void method(int par1, string par2)
        {
            Console.WriteLine(par1 + " " + par2);
        }

        static Dictionary<string, int> createTestData()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>()
            {
                {"Accounting",1 },
                {"Marketing", 2 },
                {"Operations",3 }
            };
            
            return dict;
        }

        static bool? FindInList(string searchTerm)
        {
            Dictionary<string, int> data = createTestData();
            return data.ContainsKey(searchTerm);
        }
    }
}
