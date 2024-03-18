using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decode_the_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            DecodeMessage("the quick brown fox jumps over the lazy dog", "vkbs bs t suepuv");
        }
        public static string DecodeMessage(string key, string message)
        {
            //map to alphabet reverse to alphabet
            string alphabet ="abcdefghijklmnopqrstuvwxyz";
            Dictionary<char, char> dic = new Dictionary<char, char>();
            HashSet<char> hash = new HashSet<char>();
            StringBuilder s = new StringBuilder();
            for(int i=0;i<key.Length;++i)
            {
                if(key[i]!=' ')
                {
                    if (hash.Add(key[i]))
                    {
                        s.Append(key[i]);
                    }
                }
            }
            for (int i = 0; i < s.Length; ++i)
            {
                dic.Add(s[i], alphabet[i]);
            }
            StringBuilder st = new StringBuilder();
            for (int i = 0; i < message.Length; ++i)
            {
                if (dic.ContainsKey(message[i]))
                {
                    st.Append(dic[message[i]]);
                }
                else
                {
                    st.Append(' ');
                }
            
            }
            return st.ToString();
        }
    }
}
