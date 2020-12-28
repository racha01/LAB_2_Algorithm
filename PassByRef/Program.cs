using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassByRef
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            Console.WriteLine("This coodinate first point is {0},{1}", x, y);
            Addpoint(ref x, ref y);
            Console.WriteLine("After call addpoint method, the point is {0},{1}", x, y);


        }
        public static void Addpoint(ref int x1, ref int y1)
        {
            Console.WriteLine("Receive point frome main method is {0},{1}", x1, y1);
            x1 += 10;
            y1 += 5;
            Console.WriteLine("Now the new point is {0},{1} in Addpoint Method", x1, y1);
        }
    }
}
