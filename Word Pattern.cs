using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WordPattern("aaa", "aa aa aa aa");
        }
        public static bool WordPattern(string pattern, string s)
        {

            string[] input = new string[pattern.Length];
            HashSet<string> inputhash = new HashSet<string>();
            Dictionary<string, int> inputdict = new Dictionary<string, int>();


            for (int i = 0; i < input.Length; i++)
            {
                input[i] = pattern.ElementAt(i).ToString();
            }
            for (int i = 0; i < input.Length; i++)
            {
                inputhash.Add(input[i]);
            }
            for (int i = 0; i < inputhash.Count; i++)
            {
                inputdict.Add(inputhash.ElementAt(i), i);
            }
            int[] finalinput = new int[input.Length];
            for (int i = 0; i < pattern.Length; i++)
            {
                for (int j = 0; j < inputdict.Count; j++)
                {
                    if (inputdict.ElementAt(j).Key == input[i])
                    {
                        finalinput[i] = inputdict.ElementAt(j).Value;
                    }
                }
            }


            List<string> words = new List<string>();
            Dictionary<string, int> wordsdict = new Dictionary<string, int>();
            string str = "";
            bool spaced = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    spaced = true;
                    break;
                }

            }
            if (spaced == true)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] != ' ')
                    {
                        str += s[i];

                    }
                    else if (s[i] == ' ')
                    {
                        words.Add(str);
                        str = "";
                    }
                }
                words.Add(str);
            }

            else if (spaced == false)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    words.Add(s[i].ToString());
                }
            }
            if (spaced == false && pattern.Length == 1)
            {
                return true;
            }
            if (spaced == false && pattern == s)
            {
                return false;
            }

            //convert words into an array;
            string[] finalwords = new string[words.Count];
            HashSet<string> wordhash = new HashSet<string>();
            for (int i = 0; i < finalwords.Length; i++)
            {
                finalwords[i] = words.ElementAt(i);
            }
            for (int i = 0; i < words.Count; i++)
            {
                wordhash.Add(words[i]);
            }
            for (int i = 0; i < wordhash.Count; i++)
            {
                wordsdict.Add(wordhash.ElementAt(i), i);
            }
            int[] newS = new int[words.Count];
            //if value of wordhash[i] == s[i] , arr[i] = wordhash[i].key
            for (int i = 0; i < words.Count; i++)
            {
                for (int j = 0; j < wordsdict.Count; j++)
                {
                    if (wordsdict.ElementAt(j).Key == words[i])
                    {
                        newS[i] = wordsdict.ElementAt(j).Value;
                    }
                }
            }
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (newS[i] == finalinput[i])
                {
                    count++;
                }
                if (count == newS.Length)
                {
                    return true;
                }
            }
            if (count != newS.Length)
            {
                return false;
            }

            return false;
        }
    }
}
