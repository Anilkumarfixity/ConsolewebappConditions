using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2coditions
{
    internal class evenodd
    {
        public static void even1()
        {
            Console.WriteLine("enter a numer !");
            int x = int.Parse(Console.ReadLine());
            var b = x / 2;
            b = 0;               
            if (x % 2 == 0)
                {
                    Console.WriteLine("numer is even");
                   
                }
            
                else
                {
                    Console.WriteLine("number is odd");
                }
            }
        }
    }
