using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenation_of_Array
{
    class Program
    {
        /*
        Given an integer array nums of length n, you want to create an array ans of length 2n where ans[i] == nums[i] and ans[i + n] == nums[i] for 0 <= i < n (0-indexed).
        Specifically, ans is the concatenation of two nums arrays.
        Return the array ans.
          */
        static void Main(string[] args)
        {
            GetConcatenation(new int[] { 1, 2, 1 });
        }
        public static int[] GetConcatenation(int[] nums)
        {
            int[] ans = new int[nums.Length * 2];
            int k=0;
            for (int i = 0; i < 2; ++i)
            {
                for (int j = 0; j < ans.Length; ++j)
                {
                    if(k==nums.Length)
                    {
                        k=0;
                    }
                        ans[j] = nums[k];
                    k++;
                    }
                }
            
            return ans;
        }
    }
}
