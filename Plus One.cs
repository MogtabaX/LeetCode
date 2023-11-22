using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plus_One
{
    class Program
    {
        static void Main(string[] args)
        {
            PlusOne(new int[] { 1,2,3,4 });
        }
        public static int[] PlusOne(int[] digits)
        {
            string strong = "";
            for (int i = 0; i < digits.Length; i++)
            {
                strong += digits[i].ToString();
            }
            BigInteger g = BigInteger.Parse(strong);
            g = g + 1;
            string final = g.ToString();
            int[] s = new int[final.Length];
            for (int i = 0; i < final.Length; i++)
            {
                s[i] = (int)char.GetNumericValue(final[i]);
            }
            return s;
        }
    }
}
