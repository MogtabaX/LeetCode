using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_First_Palindromic_String_in_the_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstPalindrome(new string[] {"abc","car","ada","racecar","cool"});
        }
        public static string FirstPalindrome(string[] words)
        {
            StringBuilder x = new StringBuilder();
            int i = 0;
            int j=0;
            int length = words.Length;
            for (i = 0; i < length; ++i)
            {
                for (j = words[i].Length-1; j >=0; --j)
                {
                    x.Append(words[i].ElementAt(j));
                    if((!x[0].Equals(words[i].ElementAt(0))))
                    {
                        j = 0;
                        break;
                    }
                }
                if(x.Equals(words[i]))
                {
                    return x.ToString();
                }
                else
                {
                    x.Clear();
                }
            
            }
            return "";
        }
    }
}
