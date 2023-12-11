using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_Row
{
    class Program
    {
        static void Main(string[] args)
        {
            FindWords(new string[]{"Hello","Alaska","Dad","Peace"});
        }
        public static string[] FindWords(string[] words)
        {
            string[] nwords = new string[words.Length];
            for (int i = 0; i < words.Length; i++)
            {
                nwords[i] = words[i].ToLower();
            }
            string st = "qwertyuiop";
            string st2 = "asdfghjkl";
            string st3 = "zxcvbnm";
            int a = 0;
            int b = 0;
            int c = 0;
            List<string> res = new List<string>();
            for (int i = 0; i < nwords.Length; i++)
            {
                for (int j = 0; j < nwords[i].Length; j++)
                {
                    for (int x = 0; x < st.Length; x++)
                    {
                        if (nwords[i].ElementAt(j) == st.ElementAt(x))
                        { a++; }
                        if (a == nwords[i].Length)
                        {
                            res.Add(words[i]);
                            a = 0;
                        }
                    }
                }
                a = 0;
            }
            for (int i = 0; i < nwords.Length; i++)
            {
                for (int j = 0; j < nwords[i].Length; j++)
                {
                    for (int x = 0; x < st2.Length; x++)
                    {
                        if (nwords[i].ElementAt(j) == st2.ElementAt(x))
                        { b++; }
                        if (b == nwords[i].Length)
                        {
                            res.Add(words[i]);
                            b = 0;
                        }
                    }
                }
                b = 0;
            }
            for (int i = 0; i < nwords.Length; i++)
            {
                for (int j = 0; j < nwords[i].Length; j++)
                {
                    for (int x = 0; x < st3.Length; x++)
                    {
                        if (nwords[i].ElementAt(j) == st3.ElementAt(x))
                        {
                            c++;

                        }
                        if (c == nwords[i].Length)
                        {
                            res.Add(words[i]);
                            c = 0;
                        }
                    }
                }
                c = 0;
            }
            string[] result = new string[res.Count];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = res[i];
            }
            return result;

        }
    }
}
