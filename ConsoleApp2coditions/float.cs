using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2coditions
{
    internal class @float
    {
        public static void test()
        {
            Console.WriteLine("enter  float1 value");
            float f1=Single.Parse(Console.ReadLine());
            Console.WriteLine("enter float2 value ");
            float f2=Single.Parse(Console.ReadLine());
            float f3 = f1 * f2;
            Console.WriteLine("multiplication of two floats is :" + f3);
            
        }
    }
}
