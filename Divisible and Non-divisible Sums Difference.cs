using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisible_and_Non_divisible_Sums_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int DifferenceOfSums(int n, int m)
        {
            int num1 = 0;
            int num2 = 0;
            int i = 1;
            int j = 1;
            while (i <= n)
            {
                if (i % m != 0)
                {
                    num1 += i;
                }
                else
                {
                    num2 += i;
                }
                ++i;
            }
            return num1 - num2;
        }
    }
}
