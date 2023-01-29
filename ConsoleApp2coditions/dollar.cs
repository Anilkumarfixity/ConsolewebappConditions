using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2coditions
{
    internal class dollar
    {
        public static void test()
        {
            Console.WriteLine("enter no of dollars");
            int x=int.Parse(Console.ReadLine());
            int y = 100;//y = cents
            Console.WriteLine(x*y+"cents :");
        }
    }
}
