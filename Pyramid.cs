using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntraC_Assignment1
{
    internal class Pyramid
    {
        int numLevels;
                public Pyramid(int num)
        {
                                numLevels = num;

        }
        public void PrintPyramid()
        {
            for (int i = 1; i <= numLevels; i++)
            {
                for (int j = 0; j < numLevels - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
