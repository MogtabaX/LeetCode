using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_Prefix
{
    class Program
    {
        static void Main(string[] args)
        {
            LongestCommonPrefix(new string[] { "aac", "bb", "bc", "b", "caca" });
        }
        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1 || strs[0] == "")
            {
                return strs[0];
            }
            string st = "";
            for (int i = 0; i < strs.Length - 1; i++)
            {
                for (int j = 0; j < strs.Length - i - 1; j++)
                {
                    if (strs[j].Length > strs[j + 1].Length)
                    {
                        st = strs[j];
                        strs[j] = strs[j + 1];
                        strs[j + 1] = st;
                    }
                }
            }
            string ft = "";
            for (int i = 0; i < strs.Length; i++)
            {
                if (strs[i] == "")
                    return strs[i];

            }
            List<string> f = new List<string>();
            for (int i = 0; i < strs.Length - 1; i++)
            {
                for (int j = 0; j < strs[i].Length; j++)
                {
                    if (strs[i].ElementAt(j) == strs[i + 1].ElementAt(j))
                        ft += strs[i].ElementAt(j).ToString();
                    else
                        break;
                }
                f.Add(ft);
                ft = "";
            }
            for (int i = 0; i < f.Count - 1; i++)
            {
                for (int j = 0; j < f.Count - i - 1; j++)
                {
                    if (f[j].Length > f[j + 1].Length)
                    {
                        st = f[j];
                        f[j] = f[j + 1];
                        f[j + 1] = st;
                    }
                }
            }
            for (int i = 0; i < f.Count; i++)
            {
                if (f[i] == " ")
                    return f[i];
            }
            string g = f[0];
            return g;
        }
            }
              
        }

