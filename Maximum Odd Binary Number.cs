using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Odd_Binary_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximumOddBinaryNumber("00011");
        }

        public static string MaximumOddBinaryNumber(string s)
        {
            int ones = 0;
            int zeroes = 0;
            StringBuilder w = new StringBuilder();
            Stack<int> ab = new Stack<int>();
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == '1')
                {
                    ++ones;
                }
                else
                {
                    ++zeroes;
                }
            }
            ab.Push(1);
            --ones;
            for (int i = 0; i < zeroes; ++i)
            {
                ab.Push(0);
            }
            for (int j = 0; j < ones; ++j)
            {
                ab.Push(1);
            }
            for (int i = 0; i < s.Length; ++i)
            {
                w.Append(ab.ElementAt(i));
            }
            return w.ToString();
        }
    }
}
