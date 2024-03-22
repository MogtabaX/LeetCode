using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Removing_Stars_From_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoveStars("a*bc**d*dy");
        }
        public static string RemoveStars(string s)
        {
            Stack<char> sta = new Stack<char>();
            Stack<char> stak = new Stack<char>();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == '*')
                {
                    sta.Pop();
                }
                else
                {
                    sta.Push(s[i]);
                }
            }
            if (sta.Count == s.Length)
            {
                return s;
            }
            char[] a = new char[sta.Count];
            while (sta.Count > 0)
            {
                stak.Push(sta.Pop());
            }
            while (stak.Count > 0)
            {
                result.Append(stak.Pop());
            }
            return result.ToString();
           
        }
    }
}
