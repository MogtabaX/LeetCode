using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle_String
{
    class Program
    {
        public static string RestoreString(string s, int[] indices)
        {
            string output = "";
            Console.WriteLine(output);
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (i == indices[j])
                    {
                        output+=(s[j]);                            
                    }
                }
            }
            return output;
        }
        static void Main(string[] args)
        {
            RestoreString("codeleet", new int[] { 4, 5, 6, 7, 0, 2, 1, 3 });
        }
    }
}
