using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_the_Sentence_Is_Pangram
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckIfPangram("thequickbrownfoxjumpsoverthelazydog");
        }
        public static bool CheckIfPangram(string sentence)
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            HashSet<char> checker = new HashSet<char>();
            if (sentence.Length < alpha.Length)
            {
                return false;
            }
            for (int i = 0; i < sentence.Length; i++)
            {
                checker.Add(sentence[i]);
            }
            char[] sent = checker.ToArray();
            if (sent.Length == alpha.Length)
            {
                return true;
            }
            return false;  
        }
    }
}
