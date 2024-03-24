using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incremental_Memory_Leak
{
    class Program
    {
        static void Main(string[] args)
        {
            MemLeak(1904841917, 885391039);
        }
        public static int[] MemLeak(int memory1, int memory2)
        {
            int a = 0;
            int m1 = memory1;
            int m2 = memory2;
            int maxtime = 0;
            int i = 1;
            int[] res = new int[] { a, m1, m2 };
            if (memory1 > memory2)
            {
                maxtime = memory1;
            }
            else if (memory1 < memory2)
            {
                maxtime = memory2;
            }
            else
            {
                maxtime = memory1;
            }
            for (i = 1; i < maxtime+1; ++i)
            {
                if (m1 > m2)
                {
                    if (i > m1)
                    {
                        break;
                    }
                    m1 = m1 - i;
                }
                else if (m2 > m1)
                {
                    if (i > m2)
                    {
                        break;
                    }
                    m2 = m2 - i;
                }
                else
                {
                    if (i > m1 || i>m2)
                    {
                        break;
                    }
                    m1 = m1 - i;
                }
               
            }
            res = new int[] { i, m1, m2 };
            return res;
        }
    }
}
