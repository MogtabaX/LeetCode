using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Running_Sum_of_1d_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            RunningSum(new int[] { 1, 2, 3, 4 });
        }

        public static int[] RunningSum(int[] nums)
        {
            int[] result = new int[nums.Length];
            int x=0;
            for(int i=0;i<nums.Length;++i)
            {
                x+=nums[i];
                result[i]=x;
            }
            return result;
        }
    }
}
