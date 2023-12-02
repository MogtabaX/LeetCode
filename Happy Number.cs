using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Happy_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            IsHappy(3);
        }
        public static bool IsHappy(int n)
        {
            double s = 0;
            int x = 0;
            HashSet<int> h = new HashSet<int>();
            string st = n.ToString();
            double[] a = new double[st.Length];
            while (n != 1)
            {
                st = n.ToString();
                a = new double[st.Length];
                List<int> looper = new List<int>();
                for (int i = 0; i < st.Length; i++)
                {
                    a[i] = (double)char.GetNumericValue(st[i]);
                }
                for (int i = 0; i < a.Length; i++)
                {
                    s += Math.Pow(a[i], 2);
                }
                n = (int)s;
                s = 0;
                x++;
                h.Add(n);
                if (x > h.Count)
                {
                    return false;
                }
            }
            if (a[0] == (int)1)
            {
                return true;
            }
            else if (n == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
