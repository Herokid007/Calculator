using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int y = 5;
            int z = 6;


            Console.WriteLine("The length of wall: " + x + "m");
            Console.WriteLine("The width of wall: " + y + "m");
            Console.WriteLine("The depth of wall: " + z + "m");


            int r = x * y;
            Console.WriteLine("The surface area of the wall: " + r + "m2");
          

           

            int w = x * y * z;
            Console.WriteLine("The volume of the wall: " + w + "m3");

            Console.ReadKey();




        }
    }
}
