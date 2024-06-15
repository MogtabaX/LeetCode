using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1071.Greatest_Common_Divisor_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            GcdOfStrings("TAUXXTAUXXTAUXXTAUXXTAUXX", "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX");
        }
        public static string GcdOfStrings(string str1, string str2)
        {
            //SHOULD RETURN AB
            //if str1%string == 0 && str2%string == 0
            //took 3 months to solve
            string gcd = "";
            string gcdx = "";
            bool flag1=false;
            bool flag2=false;
            Stack<string> stack = new Stack<string>();
            string temp = "";
            if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str2.Length; ++i)
                {
                    temp += str2[i];
                    stack.Push(temp);
                }
            }
            else
            {
                for (int i = 0; i < str1.Length; ++i)
                {
                    temp += str1[i];
                    stack.Push(temp);
                }
            }

            while(stack.Count!=0)
            {
                gcdx = stack.Pop();
                for (int j = 0; j < str1.Length; ++j)
                {
                    gcd += gcdx;
                    if (gcd.Length > str1.Length)
                    {
                        break;
                    }
                    if (gcd.Equals(str1) && gcd.Length <= str1.Length + 1)
                    {
                        flag1 = true;
                        break;
                    }
                    else
                    {
                        flag1 = false;
                        flag2 = false;
                    }
                }
                gcd = "";
                    for (int h = 0; h < str2.Length; ++h)
                {
                    gcd += gcdx;
                    if (gcd.Length > str2.Length)
                    {
                        break;
                    }
                    if (gcd.Equals(str2) && gcd.Length <= str2.Length + 1)
                    {
                        if (flag1)
                        {
                            flag2 = true;
                            break;
                        }
                        else
                        {
                            flag1 = false;
                            flag2 = false;
                        }
                       
                    }
                    
                }
                    if (flag1 && flag2)
                    {
                        return gcdx;
                    }
                gcd="";
            }
          
           
            return "";
        }
    }
}
