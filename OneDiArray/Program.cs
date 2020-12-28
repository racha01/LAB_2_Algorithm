using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDiArray
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] floatArr = new float[] { 11, 12, 13, 14, 15 };
            Console.WriteLine("Ues for");
            for (int i = 0; i < floatArr.Length; i++)
            {
                Console.WriteLine(floatArr);
            }
            Console.WriteLine("Ues foreach");
            foreach (float i in floatArr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
