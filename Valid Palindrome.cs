using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPalindrome("ab_a");
        }
        public static bool IsPalindrome(string s)
        {
            Stack<char> st1 = new Stack<char>();

            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] > 47 && s[i] < 58)
                {
                    st1.Push(s[i]);
                    continue;
                }
                if (s[i] > 96 && s[i] < 123)
                {
                    st1.Push(s[i]);
                }
                if (s[i] > 64 && s[i] < 91)
                {
                    st1.Push(s[i]);
                }
            }
            StringBuilder reversed = new StringBuilder();
            while (st1.Count > 0)
            {
                reversed.Append(st1.Pop());
            }
            StringBuilder normal = new StringBuilder();
            for (int i = reversed.Length - 1; i >= 0; --i)
            {
                normal.Append(reversed[i]);
            }
            string A = normal.ToString().ToLower();
            string B = reversed.ToString().ToLower();
            B.Reverse();
            if (A.Equals(B))
            {
                return true;
            }
            return false;
        }
    }
}
