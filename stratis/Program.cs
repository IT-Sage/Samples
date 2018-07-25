using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stratis
{
    class Program
    {
        static void Main(string[] args)
        {//hex to ascii po dvou znacich (= 8bitu = 1byte)
            string s = "ec4064d5a4e49103024881df4629bf5f67e4d49e49ccf6f1a4d33829db98d712";
            string[] s2 ={"7b22515220636f6465203231783231223a7b22766572746963616c223a5b5b372c322c312c37",
                        "5d2c5b312c312c312c312c312c315d2c5b312c332c312c312c312c312c312c332c315d2c5b31",
    "2c332c312c312c312c312c332c315d2c5b312c332c312c342c312c332c315d2c5b312c312c31",
"2c315d2c5b372c312c312c312c375d2c5b335d2c5b342c312c312c312c322c223342222c315d",
"2c5b312c322c322c312c312c315d2c5b322c322c312c325d2c5b322c223241222c312c312c31",
"2c325d2c5b312c342c322c312c325d2c5b322c332c315d2c5b372c312c315d2c5b312c312c32",
"2c322c312c223143225d2c5b312c332c312c312c312c312c345d2c5b312c332c312c322c342c",
"335d2c5b312c332c312c322c335d2c5b312c312c312c352c223144225d2c5b372c312c312c33",
"2c315d5d2c22686f72697a6f6e74616c223a5b5b372c322c375d2c5b312c312c312c312c312c",
"312c315d2c5b312c332c312c312c312c312c332c315d2c5b312c332c312c322c312c312c332c",
"315d2c5b312c332c312c312c322c312c332c315d2c5b312c312c312c312c315d2c5b372c312c",
"312c312c375d2c5b312c315d2c5b312c332c312c312c312c345d2c5b322c312c312c352c345d",
"2c5b312c312c342c223241222c312c325d2c5b322c312c325d2c5b332c312c322c332c355d2c",
"5b312c312c312c345d2c5b372c322c322c325d2c5b312c312c312c312c315d2c5b312c332c31",
"2c322c332c315d2c5b312c332c312c312c322c325d2c5b312c332c312c223142222c332c315d",
"2c5b312c312c322c325d2c5b372c342c223143222c223144225d5d7d7d"};

            List<long> hex = new List<long>();
            foreach (string item in s2)
            {
                hex.Add(Convert.ToInt64(item, 16));

                Console.Write(item.Length + " ");
                foreach (var i in item.Distinct())
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

            foreach (int i in hex)
            {
                Console.WriteLine(i);
            }

            
        }
    }
}
