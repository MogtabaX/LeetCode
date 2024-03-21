using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_a_String_Is_an_Acronym_of_Words
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool IsAcronym(IList<string> words, string s)
        {
            StringBuilder acronym = new StringBuilder();
            for (int i = 0; i < words.Count; ++i)
            {
                acronym.Append(words[i].ElementAt(0));
            }
            if (acronym.ToString() == s)
            {
                return true;
            }
            return false;
        }
    }
}
