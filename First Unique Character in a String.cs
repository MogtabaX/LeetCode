using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First_Unique_Character_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstUniqChar("leetcode");
        }
        public static int FirstUniqChar(string s)
        {
            int repeat = 0;
            HashSet<char> hash = new HashSet<char>();
            List<char> li = new List<char>();
            for (int i = 0; i < s.Length; ++i)
            {
                hash.Add(s[i]);
            }
            char[] arr = hash.ToArray();
            char[] st = s.ToArray();


            int j = 0;
            int y = 0;
            for (y = 0; y < arr.Length; ++y)
            {
                for (j = 0; j < st.Length; ++j)
                {
                    if (arr[y].Equals(st[j]))
                    {
                        repeat++;
                    }

                }
                if (repeat == 1)
                {
                    int x = s.IndexOf(arr[y]);
                    return x;
                }
                if (repeat > 1)
                {
                    repeat = 0;

                }
            }
            return -1;
        }
    }
}