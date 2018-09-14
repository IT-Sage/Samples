using System;
using System.Text;

namespace StringBuilderSample
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                stringBuilder.AppendLine("line" + i);
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
