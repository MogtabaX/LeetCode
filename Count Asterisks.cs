using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Asterisks
{
    class Program
    {
        static void Main(string[] args)
        {
            CountAsterisks("*||||**||*||**|**||*|||**");
        }
        public static int CountAsterisks(string s)
        {
            List<string> li = new List<string>();
            StringBuilder b = new StringBuilder();
            for (int i = 0; i < s.Length; ++i)
            {
                b.Append(s[i]);
                if (s[i] == '|')
                {
                    li.Add(b.ToString());
                    b.Clear();
                }
            }
            li.Add(b.ToString());
            int x = 0;
            for (int i = 0; i < li.Count; i+=2)
            {
                for (int j = 0; j < li[i].Length; ++j)
                {
                    if (li[i].ElementAt(j) == '*')
                    
                    {
                        x++;
                            
                    }
                }
            }
            return 0;
        }
    }
}
