using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfMultiples(7);
        }
        public static int SumOfMultiples(int n)
        {
            int num = 1;
            List<int> li = new List<int>();
            while (num != n+1)
            {
                if (num % 3 == 0 || num % 5 == 0 || num % 7 == 0)
                {
                    li.Add(num);
                }
                num++;
            }
            int result = 0;
            for (int i = 0; i < li.Count; ++i)
            {
                result += li[i];
            }
            return result;
        }
    }
}
