using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goal_Parser_Interpretation
{
    class Program
    {
        static void Main(string[] args)
        {
            Interpret("(al)G(al)()()G");
        }
        public static string Interpret(string command)
        {
            StringBuilder x = new StringBuilder();
            int length = command.Length;
            if (command[0] == 'G')
            {
                x.Append('G');
            }
            for (int i = 1; i < length; ++i)
            {
                if (command[i] == 'G')
                {
                    x.Append('G');
                }

                if (command[i - 1] == 'a' && command[i] == 'l')
                {
                    x.Append("al");
                    continue;
                }
                if (command[i - 1] == '(' && command[i] == ')')
                {
                    x.Append('o');
                    continue;
                }

            }
            return x.ToString();
        }
    }
}
