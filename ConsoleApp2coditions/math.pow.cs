using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2coditions
{
    internal class math
    {
        public static void Main(string[]args)
        {
            int s;
            Console.WriteLine("enter basenum");
            int basenum=int.Parse(Console.ReadLine());
            Console.WriteLine("enter powernum");
            int powernum=int.Parse(Console.ReadLine());
            double returnname=Math.Pow( basenum , powernum);
            Console.WriteLine("math.pow :" + returnname);
        }
    }
}

