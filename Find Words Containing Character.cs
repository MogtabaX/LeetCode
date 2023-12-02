using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Words_Containing_Character
{
    class Program
    {
        static void Main(string[] args)
        {
            FindWordsContaining(new string[] {"abc","bcd","aaaa","cbc"}, 'a');
        }
        public static IList<int> FindWordsContaining(string[] words, char x)
        {
            List<int> ans = new List<int>();
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (x == words[i].ElementAt(j))
                    {
                        ans.Add(i);
                        break;
                    }
                }
            }
            return ans;
        }
    }
}
