using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_Good_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            NumIdenticalPairs(new int[] {1,2,3,1,1,3)};
        }
        public static int NumIdenticalPairs(int[] nums)
        {
            //A pair (i, j) is called good if nums[i] == nums[j] and i < j.
            int i = 0;
            int j = 0;
            int x = 0;
            for (i = 0; i < nums.Length; ++i)
            { 
                for(j=0;j<nums.Length;++j)
                {
                    if (nums[i]==nums[j] && i<j)
                    {
                        ++x;  
                    }
                }
            }
            return x;
        }
    }
}
