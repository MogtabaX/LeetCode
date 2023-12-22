using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MostWordsFound(new string[] { "w jrpihe zsyqn l dxchifbxlasaehj", "nmmfrwyl jscqyxk a xfibiooix xolyqfdspkliyejsnksfewbjom", "xnleojowaxwpyogyrayfgyuzhgtdzrsyococuqexggigtberizdzlyrdsfvryiynhg", "krpwiazoulcixkkeyogizvicdkbrsiiuhizhkxdpssynfzuigvcbovm", "rgmz rgztiup wqnvbucfqcyjivvoeedyxvjsmtqwpqpxmzdupfyfeewxegrlbjtsjkusyektigr", "o lgsbechr lqcgfiat pkqdutzrq iveyv iqzgvyddyoqqmqerbmkxlbtmdtkinlk", "hrvh efqvjilibdqxjlpmanmogiossjyxepotezo", "qstd zui nbbohtuk", "qsdrerdzjvhxjqchvuewevyzlkyydpeeblpc" });
        }
        public static int MostWordsFound(string[] sentences)
        {
            int[] counter = new int[sentences.Length];
            for (int i = 0; i < sentences.Length; i++)
            {
                for (int j = 0; j < sentences[i].Length; j++)
                {
                    if (sentences[i].ElementAt(j) == ' ')
                    {
                        counter[i] += 1;
                    }
                }
            }

            int max = 0;
            for (int i = 0; i < counter.Length; i++)
            {
                if (counter[i] > max)
                {
                    max = counter[i]; ;
                }
            }
            max++;
            return 0;
        }
    }
}
