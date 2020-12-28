using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditTwoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Attend_class_P = new string[,] { { "AP" } };
            string[,] Mid_term_P = new string[,] { { "MP" } };
            string[,] Final_P = new string[,] { { "FP" } };
            string[,] Collect_P = new string[,] { { "CP" } };
            for (int i = 0; i < 1; ++i)
            {
                for (int j = 0; j < 1; ++j)
                {
                    Console.Write("\t\t{0}", Attend_class_P[i, j]);
                    Console.Write("\t{0}", Mid_term_P[i, j]);
                    Console.Write("\t{0}", Final_P[i, j]);
                    Console.Write("\t{0}", Collect_P[i, j]);
                }
                Console.WriteLine();
            }
            int[,] intArr = new int[,] { { 10,  30,  40,  20 }, { 10, 30, 40, 20 }, { 10, 30, 40, 20 }, { 10, 30, 40, 20 }, { 10, 30, 40, 20 }, };
            Console.WriteLine()
            
            for (int i = 0; i < 5; ++i)
                
            {
                Console.Write("student");
                Console.Write(" {0}", i+1);
                for (int j = 0; j < 4; ++j)
                {
                    Console.Write("\t{0}", intArr[i, j]);
                }
                Console.WriteLine();

            }
            Console.WriteLine("AP = Attend class points, MP = Mid-term points, FP = Final points, CP = Collect points");
        }
    }
}
