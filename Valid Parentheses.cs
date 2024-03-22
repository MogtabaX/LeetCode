using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            IsValid("([}}])");
        }
        public static bool IsValid(string s)
        {
            if (s.Length == 0 || s.Length == 1)
            {
                return false;
            }
            Stack<char> st = new Stack<char>();
            if (s[0] == ')' || s[0] == '}' | s[0] == ']')
            {
                return false;
            }
            if (s.Length % 2 != 0)
            {
                return false;
            }
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                {
                    st.Push(s[i]);
                    continue;
                }
                if (s[i] == ')')
                {
                    if (st.Count > 0 && st.Peek() == '(')
                    {
                        st.Pop();
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (s[i] == '}')
                {
                    if (st.Count > 0 && st.Peek() == '{')
                    {
                        st.Pop();
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (s[i] == ']')
                {
                    if (st.Count > 0 && st.Peek() == '[')
                    {
                        st.Pop();
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            if (st.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}
