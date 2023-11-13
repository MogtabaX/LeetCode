using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length_of_Last_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            LengthOfLastWord(s);
        }
        public static int LengthOfLastWord(string s) {
            List<string> normalize = new List<string>();
            List<int> lastindexarray = new List<int>();
            string lastword="";
            string lastwordx = "";
            int length = 0;
            string indents = " ";
            string modifiedstring = "";
            modifiedstring += indents;
            for (int i = 0; i < s.Length; i++)
            {
                modifiedstring += s[i];
            }
            modifiedstring += indents;

            for (int i = 0; i < modifiedstring.Length; i++)
            { 
                if (modifiedstring.ElementAt(i).ToString() != " " && modifiedstring.ElementAt(i + 1).ToString() == " ")
                {
                    normalize.Add(modifiedstring.ElementAt(i).ToString());
                    lastindexarray.Add(i);
                }  
            }
            for (int i = lastindexarray[lastindexarray.Count-1]; i >= 0; i--)
            {
                //start from the last normalize element that is in the string 
                if (modifiedstring.ElementAt(i).ToString() != " ")
                {
                    lastword += modifiedstring.ElementAt(i);
                }
                else
                    break;  
            }
            length = lastword.Length;
            for (int i = lastword.Length-1; i >= 0; i--)
            {
                lastwordx += lastword.ElementAt(i).ToString();
            }
            Console.WriteLine("The last word is: "+lastwordx+ " And the length is: " + length);
            return length;
        }
   
    }
}
