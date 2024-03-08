using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz(3);
        }
        public static IList<string> FizzBuzz(int n)
        {
            List<string> result = new List<string>();
            int i = 1;
            while (i <= n)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    result.Add("FizzBuzz");
                    ++i;
                    continue;
                }
                if (i % 3 == 0)
                {
                    result.Add("Fizz");
                    ++i;
                    continue;
                }
                if (i % 5 == 0)
                {
                    result.Add("Buzz");
                    ++i;
                    continue;
                }
                else
                {
                    result.Add(i.ToString());
                    ++i;
                }

            }
            return result;
        }
    }
}
