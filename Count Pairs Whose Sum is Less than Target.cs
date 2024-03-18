using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Pairs_Whose_Sum_is_Less_than_Target
{
    class Program
    {
        static void Main(string[] args)
        {
            CountPairs(new int[] { -1, 1, 2, 3, 1 }, 2);
        }
        public static int CountPairs(IList<int> nums, int target)
        {
            int n= nums.Count;
            int x = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (((n > j && j > i)) && nums[i] + nums[j] < target)
                    {
                        x++;
                    }
                }
            }
            return x;
        }
    }
}
