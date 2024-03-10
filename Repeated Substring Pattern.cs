using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repeated_Substring_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RepeatedSubstringPattern("abaababaab");
        }
        public static bool RepeatedSubstringPattern(string s)
        {
            int length = s.Length;
            List<string> str = new List<string>();
            StringBuilder temp = new StringBuilder();
            if (s.Length == 1)
            {
                return false;
            }
            for (int i = 0; i < length/2; i++)
            {
                temp.Append(s[i]);
                str.Add(temp.ToString());
            }
            StringBuilder g = new StringBuilder();
            StringBuilder gg = new StringBuilder();

        
                for (int i = 0; i < str.Count; i++)
                {
                    gg = new StringBuilder( str[i]);
                    while (g.Length < length)
                    {
                        g.Append(gg);
                            if (g.Equals(s))
                            {
                                return true;
                            }
                            if (g.Length == length || g.Length>length && !g.Equals(s))
                            {
                                g.Clear();
                                break;
                            }
                    }
                
                }
                //150 mb 💀
            //2024-3-10
            
                     
            return false;
        }
    }
}
