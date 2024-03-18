using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_to_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            RomanToInt("III");
        }
        public static int RomanToInt(string s)
        {
            /*
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
             */
            /* 
             
             I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
             */
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("I", 1);
            dic.Add("V", 5);
            dic.Add("X", 10);
            dic.Add("L", 50);
            dic.Add("C", 100);
            dic.Add("D", 500);
            dic.Add("M", 1000);
            dic.Add("IV",4);
            dic.Add("IX",9);
            dic.Add("XL",40);
            dic.Add("XC",90);
            dic.Add("CD",400);
            dic.Add("CM",900);
            
            List<string> li = new List<string>();
            for(int i=0;i<s.Length;++i)
            {
                if(i!=s.Length-1 && s[i]=='I' && s[i+1] =='V')
                {
                    li.Add("IV");
                    ++i;
                    continue;
                }
                if (i != s.Length - 1 && s[i] == 'I' && s[i + 1] == 'X')
                {
                    li.Add("IX");
                    ++i;
                    continue;

                }
                if (i != s.Length - 1 && s[i] == 'X' && s[i + 1] == 'L')
                {
                    li.Add("XL");
                    ++i;
                    continue;

                }
                if (i != s.Length - 1 && s[i] == 'X' && s[i + 1] == 'C')
                {
                    li.Add("XC");
                    ++i;
                    continue;

                }
                if (i != s.Length - 1 && s[i] == 'C' && s[i + 1] == 'D')
                {
                    li.Add("CD");
                    ++i;
                    continue;

                }
                if (i != s.Length - 1 && s[i] == 'C' && s[i + 1] == 'M')
                 {
                     li.Add("CM");
                     ++i;
                     continue;

                 }
                 else
                 {
                     li.Add(s[i].ToString());
                 }
            }

            int x = 0;
            for (int i = 0; i < li.Count; ++i)
            {
                if (dic.ContainsKey(li[i]))
                {
                    x += dic[li[i]]; ;
                }
            }
            return x;
            }
        }
    }

