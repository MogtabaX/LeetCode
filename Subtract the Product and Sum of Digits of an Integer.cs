using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtract_the_Product_and_Sum_of_Digits_of_an_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            SubtractProductAndSum(234);
        }
        public static int SubtractProductAndSum(int n)
        {
            int x = 1;
            int y = 0;
            string b = n.ToString();
            for (int i = 0; i < b.Length; ++i)
            {
                x *= (int)char.GetNumericValue(b[i]);
            }
            for (int i = 0; i < b.Length; ++i)
            {
                y+= (int)char.GetNumericValue(b[i]);
            }
            return x - y;
        }
    }
}
