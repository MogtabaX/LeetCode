using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Merge_Strings_Alternately
{
    class Program
    {
        static void Main(string[] args)
        {
            MergeAlternately("abc", "pqr");
        }
        public static string MergeAlternately(string word1, string word2)
        {
            string st = "";
            if (word1 == "" && word2 == "")
            {
                return st;
            }
            if (word1 == "")
            {
                return word2;
            }
            if (word2 == "")
            {
                return word1;
            }
            string shortest = "";
            string longest = "";
            if (word1.Length > word2.Length)
            {
                shortest = word2;
                longest = word1;
            }
            else if (word1.Length < word2.Length)
            {
                shortest = word1;
                longest = word2;
            }
            else if (word1.Length == word2.Length)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    st += word1.ElementAt(i).ToString() + word2.ElementAt(i).ToString();
                }
                return st;
            }
            for (int i = 0; i < shortest.Length; i++)
            {
                st += word1.ElementAt(i).ToString() + word2.ElementAt(i).ToString();
            }
            for (int i = shortest.Length; i < longest.Length; i++)
            {
                st += longest.ElementAt(i).ToString();
            }
            return st;
        }
    }
}
