using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_Even_Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int SmallestEvenMultiple(int n)
        {
            int max = 2 * n + 1;
            int x = 0;
            int i = 1;
            while (i < max)
            {
                if (i % n == 0 && i % 2 == 0)
                {
                    return i;
                }
                ++i;

            }
            return 0;
        }
    }
}
