using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_Segments_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            CountSegments("           ");
        }
        public static int CountSegments(string s)
        {
            StringBuilder b = new StringBuilder();
            List<string> c = new List<string>();
            int i = 0;
            int y = 0;
            for (i = 0; i < s.Length; ++i)
            {
                if (s[i] != ' ')
                {
                    b.Append(s[i]);
                    if (i == s.Length - 1)
                    {
                        c.Add(b.ToString());
                        b.Clear();
                    }
                    continue;
                }
                c.Add(b.ToString());
                b.Clear();
            }
            int x = 0;
            for (y = 0; y < c.Count; ++y)
            {
                if (c[y] != "")
                {
                    ++x;
                }
            }
            return x;
        }
    }
}
