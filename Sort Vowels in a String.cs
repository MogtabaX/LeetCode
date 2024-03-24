using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Vowels_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            SortVowels("axROkCyuHm");
        }
        public static string SortVowels(string s)
        {
            StringBuilder vowels = new StringBuilder();
            for (int i = 0; i < s.Length; ++i)
            {
                    if (s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U' || s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                    {
                        vowels.Append(s[i]);
                    }           
            }
            if (vowels.Length == 0||vowels.Length==1)
            {
                return s;
            }
            char[] vowel = new char[vowels.Length];
            for (int i = 0; i < vowel.Length; ++i)
            {
                vowel[i] = vowels[i];
            }
            vowels.Clear();
            int max = (int)(vowel[0]);
            for (int i = 1; i < vowel.Length; ++i)
            {
                if ((int)vowel[i] > max)
                {
                    max = (int)vowel[i];
                }
            }
            int size = vowel.Length;
            int[] occur = new int[max + 1];
            for (int i = 0; i < max + 1; ++i)
            {
                occur[i] = 0;
            }
            for (int i = 0; i < size; ++i)
            {
                occur[vowel[i]]++;
            }
            for (int i = 0, j = 0; i <= max; ++i)
            {
                while (occur[i] > 0)
                {
                    vowel[j] = (char)i;
                    ++j;
                    occur[i]--;
                }
            }
            int x = 0;
            StringBuilder t = new StringBuilder();
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == 'A' || s[i] == 'E' || s[i] == 'I' || s[i] == 'O' || s[i] == 'U' || s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    t.Append(vowel[x]);
                    ++x;
                }
                else
                {
                    t.Append(s[i]);
                }
            }
            string res = t.ToString();
            t.Clear();
            return res;
        }
    }
}
    