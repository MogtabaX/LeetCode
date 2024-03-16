using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace How_Many_Numbers_Are_Smaller_Than_the_Current_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallerNumbersThanCurrent(new int[] { 8, 1, 2, 2, 3 });
        }
        public static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] solved = new int[nums.Length];
            int x = 0;
            int length = nums.Length;
            for (int i = 0; i < length; ++i)
            {
                for (int j = 0; j < length; ++j)
                {
                    if (nums[i] > nums[j])
                    {
                        x++;
                    }
                }
                solved[i] = x;
                x = 0;
            }

            return solved;
        }
    }
}
