using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains_Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainsDuplicate(new int[] {1,1,1,3,3,4,3,2,4,2});
        }
        public static bool ContainsDuplicate(int[] nums)
        {
            Array.Sort(nums);
            for (int i=0; i<nums.Length-1;i++)
            {
                if(nums[i+1] == nums[i])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
