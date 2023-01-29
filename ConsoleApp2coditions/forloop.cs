using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2coditions
{
    internal class forloop
    {
       public static void Test()
        {
            Console.WriteLine("enter a number!");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            for (int i = 1; i < x; i=i+3)
            {
                for (int j = 0; j < y; j++)

                    Console.WriteLine(i);
            }
        }
    }
}
