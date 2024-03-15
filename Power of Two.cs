using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPowerOfTwo(16);
        }
        public static bool IsPowerOfTwo(int n)
        {
            double m = n;
            if (n == 1 || n == 2)
            {
                return true;
            }
            while (m > 2)
            {
                m = m / 2;
                if (m == 2)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
