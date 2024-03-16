using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Lower_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            ToLowerCase("Hello");
        }
        public static string ToLowerCase(string s)
        {
            /*Dictionary<char, char> dic = new Dictionary<char, char>();
            dic.Add('A', 'a');
            dic.Add('B', 'b');
            dic.Add('C', 'c');
            dic.Add('D', 'd');
            dic.Add('E', 'e');
            dic.Add('F', 'f');
            dic.Add('G', 'g');
            dic.Add('H', 'h');
            dic.Add('I', 'i');
            dic.Add('J', 'j');
            dic.Add('K', 'k');
            dic.Add('L', 'l');
            dic.Add('M', 'm');
            dic.Add('N', 'n');
            dic.Add('O', 'o');
            dic.Add('P', 'p');
            dic.Add('Q', 'q');
            dic.Add('R', 'r');
            dic.Add('S', 's');
            dic.Add('T', 't');
            dic.Add('U', 'u');
            dic.Add('V', 'v');
            dic.Add('W', 'w');
            dic.Add('X', 'x');
            dic.Add('Y', 'y');
            dic.Add('Z', 'z');
            string result = "";
            for (int i = 0; i < s.Length; ++i)
            {
                for (int j = 0; j < dic.Count; ++j)
                { 
                    if(s[i]==dic.ElementAt(j).Key)
                    {
                        result+=dic.ElementAt(j).Value;
                        break;
                    }
                }
                if (!dic.ContainsKey(s[i]))
                {
                    result += s[i];
                    
                }
            }
             * */
            string result = "";
            for (int i = 0; i < s.Length; ++i)
            {
                if ((int)s[i] < 91 && (int)s[i] > 64)

                {
                    result += (char)((int)s[i] + 32);
                }
                else
                {
                    result += s[i];
                }
                    
            
            }



            return result;
        }
    }
}
