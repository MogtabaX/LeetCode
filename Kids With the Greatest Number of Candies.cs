using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kids_With_the_Greatest_Number_of_Candies
{
    class Program
    {
        static void Main(string[] args)
        {
            KidsWithCandies(new int[] {2,3,5,1,3}, 3);
        }
        public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
        {
            bool[] result = new bool[candies.Length];
            int max = 0;
            int candiesLength = candies.Length;
            for (int i = 0; i < candiesLength; ++i)
            {
                if (candies[i] > max)
                {
                    max = candies[i];
                }
            }
            for (int i = 0; i < candiesLength; ++i)
            {
                if (candies[i] + extraCandies >= max)
                {
                    result[i] = true;
                }
                else
                {
                    result[i] = false;
                }
            
            }
            return result;
            //2024-2-28 , hint1
        }
    }
}
