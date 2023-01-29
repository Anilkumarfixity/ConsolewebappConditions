using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2coditions
{
    internal class ternary
    {
        public static void Test()
        {
            int x = 10, y = 15, z = 20;
            var res = x < y ? "x is lessthan y" : "x is greaterthan y";
             

                 res=   z > x ? "z is greater than x" : "z is lessthan x"; 
            Console.WriteLine(res);
            
        }
    }
}
class simple
{
    public static void test()
    {
        Console.WriteLine("enter debt");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("enter si"+ "%");
        int y = int.Parse(Console.ReadLine());
        float y1 = y * x / 100;
        Console.WriteLine(y1);
    }
}
class area
{
    public static void area_()
    {
        int l, b, a, p;
        Console.WriteLine("enter length");
        l = int.Parse(Console.ReadLine());
        Console.WriteLine("enter breadth");
        b = int.Parse(Console.ReadLine());
       
        a = l * b;
        Console.WriteLine("area is:"+ a);

        p = 2 * (l + b);
        Console.WriteLine("peramet is :" + p);
    }
}