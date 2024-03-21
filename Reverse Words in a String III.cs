using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Words_in_a_String_III
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseWords("Let's take LeetCode contest");
        }
        public static string ReverseWords(string s)
        {
            StringBuilder a = new StringBuilder();
            StringBuilder b = new StringBuilder();
            StringBuilder c = new StringBuilder();
            List<string> li = new List<string>();
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] != ' ')
                {
                    a.Append(s[i]);
                }
                else if (s[i] == ' ')
                {
                    li.Add(a.ToString());
                    a.Clear();
                    li.Add(" ");
                }
            }
            li.Add(a.ToString());
            string[] res = new string[li.Count];
            for (int i = 0; i < li.Count; ++i)
            {
                for (int j = li[i].Length - 1; j >= 0; --j)
                {
                    b.Append(li[i].ElementAt(j));
                }
                res[i] = b.ToString();
                b.Clear();
     }
            for (int i = 0; i < res.Length; ++i)
            {
                c.Append(res[i]);
            }

            return c.ToString();
        }
    }
}
