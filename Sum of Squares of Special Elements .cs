using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Squares_of_Special_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfSquares(new int[] { 1, 2, 3, 4 });
        }
        public static int SumOfSquares(int[] nums)
        {
            sbyte i = 0;
            sbyte length =(sbyte) nums.Length;
            int x = 0;
            
            for (i = 0; i < length; ++i)
            {
                if (length % (i+1) == 0)
                {
                    x += nums[i]*nums[i];
                }
            }
            return x;
        }
    }
}
