using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EditJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] mainArr = new string[1][];
            int[][] MainArr = new int[1][];
            mainArr[0] = new string[2] { "A", "B" };
            MainArr[1] = new int[3] { 0, 1, 13 };
            //mainArr[2] = new int[4] { 5, 6, 8, 14, };

            for (int i = 0; i < mainArr.Length; ++i)
            {
                Console.Write("Main ({0}), Sub : ", i);
                for (int j = 0; j < mainArr[i].Length; ++j)
                {
                    Console.Write("{0}\t", mainArr[i][j]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
