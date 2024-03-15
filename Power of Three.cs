using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_of_Threee
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPowerOfThree(1676909049);
        }
        public static bool IsPowerOfThree(int n)
        {
            double m = n;
            if (n == 3 || n == 1)
            {
                return true;
            }
            while (m > 3)
            {
                m = m / 3;
                if (m == 3)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
