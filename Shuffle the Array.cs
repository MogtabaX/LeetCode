using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle_the_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Shuffle(new int[] { 2, 5, 1, 3, 4, 7 }, 3);
        }
        public static int[] Shuffle(int[] nums, int n)
        {
            List<int> li = new List<int>();
            for (int i = 0; i < nums.Length-1; ++i)
            {
                li.Add(nums[i]);
                li.Add(nums[i + n]);
                if (li.Count == nums.Length)
                {
                    break;
                }
            }
            return li.ToArray();
        }
    }
}
