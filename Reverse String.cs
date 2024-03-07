using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseString(new char[] {'h','e','l','l','o'});
        }
        public static void ReverseString(char[] s)
        {
            char temp = ' '; 
            int length = s.Length;
            int i = 0;
            int j = 0;
            for (i = 0; i < length; ++i)
            {
                for (j = i + 1; j < length; ++j)
                {
                    temp = s[j];
                    s[j] = s[i];
                    s[i] = temp;
                }
            }
            //first try -ish
            //2024/3/7
        }
    }
}
