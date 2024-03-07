using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Majority_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 });
        }
       public static int MajorityElement(int[] nums) {
           if (nums.Length == 1)
           {
               return nums[0];
           }
           int g = nums.Length / 2;
           HashSet<int> hash = new HashSet<int>();
           Array.Sort(nums);
           int x = 0;
           for (int i = 0; i < nums.Length; i++)
           {
               if (!hash.Add(nums[i]))
               {
                   x++;
                   if (x >= g)
                   {
                       return nums[i];
                   }
               }
               else
               {
                   x = 0;
               }
           }
           return 0;
           //2024-3-7 15-20 minutes...
    }
    }
}
