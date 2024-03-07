using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Words_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            ReverseWords("the sky is blue");
        }
        public static string ReverseWords(string s)
        {
            //store int a list , reverse list , eliminate spaces
            //first string is a string with one space (cleaned)
            //every word seperated by space should be added to the list
            //string = the reverse loop of the list contents and between every loop there is a " " added to the string
            //return the string
            int length = s.Length;
            string temp = "";
            string result="";
            string result2="";
            List<string> templist = new List<string>();
            List<string> templist2 = new List<string>();

            for (int i = 0; i < length; ++i)
            {
                if (s[i] != ' ')
                {
                    temp += s[i];
                }
                if (s[i] == ' ')
                {
                    templist.Add(temp);
                    temp = "";
                }

                }
            templist.Add(temp);
            for(int i=templist.Count-1;i>=0;--i)
            {
                if(templist[i].Length>0)
                {
                    result += templist[i];
                    result += " ";
                }
            }
            if (result[result.Length - 1] == ' ')
            {
                for (int i = 0; i < result.Length - 1; ++i)
                {
                    result2 += result2[i];
                }
            }
            else
            {
                return result;
            }
            return result2;

            }
        }
    }

