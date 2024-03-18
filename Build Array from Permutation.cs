using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_Array_from_Permutation
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildArray(new int[] {0,2,1,5,3,4});
        }
        public static int[] BuildArray(int[] nums)
        {
            int[] ans = new int[nums.Length];
            int length = nums.Length;
            int i = 0;
            for (i = 0; i < nums.Length; ++i)
            {
                ans[i] = nums[nums[i]];
            }
            return ans;
        }
    }
}
