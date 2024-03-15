using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispowerof4
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPowerOfFour(17);
        }
        public static bool IsPowerOfFour(int n)
        {
            if (n == 1 || n == 4)
            {
                return true;
            }
            float m = n;
            while (m > 4)
            {
                m = m / 4;
                if (m == 4)
                { return true; }
            }
            return false;
        }
    }
}
