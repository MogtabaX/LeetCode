using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPalindrome(121);
        }
        public static bool IsPalindrome(int x)
        {

            string num = x.ToString();
            string a = "";
            string b = "";
            bool pali = false;
            for (int i = 0; i < num.Length; i++)
            {
                a += num[i].ToString();
            }
            for (int i = num.Length - 1; i >= 0; i--)
            {

                b += num[i].ToString();
            }
            if (a == b)
            {
                pali = true;
            }
            else
            {
                pali = false;
            }
            return pali;
        }
    }
}
